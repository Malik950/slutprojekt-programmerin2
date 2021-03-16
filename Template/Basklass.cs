using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Basklass
    {
        KeyboardState oldKState;
        public void Update()
        {
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Right))
                PixelPos.X += 10;
            if (kstate.IsKeyDown(Keys.Left))
                PixelPos.X -= 10;
        }
    }
}
