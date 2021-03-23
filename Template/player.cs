using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Player : Basklass
    {
        Vector2 boardPos = new Vector2(300, 800);
        KeyboardState oldKState;
        public override void Update()
        {
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Right))
                boardPos.X += 10;
            if (kstate.IsKeyDown(Keys.Left))
                boardPos.X -= 10;


        }
    }
}
      
