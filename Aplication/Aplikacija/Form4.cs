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

namespace Aplikacija
{
    public partial class Form4 : Form
    {
        private StreamWriter sw;
        private Racun debt;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty)
            {
                debt = new Racun
                {
                    IME = textBox1.Text,
                    PREZIME = textBox2.Text,
                    SIFRA = textBox3.Text,
                    DUG = Convert.ToInt32(textBox4.Text),
                    DATUMPOCETAK = dateTimePicker1.Value
                };
                List<string> lines = new List<string>();
                lines.Add(debt.IME);
                lines.Add(debt.PREZIME);
                lines.Add(debt.SIFRA);
                lines.Add(debt.DUG.ToString());
                lines.Add(debt.DATUMPOCETAK.ToString());
                sw = new StreamWriter(debt.SIFRA + ".txt", true);
                sw.Close();
                File.WriteAllLines(debt.SIFRA + ".txt", lines);
                sw = new StreamWriter("Racuni.txt", true);
                sw.WriteLine(debt.SIFRA);
                sw.Close();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
                textBox1.Focus();
            }
            else MessageBox.Show("Sva polja moraju biti uneta!");
        }
    }
}
