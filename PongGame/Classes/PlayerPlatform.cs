using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame.Classes
{
    class PlayerPlatform : GameObject
    {
        public PlayerPlatform(int X, int Y, Brush Color, int Width, int Height) : base(X, Y, Color, Width, Height)
        {
        }

        public override void Update()
        {
            Y += Direction;
            Y = Clamp(Y, 0, Constants.CANVAS_HEIGHT - Height);

        }
    }
}
