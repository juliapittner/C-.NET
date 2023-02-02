using System;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
	
	public class NonMovingNonAnimatedCommand : ICommand
	{
		private Game1 myGame;
		private Texture2D texture;
		private ISprite sprites;
		public NonMovingNonAnimatedCommand(Game1 game, Texture2D texture)
		{
			myGame = game;
			this.texture = texture;
        }
		public void Execute()
		{
            sprites = new Brick(texture);
            myGame.sprite.Add(sprites);
        }
		
		
	}
}

