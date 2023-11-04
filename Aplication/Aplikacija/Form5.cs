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
    public partial class Form5 : Form
    {
        private StreamReader sr;
        private List<string> list = new List<string>();
        private Racun debt;
        public Form5()
        {
            InitializeComponent();
            sr = new StreamReader("Racuni.txt");
            while (!sr.EndOfStream) {
                list.Add(sr.ReadLine());
            }
            sr.Close();
            foreach (string x in list)
                comboBox1.Items.Add(x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                MessageBox.Show("Morate izabrati racun!");
            else
            {
                sr = new StreamReader(comboBox1.SelectedItem.ToString()+".txt");
                debt = new Racun
                {
                    IME = sr.ReadLine(),
                    PREZIME = sr.ReadLine(),
                    SIFRA = sr.ReadLine(),
                    DUG = Convert.ToInt32(sr.ReadLine()),
                    DATUMPOCETAK = Convert.ToDateTime(sr.ReadLine()),
                };
                sr.Close();
                if (File.ReadLines(debt.SIFRA + ".txt").Count()>5)
                {
                    debt.DATUMUPLATE = Convert.ToDateTime(File.ReadLines(debt.SIFRA+".txt").Last());
                }
                richTextBox1.Text+= debt.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                MessageBox.Show("Morate izabrati racun!");
            if (textBox1.Text == string.Empty)
                MessageBox.Show("Morate uneti kolicinu novca!");
            else
            {
                sr = new StreamReader(comboBox1.SelectedItem.ToString() + ".txt");
                debt = new Racun
                {
                    IME = sr.ReadLine(),
                    PREZIME = sr.ReadLine(),
                    SIFRA = sr.ReadLine(),
                    DUG = Convert.ToInt32(sr.ReadLine()),
                    DATUMPOCETAK = Convert.ToDateTime(sr.ReadLine())
                };
                sr.Close();
                if (Convert.ToInt32(textBox1.Text) > debt.DUG)
                {
                    MessageBox.Show("Ne mozete uplatiti vise od duga!");
                    textBox1.Text = string.Empty;
                    textBox1.Focus();
                }
                else
                {
                    debt.Uplata(Convert.ToInt32(textBox1.Text));
                    richTextBox1.Text += debt.Show();
                    textBox1.Text = string.Empty;
                    textBox1.Focus();
                }
            }
        }
    }
}
