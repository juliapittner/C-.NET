using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Sprint0
{
    class UpAndDown : ISprite

    {
        public Texture2D texture;
        private int Position;
        private Rectangle rectangle;
        private GraphicsDeviceManager graphics;
        private bool Up = false;


        public UpAndDown(Texture2D texture, GraphicsDeviceManager graphics)
        {
            this.texture = texture;
            this.rectangle = new Rectangle(0, 14, 15, 18);
            this.graphics = graphics;
        }

        public void Update()
        {
            if(Up)
            {
                Position = Position - 1;
            }
            else
            {
                Position = Position + 1;
            }
            if(Position > graphics.PreferredBackBufferHeight - 17)
            {
                Up = true;
            }
            if(Position == 0)
            {
                Up = false;
            }

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, new Rectangle(10, Position, 15, 18), this.rectangle, Color.White);
        }

    }
}
