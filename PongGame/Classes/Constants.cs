using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame.Classes
{
    class Constants
    {
        //main canvas size
        public static readonly int CANVAS_WIDTH = 650;
        public static readonly int CANVAS_HEIGHT = 650;

        public static readonly int SPEED = 50;

        //platform settings
        public static readonly int PLATFORM_WIDTH = 20;
        public static readonly int PLATFORM_HEIGHT = 60;
        public static readonly int PLATFORM_SPEED = 7;
        public static readonly int PLATFORM_OFFSET = 50;

        //ball settings
        public static readonly int BALL_SIZE = 15;
        public static readonly int BALL_SPEED = 7;

        //enemy tracking settings
        public static readonly int ENEMY_TRACK_MARGIN = PLATFORM_HEIGHT / 2 - 1; // half the size of its platform

        //obstacle settings
        public static readonly int OBSTACLE_COUNT = 3;
        public static readonly int OBSTACLE_MIN_SPAWN = 0 + PLATFORM_OFFSET + (PLATFORM_WIDTH * 2);
        public static readonly int OBSTACLE_MAX_SPAWN = CANVAS_WIDTH - PLATFORM_OFFSET - (PLATFORM_WIDTH * 2);
        public static readonly int OBSTACLE_WIDTH = 7;
    }
}
