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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 forma = new Form4();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 forma = new Form5();
            forma.ShowDialog();
        }
    }
}
