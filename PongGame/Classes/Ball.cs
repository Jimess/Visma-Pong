using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame.Classes
{
    class Ball : GameObject
    {
        private int velocityX;
        private int velocityY;

        //collision fix
        public bool collided = false;

        public Ball(int X, int Y, Brush Color, int Width, int Height, int velX, int velY) : base(X, Y, Color, Width, Height)
        {
            velocityX = velX;
            velocityY = velY;
        }

        public override void Update()
        {
            X += velocityX;
            Y += velocityY;

            Y = Clamp(Y, 0, Constants.CANVAS_HEIGHT - Height);
            X = Clamp(X, 0, Constants.CANVAS_WIDTH - Width);

            //checks only for game bounds
            if (X >= Constants.CANVAS_WIDTH - Width)
            {
                // player wins
                Stats.PlayerPoint();
            } else if (X <= 0)
            {
                //enemy wins
                Stats.EnemyPoint();
            }

            else if (Y <= 0 || Y >= Constants.CANVAS_HEIGHT - Height)
            {
                velocityY = -velocityY;
            }
        }

        // checks if tho objects have collided
        public bool Overlap(GameObject other)
        {
            //a way to detect collision. This method is not perfect as it will only count the collision
            //when one object is already inside another. This can raise some collision problems as INTS are used and not doubles
            Rectangle gameObject = new Rectangle(X, Y, Width, Height);
            Rectangle otherObject = new Rectangle(other.X, other.Y, other.Width, other.Height);

            if (gameObject.IntersectsWith(otherObject))
            {
                collided = true;
                return true;
            }

            return false;
        }


        public void CollisionHandling(GameObject other)
        {
            if (other.GetType() != GetType() && Overlap(other))
            {
                velocityX = -velocityX;
                Console.WriteLine("Handling collision");
            }
        }
    }
}
