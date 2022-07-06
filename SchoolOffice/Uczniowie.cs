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
    public partial class Uczniowie : Form
    {

        public Uczniowie()
        {
            InitializeComponent();
            DisplayStudent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Mateusz\Documents\SchoolDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from UczniowieTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UczniowieDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text == "" || AdresTb.Text == "" || UPlecTb.SelectedIndex == -1 || KlasaCb.SelectedIndex == -1)
            {
                MessageBox.Show("Błędna Informacja");
            }else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UczniowieTbl(UName,UPlec,UData,UKlasa,UDodaj) values (@Uname,@UPlec,@UData, @UKlasa, @UDodaj)", Con);
                    cmd.Parameters.AddWithValue("@Uname", UNameTb.Text);
                    cmd.Parameters.AddWithValue("@UPlec", UPlecTb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UData", DataPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@UKlasa", KlasaCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UDodaj", AdresTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uczeń Dodany");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                 
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            Key = 0;
            UNameTb.Text = "";
            AdresTb.Text = "";
            UPlecTb.SelectedIndex = 0;
            KlasaCb.SelectedIndex = 0;
        }
        int Key = 0;
        private void UczniowieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UNameTb.Text = UczniowieDGV.SelectedRows[0].Cells[1].Value.ToString();
            UPlecTb.SelectedItem = UczniowieDGV.SelectedRows[0].Cells[2].Value.ToString();
            DataPicker.Text = UczniowieDGV.SelectedRows[0].Cells[3].Value.ToString();
            KlasaCb.SelectedItem = UczniowieDGV.SelectedRows[0].Cells[4].Value.ToString();
            AdresTb.Text = UczniowieDGV.SelectedRows[0].Cells[5].Value.ToString();
            if(UNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                
                Key = Convert.ToInt32(UczniowieDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(Key == 0)
            {
                MessageBox.Show("Wybierz Ucznia");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from uczniowieTbl where Uid = @UKey", Con);
                    cmd.Parameters.AddWithValue("@Ukey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uczeń Usunięty");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
                
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || AdresTb.Text == "" || UPlecTb.SelectedIndex == -1 || KlasaCb.SelectedIndex == -1)
            {
                MessageBox.Show("Błędna Informacja");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update UczniowieTbl set UName=@Uname,UPlec=@UPlec,UData=@Udata,UKlasa=@UKlasa,UDodaj=@UDodaj where UId=@UcId",Con);
                    cmd.Parameters.AddWithValue("@Uname", UNameTb.Text);
                    cmd.Parameters.AddWithValue("@UPlec", UPlecTb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UData", DataPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@UKlasa", KlasaCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UDodaj", AdresTb.Text);
                    cmd.Parameters.AddWithValue("@UcId", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uczeń Edytowany");
                    Con.Close();
                    DisplayStudent();
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
