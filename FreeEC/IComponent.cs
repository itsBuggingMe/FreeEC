using Microsoft.Xna.Framework;

namespace FreeEC
{
    public interface IUpdateComponent : IComponent
    {
        void Update(IEntity parent, GameTime gameTime);
    }

    public interface IDrawComponent : IComponent
    {
        void Draw(IEntity parent);
    }

    public interface IComponent;
}