using System.Windows.Forms;

namespace PongApp
{
    internal class Player
    {
        private int score = 0;
        private PictureBox paddle;

        public Player(PictureBox paddle)
        {
            this.paddle = paddle;
        }

        public void movePadle()
        {

        }

        public PictureBox Paddle { get => paddle; set => paddle = value; }
        public int Score { get => score; set => score = value; }
    }
}