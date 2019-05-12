using System;
using System.Drawing;
using System.Windows.Forms;

namespace PongApp
{
    internal class Ball
    {
        public PictureBox ballFrame;
        public int xSpeed, ySpeed;
        Random rand = new Random();

        //settings
        const int ballAccelleration = 2;
        const int startSpeed = 8;
        const int startAngle = 8;
        private int msBeforeBallAcceleration = 100;
       
        

        public Ball(PictureBox theBall)
        {
            this.ballFrame = theBall;
            randomSpeed();           
        }

        internal void randomSpeed()
        {
            xSpeed = startSpeed * rand.Next(1, 3);
            ySpeed = rand.Next(-startAngle, startAngle);

            if (ySpeed < 2 && ySpeed > - 2)
            {
                ySpeed = 4;
            }
            if (xSpeed == startSpeed * 2)
            {
                xSpeed /= -2;
            }
        }

        int ballTick = 0;
        

        public void moveBall(PictureBox[] bunceAbles)
        {
            ballTick++;
            //move ball
            doMove();

            //test for out od screen
            if (ballFrame.Location.Y == PongHelper.topOfScreen || ballFrame.Location.Y + (ballFrame.Height) == PongHelper.bottomOfScreen)
            {
                ySpeed *= -1;
            }

            //test if ball touchg paddles or other objects
            foreach (PictureBox b in bunceAbles)
            {

                if (ballFrame.Bounds.IntersectsWith(b.Bounds))
                {
                    //change direction
                    xSpeed *= -1;

                    while (b.Bounds.IntersectsWith(ballFrame.Bounds))
                    {
                        doMove();
                    }
                }
            }

            //accelerate every x milliseconds
            if (ballTick % msBeforeBallAcceleration == 0)
            {
                accelerateBall();
            }

        }

        private void accelerateBall()
        {
            //accelerate ball
            if (xSpeed < 0)
            {
                xSpeed += ballAccelleration * -1;
            }
            else
            {
                xSpeed += ballAccelleration;
            }
        }

        private void doMove()
        {
            var speedY = ySpeed;
            var speedX = xSpeed;



            //move ball
            ballFrame.Location = new Point(ballFrame.Location.X + speedX,
                Math.Max(PongHelper.topOfScreen,
                Math.Min(PongHelper.bottomOfScreen - ballFrame.Height, ballFrame.Location.Y + speedY)
                )
                );
        }

        internal void reset()
        {
            ballTick = 0;
            randomSpeed();
            ballFrame.Location = new Point(PongHelper.RightOfScreen / 2, PongHelper.bottomOfScreen / 2);
        }
    }
}