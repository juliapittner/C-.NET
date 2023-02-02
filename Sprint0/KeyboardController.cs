using System;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
	public class KeyboardController : IController
	{
		private Game1 game;
		private KeyboardState previousState;
		private Texture2D texture;
		private Texture2D textureTwo;
        private GraphicsDeviceManager graphics;
		private Dictionary<Keys, ICommand> controllerDictionary;

        public KeyboardController(Game1 game, Texture2D texture,Texture2D textureTwo, GraphicsDeviceManager graphics)
		{
			this.game = game;
			this.texture = texture;
			this.textureTwo = textureTwo;
            this.graphics = graphics;
            controllerDictionary = new Dictionary<Keys, ICommand>();
            
            createCommands();
        }
		

		public void createCommands()
		{
            controllerDictionary.Add(Keys.T, new MovingAnimatedCommand(this.game, textureTwo, graphics));
            controllerDictionary.Add(Keys.R, new MovingNonAnimatedCommand(this.game,textureTwo, this.graphics));
            controllerDictionary.Add(Keys.E, new NonMovingAnimatedCommand(this.game,textureTwo));
            controllerDictionary.Add(Keys.W, new NonMovingNonAnimatedCommand(this.game, texture));
			controllerDictionary.Add(Keys.Q, new ExitCommand(this.game));
        }

		public void Update()
		{
			KeyboardState currentState = Keyboard.GetState();
			Keys[] keysPressed = currentState.GetPressedKeys();

			foreach (Keys key in keysPressed)
			{
				if (!previousState.IsKeyDown(key))
				{
					switch (key)
					{
						case Keys.W:
						
							controllerDictionary[key].Execute();

							break;

						case Keys.R:

							controllerDictionary[key].Execute();

							break;

						case Keys.E:
							
							controllerDictionary[key].Execute();
							
							break;

						case Keys.T:
							
							controllerDictionary[key].Execute();
							
							break;

						case Keys.Q:

							controllerDictionary[key].Execute();

							break;

					}
				}
                previousState = currentState;
               
            }
            
        }

	}
}


