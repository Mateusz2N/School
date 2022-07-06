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
    public partial class Frekwencja : Form
    {
        public Frekwencja()
        {
            InitializeComponent();
            DisplayFrekwencja();
            FillUczeId();
        }
        private void FillUczeId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select UId from UczniowieTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UId", typeof(int));
            dt.Load(rdr);
            UIdCb.ValueMember = "UId";
            UIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetUczeName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from UczniowieTbl where UId=@UcId", Con);
            Cmd.Parameters.AddWithValue("@UcId", UIdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                UNameTb.Text = dr["UName"].ToString();
            }
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Mateusz\Documents\SchoolDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void DisplayFrekwencja()
        {
            Con.Open();
            string Query = "Select * from FrekwencjaTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FrekwencjaDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            FStatusCb.SelectedIndex = -1;
            UNameTb.Text = "";
            UIdCb.SelectedIndex = -1;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || FStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Błędna Informacja");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into FrekwencjaTbl(FUid,FUName,FDate,FStatus) values (@UId,@UName,@FDate,@Status)", Con);
                    cmd.Parameters.AddWithValue("@UId", UIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@UName", UNameTb.Text);
                    cmd.Parameters.AddWithValue("@FDate", FDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", FStatusCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Status Dodany");
                    Con.Close();
                    DisplayFrekwencja();
                    //Reset();
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

        private void UIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetUczeName();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int Key = 0;
        private void FrekwencjaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UIdCb.SelectedValue = FrekwencjaDGV.SelectedRows[0].Cells[1].Value.ToString();
            UNameTb.Text = FrekwencjaDGV.SelectedRows[0].Cells[2].Value.ToString();
            FDatePicker.Text = FrekwencjaDGV.SelectedRows[0].Cells[3].Value.ToString();
            FStatusCb.SelectedItem = FrekwencjaDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (UNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(FrekwencjaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || FStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz Ucznia");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update FrekwencjaTbl set FUid=@UId,FUName=@UName,FDate=@FrDate,FStatus=@FrStatus where FNum=@FrNum", Con);
                    cmd.Parameters.AddWithValue("@UId", UIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@UName", UNameTb.Text);
                    cmd.Parameters.AddWithValue("@FrDate", FDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@FrStatus", FStatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FrNum", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Status Edytowany");
                    Con.Close();
                    DisplayFrekwencja();
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
