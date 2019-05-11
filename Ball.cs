using System;

namespace Pong {
    public class Ball
    {
        public PictureBox ball;
        int xSpeed, ySpeed;
        Random rand = new Random();

        public Ball(PictureBox theBall)
        {
            this.ball = theBall;
            xSpeed = rand.Next(-3, 3);
            ySpeed = rand.Next(-3, 3);
        }

        internal void ProccessMove()
        {
            var botom = 500;
            var top = 0;
        }
    }
}
