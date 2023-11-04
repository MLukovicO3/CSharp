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
    public partial class MessageForm1 : Form
    {
        Form8 form = new Form8();
        public MessageForm1(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
            form.Focus();
        }
    }
}
