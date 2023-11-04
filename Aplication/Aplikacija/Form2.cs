using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
namespace Aplikacija
{
    public partial class Form2 : Form
    {
        private List<Krug> snake = new List<Krug>();
        private Krug hrana=new Krug();
        int maxW, maxH;
        int score, highScore;
        StreamWriter sw = new StreamWriter("HighScore.txt",true);
        Random rand = new Random();
        bool left, right, down, up;
        public Form2()
        {
            InitializeComponent();
            new Podesavanja();
            sw.Close();
            score = 0;
            highScore = Convert.ToInt32(File.ReadLines("HighScore.txt").Last());
            label2.Text = "HighScore: " + highScore; 
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Podesavanja.directions != "right")
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right && Podesavanja.directions != "left")
            {
                right = true;
            }
            if (e.KeyCode == Keys.Down && Podesavanja.directions != "up")
            {
                down = true;
            }
            if (e.KeyCode == Keys.Up && Podesavanja.directions != "down")
            {
                up = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Label cap = new Label();
            cap.Text = "Osovojio sam: " + score +" a Highscore je: " + highScore + " u Snake igrici!<3";
            cap.Font = new Font("Ariel", 12, FontStyle.Bold);
            cap.ForeColor = Color.Black;
            cap.AutoSize = false;
            cap.Width = pictureBox1.Width;
            cap.Height = 30;
            cap.TextAlign = ContentAlignment.MiddleCenter;
            pictureBox1.Controls.Add(cap);
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "MojSnap";
            save.DefaultExt = "jpg";
            save.Filter = "JPG Image File | *.jpg";
            save.ValidateNames = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                bmp.Save(save.FileName, ImageFormat.Jpeg);
                pictureBox1.Controls.Remove(cap);
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (left)
            {
                Podesavanja.directions = "left";
            }
            if (right)
            {
                Podesavanja.directions = "right";
            }
            if (up)
            {
                Podesavanja.directions = "up";
            }
            if (down)
            {
                Podesavanja.directions = "down";
            }
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Podesavanja.directions)
                    {
                        case "left":
                            snake[i].X--;
                            break;
                        case "right":
                            snake[i].X++;
                            break;
                        case "down":
                            snake[i].Y++;
                            break;
                        case "up":
                            snake[i].Y--;
                            break;
                    }
                    if (snake[i].X < 0)
                        snake[i].X = maxW;
                    if (snake[i].X > maxW)
                        snake[i].X = 0;
                    if (snake[i].Y < 0)
                        snake[i].Y = maxH;
                    if (snake[i].Y > maxH)
                        snake[i].Y = 0;

                    if(snake[i].X==hrana.X && snake[i].Y == hrana.Y)
                    {
                        Eat();
                    }
                    for(int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)
                            GameOver();
                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
                pictureBox1.Invalidate();
            }
        }
        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics platno = e.Graphics;
            Brush brush1;
            for (int i = 0; i < snake.Count; i++)
            {
                if (i == 0)
                {
                    brush1 = Brushes.Black;
                }
                else brush1 = Brushes.DarkGreen;
                platno.FillEllipse(brush1, new Rectangle(snake[i].X * Podesavanja.W, snake[i].Y * Podesavanja.H, Podesavanja.W, Podesavanja.H));
            }
            brush1 = Brushes.Red;
            platno.FillEllipse(brush1, new Rectangle(hrana.X * Podesavanja.W, hrana.Y * Podesavanja.H, Podesavanja.W, Podesavanja.H));
        }

        private void Restart()
        {
            maxW = pictureBox1.Width / Podesavanja.W - 1;
            maxH = pictureBox1.Height / Podesavanja.H - 1;
            snake.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
            score = 0;
            label1.Text = "Score: " + score;
            Krug head = new Krug
            {
                X = 10,
                Y = 6
            };
            snake.Add(head);
            for (int i = 0; i < 10; i++)
            {
                snake.Add(new Krug());
            }
            hrana = new Krug { X = rand.Next(2, maxW), Y = rand.Next(2, maxH) };
            timer1.Start();
        }

        private void Eat()
        {
            score += 10;
            label1.Text = "Score " + score;
            snake.Add(new Krug
            {
                X = snake[snake.Count - 1].X,
                Y = snake[snake.Count - 1].Y
            });
            hrana = new Krug { X = rand.Next(2, maxW), Y = rand.Next(2, maxH) };
        }

        private void GameOver()
        {
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = true;
            if (score > highScore)
            {
                sw = new StreamWriter("HighScore.txt", true);
                sw.WriteLine(score);
                sw.Close();
                highScore = Convert.ToInt32(File.ReadLines("HighScore.txt").Last());
                label2.Text = "HighScore: " + highScore;
            }
            MessageBox.Show("Izgubili ste!Game over :c");
        }
    }
}
