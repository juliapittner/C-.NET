using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Sprint0
{
    class LeftAndRight : ISprite

    {
        private Texture2D texture_;
        private int Position;
        private Rectangle rectangle_;
        private GraphicsDeviceManager graphics;
        private MarioRunning gameObj;
        private bool Left = false;

        public LeftAndRight(MarioRunning gameObj, GraphicsDeviceManager graphics)
        {
            this.graphics = graphics;
            this.gameObj = gameObj;
        }

        public void Update()
        {
            this.gameObj.Update();

            if (Left)
            {
                Position = Position - 1;
            }
            else
            {
                Position = Position + 1;
            }
            if (Position > graphics.PreferredBackBufferWidth - 17)
            {
                Left = true;
                this.gameObj.goLeft();
            }
            if (Position == 0)
            {
                Left = false;
                this.gameObj.goRight();

            }
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            this.gameObj.Position = new Vector2(Position, 0);
            this.gameObj.Draw(spriteBatch);
        }

    }
}


