using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FreeEC
{
    public class World
    {
        private FastStack<IEntity> _entities = new(16);
        private readonly Dictionary<object, FastStack<IEntity>> _tagLookup = [];

        private readonly List<IUpdateComponent> _updates = [];
        private readonly List<IDrawComponent> _draw = [];
        private readonly Dictionary<int, object[]> _cachedArrs = [];
        private readonly Dictionary<int, Type[]> _genericArrs = [];

        public World With<T>(in T comp)
            where T : struct, IComponent
        {
            if (comp is IUpdateComponent c)
                _updates.Add(c);
            else if (comp is IDrawComponent d)
                _draw.Add(d);
            else
                throw new ArgumentException("Component must be update or draw", nameof(comp));
            return this;
        }

        public IEntity Finish()
        {
            IEntity result;

            int upddateCount = _updates.Count;

            if (upddateCount + _draw.Count == 0)
                throw new InvalidOperationException("Must have at least one update and draw component");

            if (upddateCount > 5 || _draw.Count > 3)
            {
                result = new Construct(_updates.ToArray(), _draw.ToArray());
            }
            else
            {
                Type genericType = Helpers.GenTypeMap[upddateCount][_draw.Count];
                object[] @params = GetCachedArray(_cachedArrs, upddateCount + _draw.Count);
                for (int i = 0; i < upddateCount; i++)
                    @params[i] = _updates[i];
                for (int i = 0; i < _draw.Count; i++)
                    @params[upddateCount + i] = _draw[i];

                Type[] typeArr = GetCachedArray(_genericArrs, upddateCount + _draw.Count);
                for (int i = 0; i < @params.Length; i++)
                    typeArr[i] = @params[i].GetType();

                Type definedType = genericType.MakeGenericType(typeArr);

                result = (IEntity)definedType.GetConstructors()[0].Invoke(@params);
            }

            _updates.Clear();
            _draw.Clear();
            _entities.Push(Register(result));
            return result;
        }

        private IEntity Register(IEntity e)
        {
            if (!e.HasUpdate<TagComponent>())
                return e;
            ref TagComponent tag = ref e.GetUpdate<TagComponent>();
            if (tag.Value is null)
                return e;
            if (_tagLookup.TryGetValue(tag.Value, out var collection))
            {
                collection.Push(e);
            }
            else
            {
                FastStack<IEntity> space = new(2);
                space.Push(e);
                _tagLookup[tag.Value] = space;
            }
            return e;
        }

        public World(int initalCapacity = 4)
        {
            if (initalCapacity <= 0)
                throw new ArgumentException("Inital capacity must be positive", nameof(initalCapacity));

            _entities = new FastStack<IEntity>(initalCapacity);
        }

        public void Update(GameTime gameTime)
        {
            var entSpan = _entities.AsSpan();
            for (var i = 0; i < entSpan.Length; i++)
            {
                entSpan[i].Update(gameTime);
            }
        }

        public void Draw()
        {
            var entSpan = _entities.AsSpan();
            for (var i = 0; i < entSpan.Length; i++)
                entSpan[i].Draw();
        }

        //O(n)
        public void Remove(IEntity toRemove)
        {
            var entSpan = _entities.AsSpan();
            for (int i = 0; i < entSpan.Length; i++)
            {//figure out some index of function
                if (entSpan[i] == toRemove)
                {
                    Remove(i);
                    return;
                }
            }
        }

        public void Remove(int index)
        {
            IEntity toRemove = _entities[index];
            if (toRemove.HasUpdate<TagComponent>() && _tagLookup.TryGetValue(toRemove.GetUpdate<TagComponent>().Value, out var stack))
            {
                var span = stack.AsSpan();
                for (int i = 0; i < span.Length; i++)
                {
                    if (toRemove == span[i])
                    {
                        stack.RemoveAtReplace(i);
                        break;
                    }
                }
            }
            _entities.RemoveAtReplace(index);
        }

        private static T[] GetCachedArray<T>(Dictionary<int, T[]> dict, int len)
        {
            if (dict.TryGetValue(len, out T[] val))
            {
                return val;
            }

            return dict[len] = new T[len];
        }

        /// <summary>
        /// O(1)
        /// </summary>
        public bool TryQuery(object key, [NotNullWhen(true)] out FastStack<IEntity> candidates)
        {
            if (_tagLookup.TryGetValue(key, out candidates))
            {
                return true;
            }
            candidates = default;
            return false;
        }

        /// <summary>
        /// basically O(1) unless you have a lot of entities with the same tag
        /// </summary>
        public bool TryQuery(object key, [NotNullWhen(true)] out IEntity result, Predicate<IEntity> selector = null)
        {
            if (TryQuery(key, out var stack))
            {
                if (selector is null && stack.HasElements)
                {
                    result = stack.Top;
                    return true;
                }
                else
                {//user has provided selector
                    foreach (var ent in stack.AsSpan())
                    {
                        if (selector(ent))
                        {
                            result = ent;
                            return true;
                        }
                    }
                }
            }
            result = default;
            return false;
        }
    }
}
