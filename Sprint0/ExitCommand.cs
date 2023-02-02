using System;
namespace Sprint0
{
	public class ExitCommand : ICommand
	{
        private Game1 myGame;

        public ExitCommand(Game1 game)
		{
			myGame = game;
		}

		public void Execute()
		{
			myGame.ExitCommand();
		}
	}
}

