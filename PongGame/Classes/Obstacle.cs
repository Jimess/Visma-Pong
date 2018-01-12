using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame.Classes
{
    class Obstacle : GameObject
    {
        public Obstacle(int X, int Y, Brush Color, int Width, int Height) : base(X, Y, Color, Width, Height)
        {
        }

        public static Obstacle GenerateObstacle (int r1, int r2)
        {
            return new Obstacle(r1, r2, Brushes.Black, Constants.OBSTACLE_WIDTH, Constants.PLATFORM_HEIGHT);
        }

        public override void Update()
        {
            // no need, unless make the obstacles move
        }

        //hiding intended
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, X, Y, Width, Height);
        }
    }
}
