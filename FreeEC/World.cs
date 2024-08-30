using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FreeEC
{
    public class World
    {
        private FastStack<IEntity> _entities;

        private List<IUpdateComponent> _updates = [];
        private List<IDrawComponent> _draw = [];
        private Dictionary<int, object[]> _cachedArrs = [];
        private Dictionary<int, Type[]> _genericArrs = [];

        public World With<T>(in T comp)
            where T : IComponent
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
            _entities.Push(result);
            return result;
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

        public void Remove(int index) => _entities.RemoveAtReplace(index);

        private static T[] GetCachedArray<T>(Dictionary<int, T[]> dict, int len)
        {
            if (dict.TryGetValue(len, out T[]? val))
            {
                return val;
            }

            return dict[len] = new T[len];
        }


        private struct FastStack<T>(int initalComponents = 4)
        {
            private T[] _buffer = new T[initalComponents > 0 ? initalComponents : throw new ArgumentException()];
            private uint _nextIndex = 0;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Push(T comp)
            {
                if (_nextIndex < _buffer.Length)
                {
                    _buffer[_nextIndex++] = comp;
                }//i think this avoids extra bounds check
                else
                {
                    Array.Resize(ref _buffer, _buffer.Length * 2);
                    _buffer[_nextIndex++] = comp;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public T Pop() => _buffer[--_nextIndex];

            public void RemoveAtReplace(int index)
            {
                _buffer[index] = _buffer[--_nextIndex];
                _buffer[_nextIndex] = default!;
            }

            /// <summary>
            /// DO NOT ALTER WHILE SPAN IS IN USE
            /// </summary>
            public readonly Span<T> AsSpan() => new(_buffer, 0, (int)_nextIndex);

            public void Clear()
            {
                if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
                    AsSpan().Clear();
                _nextIndex = 0;
            }
        }
    }
}
