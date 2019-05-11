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

        const int paddleSpeed = 2;

        public const int topOfScreen = 0;
        public const int bottomOfScreen = 500;
        Ball ball;


        bool isUpPressed, isDownPressed, isWPressed, isSPressed = false;
        //const Player player1, player2;

        public PongForm()
        {
            InitializeComponent();
            ball = new Ball(ballObject);
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

            moveBall(ball);
        }

        private void moveBall(Ball ball)
        {
            

            if (ball.ballFrame.Location.Y == topOfScreen || ball.ballFrame.Location.Y + ( ball.ballFrame.Height) == bottomOfScreen)
            {
                ball.ySpeed *= -1;
            }
            if (ball.ballFrame.Bounds.IntersectsWith(paddle1.Bounds) || ball.ballFrame.Bounds.IntersectsWith(paddle2.Bounds))
            {
                ball.xSpeed *= -1;
            }
            var speedY = ball.ySpeed;
            var speedX = ball.xSpeed;


            ball.ballFrame.Location = new Point(ball.ballFrame.Location.X + speedX,
                Math.Max(topOfScreen,
                Math.Min(bottomOfScreen - ball.ballFrame.Height, ball.ballFrame.Location.Y + speedY)
                )
                );
            
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
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            var isKeyDown = false;
            checkKeys(e,isKeyDown);
        }
    }
}
