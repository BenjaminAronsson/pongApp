using System;
using System.Drawing;
using System.Windows.Forms;

namespace PongApp
{
    internal class Ball
    {
        public PictureBox ballFrame;
        public int xSpeed, ySpeed;
        const int ballAccelleration = 1;
        const int startSpeed = 5;
        Random rand = new Random();
        private int size;


        public Ball(PictureBox theBall)
        {
            this.ballFrame = theBall;
            randomSpeed();           
        }

        internal void randomSpeed()
        {
            xSpeed = rand.Next(-startSpeed, startSpeed);
            ySpeed = rand.Next(-startSpeed, startSpeed);

            if (ySpeed == 0)
            {
                ySpeed++;
            }
            if (xSpeed < 2 && xSpeed > -2)
            {
                xSpeed = rand.Next(-startSpeed, startSpeed); randomSpeed();
            }
        }

        public void moveBall(PictureBox[] bunceAbles)
        {
           
            //test for out od screen
            if (ballFrame.Location.Y == PongHelper.topOfScreen || ballFrame.Location.Y + (ballFrame.Height) == PongHelper.bottomOfScreen)
            {
                ySpeed *= -1;
            }

            //test if ball touchg paddles or other objects
            foreach ( PictureBox b in bunceAbles) {

                if (ballFrame.Bounds.X == 5)
                {

                }

                
                if (ballFrame.Bounds.IntersectsWith(b.Bounds))
                {
                    xSpeed *= -1;
                }
            }
            
            var speedY = ySpeed ;
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
            ballFrame.Location = new Point(PongHelper.RightOfScreen / 2, PongHelper.bottomOfScreen / 2);
            randomSpeed();
        }
    }
}