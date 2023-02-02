using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
	public interface ISprite
	{
		void Draw(SpriteBatch spriteBatch);
		void Update();
	}
}

