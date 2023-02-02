using System;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class GamepadController : IController
    { 
        private Game1 game;
        private KeyboardState previousState;
        private Texture2D texture;
        private Texture2D textureTwo;
        ICommand command;
        private GraphicsDeviceManager graphics;
        private Dictionary<Buttons, ICommand> controllerDictionary;
        public GamepadController(Game1 game, Texture2D texture, Texture2D textureTwo, GraphicsDeviceManager graphics)
        {
            this.game = game;
            this.texture = texture;
            this.textureTwo = textureTwo;
            this.graphics = graphics;
        }


        public void Update()
        {
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);

            
            if (currentState.IsButtonDown(Buttons.A))
            {
                command = new NonMovingNonAnimatedCommand(this.game, texture);
                command.Execute();

            }

            if (currentState.IsButtonDown(Buttons.B)) 
            {
                command = new NonMovingAnimatedCommand(this.game, textureTwo);
                command.Execute();
            }

            if (currentState.IsButtonDown(Buttons.X))
            {
                command = new MovingNonAnimatedCommand(this.game, textureTwo, this.graphics);
                command.Execute();
            }

            if (currentState.IsButtonDown(Buttons.Y))
            {
                command = new MovingAnimatedCommand(this.game, textureTwo, this.graphics);
                command.Execute();
            }

            if (currentState.IsButtonDown(Buttons.Start))
            {
                command = new ExitCommand(this.game);
                command.Execute();
            }

        }

    }
}



