using Microsoft.Xna.Framework;

namespace FreeEC
{
    public interface IEntity<TSelf> : IEntity
        where TSelf : IEntity<TSelf>;

    public interface IEntity
    {
        void Update(GameTime gameTime);
        void Draw();

        ref T Get<T>() where T : IComponent;
        bool Has<T>() where T : IComponent;
        
        IEnumerable<IComponent> EnumerateComponents();
    }
}
