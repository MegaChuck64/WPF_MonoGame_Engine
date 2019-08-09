
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Framework.WpfInterop;
using MonoGame.Framework.WpfInterop.Input;

namespace Engine
{
    public abstract class MainGame : WpfGame
    {
        private IGraphicsDeviceService graphics;

        private SpriteBatch spriteBatch;

        private Texture2D sprite;
        private Texture2D sprite2;

        protected override void Initialize()
        {
            graphics = new WpfGraphicsDeviceService(this);

            base.Initialize();
            spriteBatch = new SpriteBatch(GraphicsDevice);

            sprite = new Texture2D(GraphicsDevice, 16,16);
            sprite2 = new Texture2D(GraphicsDevice, 16, 16);

            Color[] cols = new Color[16 * 16];
            for (int i = 0; i < cols.Length; i++)
            {
                cols[i] = Color.White;
            }
            sprite.SetData(cols);
            sprite2.SetData(cols);

            Input.Init(this);
        }

        protected override void Update(GameTime time)
        {
            Input.Update();
            
        }

        protected override void Draw(GameTime time)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);


            spriteBatch.Begin();

            
            spriteBatch.Draw(sprite, new Vector2(10, 30), Color.Red);
            spriteBatch.Draw(sprite2, new Vector2(10, 100), Color.Green);
            spriteBatch.End();

        }

        public abstract void Start();
        public abstract void Update();
        public abstract void Draw();

    }
}
