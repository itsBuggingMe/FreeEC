using FreeEC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Runtime.CompilerServices;
using System;

namespace Tester;

public struct SpriteComponent(SpriteBatch spriteBatch, Texture2D texture) : IDrawComponent
{
    public float Opacity = 1;
    public void Draw<E>(E p) where E : IEntity<E>
        => spriteBatch.Draw(texture, p.GetUpdate<PositionComponent>().Position, null, Color.Black * Opacity, 0, default, 4, SpriteEffects.None, 0);
}

public struct PositionComponent(Vector2 position, Vector2 velocity, float Resistance) : IUpdateComponent
{
    public Vector2 Position = position;
    public Vector2 Velocity = velocity;
    public void Update<E>(E p, GameTime gameTime) where E : IEntity<E> => Position += Velocity *= Resistance;
}

public struct RandomBehavior() : IUpdateComponent
{
    private int TimeTillJump = Random.Shared.Next(500);
    public void Update<E>(E parent, GameTime gameTime) where E : IEntity<E>
    {
        if(TimeTillJump-- < 0)
        {
            TimeTillJump = Random.Shared.Next(500);
            parent.GetUpdate<PositionComponent>().Velocity += GameRoot.RandomVector() * 10;
        }
    }
}