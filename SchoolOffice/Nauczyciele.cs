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
    public partial class Nauczyciele : Form
    {
        public Nauczyciele()
        {
            InitializeComponent();
            DisplayNauczyciele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Mateusz\Documents\SchoolDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void DisplayNauczyciele()
        {
            Con.Open();
            string Query = "Select * from NauczycieleTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            NauczycieleDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            NnameTb.Text = "";
            SubCb.SelectedIndex = 0;
            NPlecCb.SelectedIndex = 0;
            NphoneTb.Text = "";
            NaddTb.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NnameTb.Text == "" || NphoneTb.Text == "" || NaddTb.Text == "" || NPlecCb.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Błędna Informacja");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into NauczycieleTbl(Nname,NPlec,NPhone,NSub,NAdd,NData) values (@Nname,@NPlec,@NPhone, @NSub, @NAdd,@NData)", Con);
                    cmd.Parameters.AddWithValue("@Nname", NnameTb.Text);
                    cmd.Parameters.AddWithValue("@NPlec", NPlecCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@NPhone", NphoneTb.Text);
                    cmd.Parameters.AddWithValue("@NSub", SubCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@NAdd", NaddTb.Text);
                    cmd.Parameters.AddWithValue("@NData", Ndata.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nauczyciel Dodany");
                    Con.Close();
                    DisplayNauczyciele();
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
        int Key = 0;
        private void NauczycieleDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NnameTb.Text = NauczycieleDGV.SelectedRows[0].Cells[1].Value.ToString();
            NPlecCb.SelectedItem = NauczycieleDGV.SelectedRows[0].Cells[2].Value.ToString();
            NphoneTb.Text = NauczycieleDGV.SelectedRows[0].Cells[3].Value.ToString();
            SubCb.SelectedItem = NauczycieleDGV.SelectedRows[0].Cells[4].Value.ToString();
            NaddTb.Text = NauczycieleDGV.SelectedRows[0].Cells[5].Value.ToString();
            Ndata.Text = NauczycieleDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (NnameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(NauczycieleDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Wybierz Nauczyciela");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from nauczycieleTbl where NId = @NKey", Con);
                    cmd.Parameters.AddWithValue("@Nkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nauczyciel Usunięty");
                    Con.Close();
                    DisplayNauczyciele();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NnameTb.Text == "" || NphoneTb.Text == "" || NaddTb.Text == "" || NPlecCb.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz Nauczyciela");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update NauczycieleTbl set NName=@Nname,NPlec=@NPlec,NPhone=@NPhone,NSub=@NSub,NAdd=@NAdd,Ndata=@NData where NId=@NauczycielId", Con);
                    cmd.Parameters.AddWithValue("@Nname", NnameTb.Text);
                    cmd.Parameters.AddWithValue("@NPlec", NPlecCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@NPhone", NphoneTb.Text);
                    cmd.Parameters.AddWithValue("@NSub", SubCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@NAdd", NaddTb.Text);
                    cmd.Parameters.AddWithValue("@NData", Ndata.Value.Date);
                    cmd.Parameters.AddWithValue("@NauczycielId", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nauczyciel Edytowany");
                    Con.Close();
                    DisplayNauczyciele();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
