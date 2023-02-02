using System;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{

    public class NonMovingAnimatedCommand : ICommand
    {
        private Game1 myGame;
        private Texture2D texture;
        private ISprite sprites;
        public NonMovingAnimatedCommand(Game1 game, Texture2D texture)
        {
            myGame = game;
            this.texture = texture;

        }
        public void Execute()
        {
            sprites = new MarioRunning(texture);
            myGame.sprite.Add(sprites);
        }


    }
}


