using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace FontClass
{
    class TextDisplay
    {

        //text output for testing purposes
        SpriteFont Font1;

        SpriteBatch spritebatch;

        String aString;

        Vector2 stringPosition;

        public TextDisplay(String aString, Vector2 stringPosition)
        {
            this.aString = aString;
            this.stringPosition = stringPosition;
        }

        public void Load(ContentManager content)
        {
            Font1 = content.Load<SpriteFont>("SpriteFont1");
        }

        public void DrawFont(SpriteBatch spritebatch)
        {
            this.spritebatch = spritebatch;
            spritebatch.Begin();
            spritebatch.DrawString(Font1,
            aString,
            stringPosition,
            Color.Black);
            spritebatch.End();
        }

    }
}
