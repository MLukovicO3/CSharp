using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
//using System.Windows.Forms.DataVisualization.Charting;

namespace _13.DVD_kolekcija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        SqlConnection konekcija;
        SqlCommand komanda;
        DataTable dt;
        SqlDataAdapter da;
        void Konekcija()
        {
            konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source = DESKTOP-0L8DTR2\SQLEXPRESS01; Initial Catalog = DVD; Integrated Security = True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            dt = new DataTable();
            da = new SqlDataAdapter();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = dt.Rows[listBox1.SelectedIndex][0].ToString();
            textBox2.Text = dt.Rows[listBox1.SelectedIndex][1].ToString();
            textBox3.Text = dt.Rows[listBox1.SelectedIndex][2].ToString();

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 forma3 = new Form3();
            forma3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Konekcija();
            listBox1.Items.Clear();
            ArrayList lista = new ArrayList();                       
            komanda.CommandText = "SELECT ProducentID, Ime, Email FROM producent ORDER BY ProducentID asc";
            da.SelectCommand = komanda;
            da.Fill(dt);
            int i;
           // string format = "{0,-10}{1,-50}{0,30}";
            textBox1.Text=dt.Rows[0][0].ToString();
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
            for (i = 0; i < dt.Rows.Count; i++)
            {
                string producent= dt.Rows[i][0].ToString();
                string ime = dt.Rows[i][1].ToString();
                string email = dt.Rows[i][2].ToString();            
               // listBox1.Items.Add(String.Format( format,dt.Rows[i][0],dt.Rows[i][1],dt.Rows[i][2]));
                listBox1.Items.Add(producent.PadLeft(5 - producent.Length) + "\t" + ime.PadRight(45 - ime.Length) + "\t\t" + email.PadRight(30 - email.Length));
            }         
        }

      //UPDATE
        private void button1_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "UPDATE Producent SET ime=@ime,email=@email WHERE producentID=@producentID";
            komanda.Parameters.AddWithValue("@ime", textBox2.Text);
            komanda.Parameters.AddWithValue("@email", textBox3.Text);
            komanda.Parameters.AddWithValue("@producentID", textBox1.Text);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                MessageBox.Show("Uspesna izmena");
            }
            catch
            {
                MessageBox.Show("Greska");
            }
            finally
            {
                konekcija.Close();
            }
            Form1_Load(sender, e);
        }
    }
}
