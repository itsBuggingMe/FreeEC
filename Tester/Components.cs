using FreeEC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tester
{
    internal struct SpriteComponent(SpriteBatch spriteBatch, Texture2D texture) : IDrawComponent
    {
        public void Draw(IEntity p) => spriteBatch.Draw(texture, p.GetUpdate<PositionComponent>().Position, Color.Black);
    }

    internal struct PositionComponent(Vector2 position, Vector2 velocity, float Resistance) : IUpdateComponent
    {
        public Vector2 Position = position;
        public Vector2 Velocity = velocity;
        public void Update(IEntity p, GameTime gameTime) => Position += Velocity *= Resistance;
    }

    internal struct JumpTowardsCursorBehavior : IUpdateComponent
    {
        public void Update(IEntity parent, GameTime gameTime)
        {
            ref PositionComponent pos = ref parent.GetUpdate<PositionComponent>();
            Vector2 target = InputHelper.MouseLocation.ToVector2();
            pos.Velocity = -0.01f * (pos.Position - target);
        }
    }
}