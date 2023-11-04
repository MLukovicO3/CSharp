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
    public partial class Form6 : Form
    {
        private bool up, down, right, left,isGameOver,isGameWon;
        private int score;
        private int speed;
        private int redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY;

        private void gameTimeEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
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

            if (pacman.Left < -10)
                pacman.Left = 680;
            if (pacman.Left > 680)
                pacman.Left = -10;
            if (pacman.Top < -10)
                pacman.Top = 550;
            if (pacman.Top > 550)
                pacman.Top = -10;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if ((string)x.Tag == "coin"&&x.Visible)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 10;
                            x.Visible = false;
                        }
                    }
                   if((string)x.Tag=="wall"||(string)x.Tag=="ghost")
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameOver("You lost!");
                        }
                }
            }

            red.Left += redGhostSpeed;
            if (red.Bounds.IntersectsWith(pictureBox1.Bounds) || red.Bounds.IntersectsWith(pictureBox2.Bounds))
                redGhostSpeed = -redGhostSpeed;

            yellow.Left += yellowGhostSpeed;
            if (yellow.Bounds.IntersectsWith(pictureBox3.Bounds) || yellow.Bounds.IntersectsWith(pictureBox4.Bounds))
                yellowGhostSpeed = -yellowGhostSpeed;

            pink.Left -= pinkGhostX;
            pink.Top -= pinkGhostY;
            if (pink.Left < 0 || pink.Left > 620)
                pinkGhostX = -pinkGhostX;
            if (pink.Top < 0 || pink.Top > 500)
                pinkGhostY = -pinkGhostY;

            if (score == 370)
                isGameWon = true;
            if (isGameWon)
            {
                GameOver("You win!");
            }
                
        }

        public Form6()
        {
            InitializeComponent();
            Restart();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
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

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                up = false;
            if (e.KeyCode == Keys.Down)
                down = false;
            if (e.KeyCode == Keys.Left)
                left = false;
            if (e.KeyCode == Keys.Right)
                right = false;
            if (e.KeyCode == Keys.Enter && isGameOver)
                Restart();
        }

        private void Restart()
        {
            txtScore.Text = "Score: 0";
            score = 0;
            redGhostSpeed = 5;
            yellowGhostSpeed = 5;
            speed = 8;
            pinkGhostX = 5;
            pinkGhostY = 5;
            isGameOver = false;
            isGameWon = false;

            pacman.Left = 40;
            pacman.Top = 99;

            red.Left = 300;
            red.Top = 54;

            yellow.Left = 374;
            yellow.Top = 413;

            pink.Left = 573;
            pink.Top = 113;

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "coin")
                    x.Visible = true;
            }

            gameTime.Start();
        }
        private void GameOver(string message) 
        {
            gameTime.Stop();
            txtScore.Text += Environment.NewLine + message;
            if (isGameWon==false)
                isGameOver = true;
            else
            {
                this.Close();
                MessageForm messageForm = new MessageForm("Lak nivo?Sledeci je malo tezi :3");
                messageForm.Owner = this;
                messageForm.ShowDialog();
            }
            
        }
    }
}
