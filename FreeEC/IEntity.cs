using Microsoft.Xna.Framework;

namespace FreeEC
{
    public interface IEntity
    {
        void Update(GameTime gameTime);
        void Draw();

        ref T GetUpdate<T>() where T : IUpdateComponent;
        bool HasUpdate<T>() where T : IUpdateComponent;

        ref T GetDraw<T>() where T : IDrawComponent;
        bool HasDraw<T>() where T : IDrawComponent;
    }
}
