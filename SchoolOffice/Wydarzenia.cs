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
    public partial class Wydarzenia : Form
    {
        public Wydarzenia()
        {
            InitializeComponent();
            DisplayWydarzenia();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Mateusz\Documents\SchoolDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void DisplayWydarzenia()
        {
            Con.Open();
            string Query = "Select * from WydarzeniaTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            WydarzeniaDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            WDurationTb.Text = "";
            WDescTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (WDescTb.Text == "" || WDurationTb.Text == "")
            {
                MessageBox.Show("Błędna Informacja");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into WydarzeniaTbl(WDesc,WDate,WDuration) values (@WyDesc,@WyDate,@WyDuration)", Con);
                    cmd.Parameters.AddWithValue("@WyDesc", WDescTb.Text);
                    cmd.Parameters.AddWithValue("@WyDate", WDate.Value.Date);
                    cmd.Parameters.AddWithValue("@WyDuration", WDurationTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Wydarzenie Dodane");
                    Con.Close();
                    DisplayWydarzenia();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Wybierz Wydarzenie");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from wydarzeniaTbl where Wid = @WKey", Con);
                    cmd.Parameters.AddWithValue("@Wkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Wydarzenie Usunięte");
                    Con.Close();
                    DisplayWydarzenia();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }
        int Key = 0;
        private void WydarzeniaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            WDescTb.Text = WydarzeniaDGV.SelectedRows[0].Cells[1].Value.ToString();
            WDate.Text = WydarzeniaDGV.SelectedRows[0].Cells[2].Value.ToString();
            WDurationTb.Text = WydarzeniaDGV.SelectedRows[0].Cells[3].Value.ToString();
    
            if (WDescTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(WydarzeniaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (WDescTb.Text == "" || WDurationTb.Text == "")
            {
                MessageBox.Show("Wybierz Wydarzenie");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update WydarzeniaTbl set WDesc=@WyDesc,WDate=@WyDate,WDuration=@WyDuration where WId=@WyId", Con);
                    cmd.Parameters.AddWithValue("@WyDesc", WDescTb.Text);
                    cmd.Parameters.AddWithValue("@WyDate", WDate.Value.Date);
                    cmd.Parameters.AddWithValue("@WyDuration", WDurationTb.Text);
                    cmd.Parameters.AddWithValue("@WyId", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Wydarzenie Edytowane");
                    Con.Close();
                    DisplayWydarzenia();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
