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
    public partial class Form1 : Form
    {

        const int paddleSpeed = 2;

        bool isUpPressed, isDownPressed, isWPressed, isSPressed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isUpPressed)
            {
                paddle1.Location = new Point(paddle1.Location.X, paddle1.Location.Y - paddleSpeed);
            }

            if (isDownPressed)
            {
                paddle1.Location = new Point(paddle1.Location.X, paddle1.Location.Y + paddleSpeed);
            }

            if (isWPressed)
            {
                paddle2.Location = new Point(paddle2.Location.X, paddle2.Location.Y - paddleSpeed);
            }

            if (isSPressed)
            {
                paddle2.Location = new Point(paddle2.Location.X, paddle2.Location.Y + paddleSpeed);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                isUpPressed = true;
            } else if (e.KeyCode == Keys.Down)
            {
                isDownPressed = true;
            } else if (e.KeyCode == Keys.W)
            {
                isWPressed = true;
            } else if (e.KeyCode == Keys.S)
            {
                isSPressed = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                isUpPressed = false;
            } else if (e.KeyCode == Keys.Down)
            {
                isDownPressed = false;
            }
            else if (e.KeyCode == Keys.W)
            {
                isWPressed = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                isSPressed = false;
            }
        }
    }
}
