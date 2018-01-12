using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PongGame.Classes;

namespace PongGame
{
    public partial class Form1 : Form
    {
        private PlayerPlatform player;
        private EnemyPlatform enemy;
        private Ball ball;

        private List<GameObject> objects = new List<GameObject>();

        public Form1()
        {
            InitializeComponent();
            

            //reset the stats
            new Stats();

            //start the game timer. the rate at which the game will refresh
            gameTimer.Interval = 1000 / Constants.SPEED;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            

            //start the game
            //TODO: will start the game on button click
            StartGame();
        }

        private void StartGame()
        {
            //clear lists
            objects.Clear();

            //adding new player
            player = new PlayerPlatform(0 + Constants.PLATFORM_OFFSET, gameCanvas.Size.Height / 2 - Constants.PLATFORM_HEIGHT / 2,
                Brushes.Blue, Constants.PLATFORM_WIDTH, Constants.PLATFORM_HEIGHT);
            objects.Add(player);

            //adding new enemy
            enemy = new EnemyPlatform(gameCanvas.Width - Constants.PLATFORM_WIDTH - Constants.PLATFORM_OFFSET,
                gameCanvas.Size.Height / 2 - Constants.PLATFORM_HEIGHT / 2, Brushes.Blue, Constants.PLATFORM_WIDTH, Constants.PLATFORM_HEIGHT);
            objects.Add(enemy);

            ball = new Ball(Constants.CANVAS_WIDTH / 2 - Constants.BALL_SIZE, Constants.CANVAS_HEIGHT/2 - Constants.BALL_SIZE, Brushes.White,
                Constants.BALL_SIZE, Constants.BALL_SIZE, Constants.BALL_SPEED, Constants.BALL_SPEED);

            //set the ball for the enemy to see
            enemy.SetBall(ball);

            objects.Add(ball);

            Random r = new Random();
            //create a few obstacles
            for (int i = 0; i < Constants.OBSTACLE_COUNT; i++)
            {
                objects.Add(Obstacle.GenerateObstacle(r.Next(Constants.OBSTACLE_MIN_SPAWN, 
                    Constants.OBSTACLE_MAX_SPAWN), r.Next(0 + Constants.PLATFORM_HEIGHT, Constants.CANVAS_HEIGHT - Constants.PLATFORM_HEIGHT)));
            }

        }

        private void ResetLayout ()
        {
            StartGame();
        }

        private void ResetGame ()
        {
            Stats.Reset = false;
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Stats.Reset)
            {
                if (!Stats.LayoutReset)
                {
                    //restart game layout
                    ResetLayout();
                    Stats.LayoutReset = true;
                }

                //show restart message
                continueLabel.Visible = true;

                //get input
                if (Input.GetKeyPressed(Keys.Enter))
                {
                    //restart game
                    ResetGame();

                    //hide restart message
                    continueLabel.Visible = false;

                    Stats.LayoutReset = false;
                }
                
            } else if (Stats.GameOver)
            {
                // do something
                winLabel.Text = Stats.Winner;
                winLabel.Visible = true;

                restartLabel.Visible = true;

                if (Input.GetKeyPressed(Keys.Enter))
                {
                    Stats.GameOver = false;
                    //reset stats
                    new Stats();
                    StartGame();
                }
            } else if (!Stats.GameOver)
            {
                //reset labels just in case
                winLabel.Visible = false;
                restartLabel.Visible = false;

                //main update loop

                if (Input.GetKeyPressed(Keys.S))
                {
                    //MovePlatform(0); // moves the platform right
                    player.Direction = Constants.PLATFORM_SPEED;
                }
                else if (Input.GetKeyPressed(Keys.W))
                {
                    player.Direction = -Constants.PLATFORM_SPEED;
                }
                else
                {
                    player.Direction = 0;
                }

                foreach (GameObject obj in objects)
                {
                    if (!ball.collided)
                    {
                        ball.CollisionHandling(obj);
                    }
                    ball.collided = false;

                    obj.Update();
                }
            }

            //update scores
            enemyScore.Text = Stats.EnemyScore.ToString();
            yourScore.Text = Stats.YourScore.ToString();

            //update GUI
            gameCanvas.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void gameCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (GameObject obj in objects)
            {
                obj.Draw(g);
            }
        }
    }
}
