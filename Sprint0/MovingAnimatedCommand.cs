using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{

    public class MovingAnimatedCommand : ICommand
    {
        private Game1 myGame;
        private MarioRunning mario;
        private ISprite sprites;
        private GraphicsDeviceManager graphics;

        public MovingAnimatedCommand(Game1 game, Texture2D texture, GraphicsDeviceManager graphics)
        {
            myGame = game;
            this.graphics = graphics;
            mario = new MarioRunning(texture);
        }
        public void Execute()
        {
            sprites = new LeftAndRight(mario, graphics);
            myGame.sprite.Add(sprites);

        }


    }
}
