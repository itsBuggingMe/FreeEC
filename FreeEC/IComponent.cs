using Microsoft.Xna.Framework;

namespace FreeEC
{
    public interface IUpdateComponent : IComponent
    {
        void Update<T>(T parent, GameTime gameTime) where T : IEntity<T>;
    }
    public interface IDrawComponent : IComponent
    {
        void Draw<T>(T parent) where T : IEntity<T>;
    }
    public interface IComponent;
}