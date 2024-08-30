using Microsoft.Xna.Framework;
using System.Runtime.CompilerServices;

namespace FreeEC
{
    public class Construct(ReadOnlySpan<IUpdateComponent> updateComponents, ReadOnlySpan<IDrawComponent> drawComponents)
        : IEntity
    {
        private readonly IUpdateComponent[] _update = updateComponents.ToArray();
        private readonly IDrawComponent[] _draw = drawComponents.ToArray();

        public void Update(GameTime gameTime)
        {
            foreach (var i in _update)
                i.Update(this, gameTime);
        }

        public void Draw()
        {
            foreach (var i in _draw)
                i.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {
            for (int i = 0; i < _update.Length; i++)
                if (_update[i] is T)
                    return ref Unsafe.As<IUpdateComponent, T>(ref _update[i]);
            return ref Helpers.Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
            => _update.Any(d => d is T);

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            for (int i = 0; i < _draw.Length; i++)
                if (_draw[i] is T)
                    return ref Unsafe.As<IDrawComponent, T>(ref _draw[i]);
            return ref Helpers.Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
            => _draw.Any(d => d is T);
    }
}