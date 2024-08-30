using Microsoft.Xna.Framework;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FreeEC
{
    public class Construct
        : IEntity<Construct>
    {
        private readonly ITypedBase<IUpdateComponent>[] _update;
        private readonly ITypedBase<IDrawComponent>[] _draw;
        public Construct(ReadOnlySpan<IUpdateComponent> updateComponents, ReadOnlySpan<IDrawComponent> drawComponents)
        {
            throw new NotImplementedException("Tell me to finish this");
            _update = new ITypedBase<IUpdateComponent>[updateComponents.Length];
            _draw = new ITypedBase<IDrawComponent>[drawComponents.Length];
            for (int i = 0; i < updateComponents.Length; i++)
            {
                _update[i] = new TypedBox<IUpdateComponent>(updateComponents[i]);
            }
            for (int i = 0; i < drawComponents.Length; i++)
            {
                _draw[i] = new TypedBox<IDrawComponent>(drawComponents[i]);
            }
        }


        public void Update(GameTime gameTime)
        {
            foreach (var i in _update)
                i.Value.Update(this, gameTime);
        }

        public void Draw()
        {
            foreach (var i in _draw)
                i.Value.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {
            for (int i = 0; i < _update.Length; i++)
                if (_update[i].Is<T>())
                {
                    //even though they are the same type, we can't cast or use `is`
                    //we need to preserve the ref to _value, and those make copies of pointers or structs members

                    //ref T result = Unsafe.As<IUpdateComponent>(ref _update[i].Value);

                    //return ref result;
                }
            return ref Helpers.Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
            => _update.Any(d => d is T);

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            for (int i = 0; i < _draw.Length; i++)
                if (_draw[i] is T)
                {
                    
                    //return ref Unsafe.As<IDrawComponent, T>(ref _draw[i]);
                }
            return ref Helpers.Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
            => _draw.Any(d => d is T);

        internal record class TypedBox<T> : ITypedBase<T>
        {
            private T _value;
            public TypedBox(T value)
            {
                _value = value;
            }
            public ref T Value => ref _value;

            public bool Is<T1>() => _value is not null && typeof(T1) == _value.GetType();

            public bool TryGetValueRefAs<T1>(ref T1 value)
            {
                if (typeof(T1) == typeof(T))
                {
                    value = ref Unsafe.As<T, T1>(ref _value);
                    return true;
                }
                return false;
            }
        }

        private interface ITypedBase<T>
        {
            public ref T Value { get; }
            bool Is<T1>();
        }
    }
}