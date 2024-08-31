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
        const int Boxes = 100_000;
        public static Vector2 MousePosition { get; set; }
        public static bool Click { get; set; }

        public GameRoot()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        public static Vector2 RandomVector() => RandomVectorPos() * 2 - Vector2.One;
        public static Vector2 RandomVectorPos() => new Vector2(Random.Shared.NextSingle(), Random.Shared.NextSingle());

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

                _world
                    .With(new PositionComponent(RandomVectorPos() * clientSize, RandomVector(), 0.99f))
                    .With(new RandomBehavior())
                    .With(new SpriteComponent(_spriteBatch, _pix))
                    .Finish();
            }
        }

        protected override void Update(GameTime gameTime)
        {
            InputHelper.TickUpdate(IsActive);
            if (InputHelper.Down(Keys.Escape))
                Exit();
            MousePosition = InputHelper.MouseLocation.ToVector2();
            Click = InputHelper.RisingEdge(MouseButton.Left);
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
