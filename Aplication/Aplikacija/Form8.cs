using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class Form8 : Form
    {
        private int score, speed;
        private bool up, down, right, left;

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                up = true;
            if (e.KeyCode == Keys.Down)
                down = true;
            if (e.KeyCode == Keys.Left)
                left = true;
            if (e.KeyCode == Keys.Right)
                right = true;
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                up = false;
            if (e.KeyCode == Keys.Down)
                down = false;
            if (e.KeyCode == Keys.Left)
                left = false;
            if (e.KeyCode == Keys.Right)
                right = false;
        }

        public Form8()
        {
            InitializeComponent();
            Restart();
        }

        private void gameTimeEvent(object sender, EventArgs e)
        {
            if (up)
            {
                pacman.Top -= speed;
                pacman.Image = Properties.Resources.up;
            }
            if (down)
            {
                pacman.Top += speed;
                pacman.Image = Properties.Resources.down;
            }
            if (right)
            {
                pacman.Left += speed;
                pacman.Image = Properties.Resources.right;
            }
            if (left)
            {
                pacman.Left -= speed;
                pacman.Image = Properties.Resources.left;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 10;
                            x.Visible = false;
                        }
                    }
                    if ((string)x.Tag == "wall" || (string)x.Tag == "ghost")
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameOver("You lost!");
                        }
                }
            }
        }

        private void GameOver(string message)
        {
            gameTime.Stop();
            txtScore.Text += Environment.NewLine + message;
        }

        private void Restart()
        {
            txtScore.Text = "Score: 0";
            score = 0;
            speed = 5;
            gameTime.Start();
        }
    }
}
