using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PongGame.Classes
{
    public abstract class GameObject
    {
        //positions vars
        public int X { get; set; }
        public int Y { get; set; }
        Brush Color; // set up different colour for different GameObjects
        public int Width { get; set; }
        public int Height { get; set; }
        //direction var
        public int Direction;

        public GameObject(int X, int Y, Brush Color, int Width, int Height)
        {
            this.X = X;
            this.Y = Y;
            this.Color = Color;
            this.Width = Width;
            this.Height = Height;
        }

        //draws the object. will be used for player and enemy
        // obstacles will override this
        public virtual void Draw(Graphics g)
        {
            g.FillRectangle(Color, new Rectangle(X, Y, Width, Height));
        }

        // update method for movement
        public abstract void Update();

        // clamps 
        public int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }


    }
}
