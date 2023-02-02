using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
	public class MovingNonAnimatedCommand : ICommand
	{
        private Game1 myGame;
        private Texture2D texture;
        private ISprite sprites;
        private GraphicsDeviceManager graphics;
        public MovingNonAnimatedCommand(Game1 game, Texture2D texture, GraphicsDeviceManager graphics) 
        {
            myGame = game;
            this.graphics = graphics;
            this.texture = texture;
        }
        public void Execute()
        {
            sprites = new UpAndDown(texture, graphics);
            
            myGame.sprite.Add(sprites);
           
        }

    }
}

