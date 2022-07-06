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

namespace SchoolOffice
{
    public partial class Podsumowanie : Form
    {
        public Podsumowanie()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Mateusz\Documents\SchoolDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
        private void CountUczniowie()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from UczniowieTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ULbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountNauczyciele()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from NauczycieleTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            NLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountWydarzenia()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from WydarzeniaTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            WLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void Podsumowanie_Load(object sender, EventArgs e)
        {
            CountUczniowie();
            CountNauczyciele();
            CountWydarzenia();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
