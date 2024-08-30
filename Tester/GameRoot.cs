using FreeEC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Tester
{
    public class GameRoot : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private static Texture2D _pix;
        private World _world = new World(1);
        const int Boxes = 10000;

        public GameRoot()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            _pix = new Texture2D(_graphics.GraphicsDevice, 1, 1);
            _pix.SetData([Color.White]);
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //actual stuff
            Vector2 clientSize = Window.ClientBounds.Size.ToVector2();

            for (int i = 0; i < Boxes; i++)
            {
                //TODO: use the better normal method syntax
                _world
                    .With(new PositionComponent(new Vector2(Random.Shared.NextSingle() * clientSize.X, Random.Shared.NextSingle() * clientSize.Y), Vector2.UnitX, 0.95f))
                    .With(new JumpTowardsCursorBehavior())
                    .With(new SpriteComponent(_spriteBatch, _pix))
                    .Finish();
            }
        }

        protected override void Update(GameTime gameTime)
        {
            InputHelper.TickUpdate(IsActive);
            if (InputHelper.Down(Keys.Escape))
                Exit();
            _world.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _world.Draw();
            _spriteBatch.End();
        }
    }
}
