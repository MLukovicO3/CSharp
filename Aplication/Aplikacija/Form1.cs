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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Ova aplikacija nema smisla samo je skup raznih aplikacija koje su mi bile interesantne za pravljenje.Uzivajte :)<3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 forma = new Form2();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 forma = new Form3();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 forma = new Form6();
            forma.ShowDialog();
        }
    }
}
