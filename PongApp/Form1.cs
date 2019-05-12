using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongApp
{
    public partial class PongForm : Form
    {

        const int paddleSpeed = 8;
        bool isPaused = true;
        bool isStartup = true;

        public const int topOfScreen = 0;
        public const int bottomOfScreen = 500;
        Ball ball;
        PictureBox[] paddles;


        bool isUpPressed, isDownPressed, isWPressed, isSPressed = false;
        internal Player player1, player2;

        public PongForm()
        {
            InitializeComponent();

            setupGame();
        }

        private void setupGame()
        {
            //the ball
            ball = new Ball(ballObject);

            //players
            player1 = new Player(paddle1);
            player2 = new Player(paddle2);

            //all objects the ball will bounce of
            paddles = new PictureBox[] { paddle1, paddle2 };

            updateScoreLable();

            timer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              
            

            if (isUpPressed)
            {
                doMove(isUpPressed, paddle1);
            }

            if (isDownPressed)
            {
                doMove(false, paddle1);
            }

            if (isWPressed)
            {
                doMove(isWPressed, paddle2);
            }

            if (isSPressed)
            {
                doMove(false, paddle2);
            }

            ball.moveBall(paddles);

            if (ball.ballFrame.Location.X <= PongHelper.leftOfScreen || ball.ballFrame.Location.X >= PongHelper.RightOfScreen)
            {
                if(ball.ballFrame.Location.X <= PongHelper.leftOfScreen + 5)
                {
                    player2.Score++;
                }
                else
                {
                    player1.Score++;
                }
                updateScoreLable();
                ball.reset();
            }
        }

       

        private void updateScoreLable()
        {
            string elScore = player1.Score + " : " + player2.Score;

            scoreLable.Text = elScore;
        }

        private void doMove(bool? goingUp, PictureBox ob)
        {
            if (goingUp.HasValue)
            {
                var speed = paddleSpeed;
                if (goingUp.Value)
                {
                    speed *= -1;
                }
                ob.Location = new Point(ob.Location.X,
                    Math.Max(topOfScreen,
                    Math.Min(bottomOfScreen - ob.Height, ob.Location.Y + speed)
                    )
                 );
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var isKeyDown = true;
            checkKeys(e, isKeyDown);

        }

        private void checkKeys(KeyEventArgs e, bool isKeyDown)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    isUpPressed = isKeyDown;
                    break;
                case Keys.Down:
                    isDownPressed = isKeyDown;
                    break;
                case Keys.W:
                    isWPressed = isKeyDown;
                    break;
                case Keys.S:
                    isSPressed = isKeyDown;
                    break;
                case Keys.P:
                    if (!isKeyDown)
                    {
                        pauseGame();
                    }
                    break;
                default:
                    if(isStartup)
                    {
                        isStartup = false;
                        pauseGame();
                        //hide start label
                        
                    }
                    break;
            }
        }

        private void pauseGame()
        {
            
            if (isPaused)
            {
                infoLable.Hide();
                timer.Start();
            } else
            {
                timer.Stop();
                infoLable.Text = "Game paused\nPress P to continue playing";
                infoLable.Show();
            }
            
            isPaused = !isPaused;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            var isKeyDown = false;
            checkKeys(e,isKeyDown);
        }
    }
}
