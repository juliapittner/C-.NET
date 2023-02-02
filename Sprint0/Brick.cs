using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Sprint0
{
    public class Brick : ISprite

    {
        private Texture2D texture;
        public Vector2 Position;
        private Rectangle rectangle;

        public Brick(Texture2D texture)
        {
            this.texture = texture;
            this.Position = new Vector2(25, 25);
            this.rectangle = new Rectangle(80, 112, 16, 16);
        }
        public void Update()
        {
        }

        public void Draw (SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.Position, this.rectangle, Color.White);
        }
    }
}

