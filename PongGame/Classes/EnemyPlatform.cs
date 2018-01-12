using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame.Classes
{
    class EnemyPlatform : GameObject
    {
        private Ball ball;
        public EnemyPlatform(int X, int Y, Brush Color, int Width, int Height) : base(X, Y, Color, Width, Height)
        {
        }

        public void SetBall(Ball ball)
        {
            this.ball = ball;
        }

        public override void Update()
        {
            int distance = ball.Y - Y; //+is to move down - is to move up

            //check whether  the enemy needs to move or not
            if (Math.Abs(distance) > Constants.ENEMY_TRACK_MARGIN)
            {
                if (distance > 0) // just checking if positive
                {
                    Direction = Constants.PLATFORM_SPEED;
                } else if (distance < 0)
                {
                    Direction = -Constants.PLATFORM_SPEED;
                }
            } else
            {
                Direction = 0;
            }

            //update enemy position
            Y += Direction;
            Y = Clamp(Y, 0, Constants.CANVAS_HEIGHT - Height);

        }
    }
}
