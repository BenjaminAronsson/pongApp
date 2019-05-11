using System;
using System.Windows.Forms;

namespace PongApp
{
    internal class Ball
    {
        public PictureBox ballFrame;
        public int xSpeed, ySpeed;
        Random rand = new Random();


        public Ball(PictureBox theBall)
        {
            this.ballFrame = theBall;
            xSpeed = rand.Next(-10, 10);
            ySpeed = rand.Next(-10, 10);

            if(ySpeed == 0 || xSpeed == 0)
            {
                ySpeed++;
                xSpeed++;
            }
        }

        internal void ProccessMove()
        {
            var botom = 500;
            var top = 0;
        }
    }
}