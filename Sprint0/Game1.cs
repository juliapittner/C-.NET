using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static System.Net.Mime.MediaTypeNames;

namespace Sprint0
{

    public class Game1 : Game
    {
        public GraphicsDeviceManager _graphics;
        public SpriteBatch spriteBatch;
        public List <ISprite> sprite;
        private KeyboardController keyboard;
        private GamepadController gamepad;
        private SpriteFont font;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();

        }

        protected override void LoadContent()
        {
            
            sprite = new List<ISprite>();
            

            spriteBatch = new SpriteBatch(GraphicsDevice);

            font = Content.Load<SpriteFont>("myfont");
            var brickTexture = Content.Load<Texture2D>("blocks");
            var textureMario = Content.Load<Texture2D>("mario");

            keyboard = new KeyboardController(this, brickTexture, textureMario, _graphics);
            gamepad = new GamepadController(this, brickTexture, textureMario, _graphics);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            keyboard.Update();
            gamepad.Update();

            foreach (var Sprite in sprite)
            {
                Sprite.Update();
            }


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
        
            spriteBatch.Begin();
           

            spriteBatch.DrawString(font, "SUPER MARIO BROS.", new Vector2(315, 40), Color.Red);
            spriteBatch.DrawString(font, "GAME CONTROLS", new Vector2(321, 65), Color.Red);
            spriteBatch.DrawString(font, "Keyboard", new Vector2(210, 90), Color.Red);
            spriteBatch.DrawString(font, "Gamepad", new Vector2(500, 90), Color.Red);
            spriteBatch.DrawString(font, "Q = Quit,    W = Non-Moving Non-Animated Sprite", new Vector2(100, 110), Color.Black, 0, new Vector2(0,0), 0.65f, SpriteEffects.None, 0.5f);
            spriteBatch.DrawString(font, "E = Non-Moving Animated Sprite,  R = Moving Non-Animated Sprite", new Vector2(100, 120), Color.Black, 0, new Vector2(0, 0), 0.65f, SpriteEffects.None, 0.5f);
            spriteBatch.DrawString(font, "T = Moving Animated Sprite", new Vector2(100, 130), Color.Black, 0, new Vector2(0, 0), 0.65f, SpriteEffects.None, 0.5f);
            spriteBatch.DrawString(font, "Start = Quit,  A = Non-Moving Non-Animated Sprite", new Vector2(450, 110), Color.Black, 0, new Vector2(0, 0), 0.65f, SpriteEffects.None, 0.5f);
            spriteBatch.DrawString(font, "B = Non-Moving Animated Sprite,  X = Moving Non-Animated Sprite", new Vector2(450, 120), Color.Black, 0, new Vector2(0, 0), 0.65f, SpriteEffects.None, 0.5f);
            spriteBatch.DrawString(font, "Y = Moving Animated Sprite ", new Vector2(450, 130), Color.Black, 0, new Vector2(0, 0), 0.65f, SpriteEffects.None, 0.5f);

            foreach (var sprites in sprite)
            {
                sprites.Draw(spriteBatch);
            }
            
            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        public void ExitCommand()
        {
            Exit();
        }
    }
}
