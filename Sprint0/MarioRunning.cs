using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class MarioRunning : ISprite
    {

        private Texture2D texture;
        public Vector2 Position;
        private Rectangle[] leftRectangles;
        private int currentAnimation = 0;
        private int previousAnimation = 2;
        private int i = 0;
        private Rectangle[] rightRectangles;
        private bool left = false;

        public MarioRunning(Texture2D texture)
        {
            this.texture = texture;
            leftRectangles = new Rectangle[4];
            leftRectangles[0] = new Rectangle(149, 0, 15, 18);
            leftRectangles[1] = new Rectangle(120, 0, 15, 18);
            leftRectangles[2] = new Rectangle(89, 0, 15, 18);
            leftRectangles[3] = new Rectangle(120, 0, 15, 18);

            rightRectangles = new Rectangle[4];
            rightRectangles[0] = new Rectangle(300, 0, 15, 18);
            rightRectangles[1] = new Rectangle(269, 0, 15, 18);
            rightRectangles[2] = new Rectangle(240, 0, 15, 18);
            rightRectangles[3] = new Rectangle(269, 0, 15, 18);

            this.Position = new Vector2(200, 200);
        }

        public void goLeft()
        {
            left = true;
        }

        public void goRight()
        {
            left = false;
        }


        public void Update()
        {

            if (i > 10)
            {

                i = 0;
                currentAnimation = (currentAnimation + 1) % 4;

            }
            else
            {
                i++;
            }

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (left)
            {
                spriteBatch.Draw(this.texture, Position, leftRectangles[currentAnimation], Color.White);
            }
            else
            {
                spriteBatch.Draw(this.texture, Position, rightRectangles[currentAnimation], Color.White);
            }
        }

    }

}

