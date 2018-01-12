using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame.Classes
{
    class Stats
    {
        public static int YourScore { get; set; }
        public static int EnemyScore { get; set; }
        public static bool GameOver { get; set; }
        public static bool Reset { get; set; }
        public static bool LayoutReset { get; set; }
        public static string Winner { get; set; }

        //default constructor
        //will only be called when the static variables need resetting
        public Stats()
        {
            YourScore = 0;
            EnemyScore = 0;
            GameOver = false;
        }

        public static void PlayerPoint()
        {
            YourScore += 1;
            
            if (YourScore >= 3)
            {
                Winner = "You Win!";
                GameOver = true;
            } else
            {
                Reset = true;
                LayoutReset = false;
            }


        }

        public static void EnemyPoint()
        {
            EnemyScore += 1;

            if (EnemyScore >= 3)
            {
                Winner = "Enemy Wins!";
                GameOver = true;
            } else
            {
                Reset = true;
                LayoutReset = false;
            }
        }
    }
}
