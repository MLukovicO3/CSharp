using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace _13.DVD_kolekcija
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection konekcija;
        SqlCommand komanda;
        DataTable dt;       
        SqlDataAdapter da;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //PRIKAZI
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Producent"].IsValueShownAsLabel = true;
            Random r = new Random();
            ArrayList producent = new ArrayList();
            ArrayList broj_filmova = new ArrayList();
            chart1.Series["Producent"].Points.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                producent.Add(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
                broj_filmova.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
                chart1.Series["jhjh"].Points.AddXY(producent[i], broj_filmova[i]);
                chart1.Series["Producent"].Points[i].Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                //chart1.Series[i] = producent[i].ToString();
                //producent[i]
                //chart1.Series["Producent"].Points[i].LegendText= producent[i].ToString();
                chart1.Series["Producent"].XValueMember = producent[i].ToString();
            }
        }

        void Konekcija()
        {
            konekcija = new SqlConnection();
            //konekcija.ConnectionString = @"Data Source=DESKTOP-1EH3FVI\SQLEXPRESS; Initial Catalog = DVD kolekcija; Integrated Security = True;";
            konekcija.ConnectionString = @"Data Source = KABINET10\SQLEXPRESS; Initial Catalog = DVD kolekcija; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            komanda = new SqlCommand();
           // komanda = new SqlCommand();
            komanda.Connection = konekcija;
            dt = new DataTable();
            da = new SqlDataAdapter();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Konekcija();
        
            string select = "SELECT  producent.Ime,COUNT(filmID)";
            string from = "FROM producent INNER JOIN producirao ON producirao.producentID = producent.producentID";
            string group = "GROUP BY producent.Ime";
            komanda.CommandText = select + " " + from+" " + group;
            da.SelectCommand = komanda;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "PRODUCENT";
            dataGridView1.Columns[1].HeaderText = "BROJ FILMOVA";
            dataGridView1.Columns[0].Width = 3*(dataGridView1.Width-dataGridView1.RowHeadersWidth) / 4;
            dataGridView1.Columns[1].Width = (dataGridView1.Width - dataGridView1.RowHeadersWidth) / 4;
        }
    }
}
