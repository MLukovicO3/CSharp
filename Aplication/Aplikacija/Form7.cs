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
    public partial class Form7 : Form
    {
        private bool up, down, right, left, isGameOver, isGameWon;
        private int score;
        private int speed;
        private int i=0;
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Restart();
                txtScore.Text = "Score: " + score;
            }
        }

        private int redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY;
        public Form7()
        {
            InitializeComponent();
            txtScore.Text += Environment.NewLine + "Enter to start";
        }

        private void gameTimeEvent(object sender, EventArgs e)
        {
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

            red.Left -= redGhostSpeed;
            red.Top += redGhostSpeed;

            pink.Left -= pinkGhostX;

            red1.Left -= redGhostSpeed;
            red1.Top -= redGhostSpeed;

            yellow.Top -= yellowGhostSpeed;

            red2.Left += redGhostSpeed;
            red2.Top -= redGhostSpeed;

            pink1.Left += pinkGhostX;
            pink1.Top += pinkGhostY;

            yellow1.Top += yellowGhostSpeed;
        }

        private void GameOver(string message)
        {
            gameTime.Stop();
            isGameOver = true;
            if (i == 0)
            {
                txtScore.Text += Environment.NewLine + message;
                MessageForm1 messageForm = new MessageForm1("Nivo previse tezak?Evo malo laksi ;3");
                messageForm.Owner = this;
                messageForm.ShowDialog();
                i++;
            }
            else
                this.Close();

        }

        private void Restart()
        {
            txtScore.Text = "Score: 0";
            score = 0;
            redGhostSpeed = 20;
            yellowGhostSpeed = 20;
            speed = 8;
            pinkGhostX = 20;
            pinkGhostY = 20;
            isGameOver = false;
            isGameWon = false;
            gameTime.Start();
        }
    }
}
