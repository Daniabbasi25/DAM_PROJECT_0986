using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Ticketing_System_VP
{
    public partial class AdminRout : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7I43AM4;Initial Catalog=Train Ticketing System;Integrated Security=True");

        public AdminRout()
        {
            InitializeComponent();
        }

        private void AdminRout_Load(object sender, EventArgs e)
        {
            displaydata();
            checkboxes();

        }
        public void checkboxes()
        {
            try
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select * from Train";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                TncomboBox.DataSource = dt;
                TncomboBox.DisplayMember = "name";
                TncomboBox.ValueMember = "id";
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
            try
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select * from Station";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                DataTable df = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Fill(df);
                SscomboBox.DataSource = dt;
                SscomboBox.DisplayMember = "name";
                SscomboBox.ValueMember = "id";
                EscomboBox.DataSource = df;
                EscomboBox.DisplayMember = "name";
                EscomboBox.ValueMember = "id";
                sqlcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
           
            if (ischeck())
            { 
            try
            {

                    sqlcon.Open();
                    SqlDataAdapter d = new SqlDataAdapter("Rout_insert", sqlcon);
                    d.SelectCommand.CommandType = CommandType.StoredProcedure;
                    d.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = RidtextBox.Text;
                    d.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar, (50)).Value = RnametextBox.Text;
                    d.SelectCommand.Parameters.Add("@Source", SqlDbType.VarChar, (50)).Value = SscomboBox.Text.ToString();
                    d.SelectCommand.Parameters.Add("@Destination", SqlDbType.VarChar, (50)).Value = EscomboBox.Text.ToString();
                    d.SelectCommand.Parameters.Add("@FCS", SqlDbType.Int).Value = FclasstextBox.Text;
                    d.SelectCommand.Parameters.Add("@BCS", SqlDbType.Int).Value = BctextBox.Text;
                    d.SelectCommand.Parameters.Add("@ECS", SqlDbType.Int).Value = EcsptextBox.Text;
                    d.SelectCommand.Parameters.Add("@Tname", SqlDbType.VarChar, (50)).Value = TncomboBox.Text.ToString();
                    d.SelectCommand.Parameters.Add("@date", SqlDbType.VarChar, (50)).Value = date.Value.Date.ToString();
                    d.SelectCommand.Parameters.Add("@time", SqlDbType.VarChar, (50)).Value = Time.Value.TimeOfDay.ToString();




                    d.SelectCommand.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("save Data in Database");
               
                displaydata();
                checkboxes();

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }
            else
            {
                MessageBox.Show("Starting and end will not be same");
            }
        }
        public bool ischeck()
        {
            int a = int.Parse(SscomboBox.SelectedValue.ToString());
            int b = int.Parse(EscomboBox.SelectedValue.ToString());
            if (a == b)
            {
                return false;
            }
            return true;
        }

        private void Deletbutton_Click(object sender, EventArgs e)
        {
            try
            {

                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"delete from Rout where id='" + int.Parse(RidtextBox.Text) + "' ";
                int row = cmd.ExecuteNonQuery();
                sqlcon.Close();
                if (row > 0)
                {
                    MessageBox.Show("Delete Data Successfuly");
                    checkboxes();
                    displaydata();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void displaydata()
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select * from Rout";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewrout.DataSource = dt;
            sqlcon.Close();

        }
        private void dataGridViewrout_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //get the data from data grid view and fell in text boxes respectedly 
                int rowindex = e.RowIndex;
                RidtextBox.Text = dataGridViewrout.Rows[rowindex].Cells[0].Value.ToString();
                RnametextBox.Text = dataGridViewrout.Rows[rowindex].Cells[1].Value.ToString();
                SscomboBox.SelectedText = dataGridViewrout.Rows[rowindex].Cells[2].Value.ToString();
                EscomboBox.SelectedText = dataGridViewrout.Rows[rowindex].Cells[3].Value.ToString();
                FclasstextBox.Text = dataGridViewrout.Rows[rowindex].Cells[4].Value.ToString();
                BctextBox.Text = dataGridViewrout.Rows[rowindex].Cells[5].Value.ToString();
                EcsptextBox.Text = dataGridViewrout.Rows[rowindex].Cells[9].Value.ToString();
                TncomboBox.SelectedText = dataGridViewrout.Rows[rowindex].Cells[6].Value.ToString();
                date.Text = dataGridViewrout.Rows[rowindex].Cells[7].Value.ToString();
                Time.Text = dataGridViewrout.Rows[rowindex].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (ischeck())
            { 
                try
            {

                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText ="update Rout set Name='"+RnametextBox.Text.ToString()+"',Source='"+SscomboBox.Text.ToString()+"',Destination='"+EscomboBox.Text.ToString()+"',[First Class Seet Price]='"+int.Parse(FclasstextBox.Text)+"',[Business Class Seet Price]='"+int.Parse(BctextBox.Text)+"',[Economy Class Seet Price]='"+int.Parse(Ecsp.Text)+"',[Train Name]='"+TncomboBox.Text.ToString()+"',Date='"+date.Value.Date+"',Time='"+Time.Value.TimeOfDay+"'where id='"+int.Parse(RidtextBox.Text)+"'";
                int row = cmd.ExecuteNonQuery();
                sqlcon.Close();
                if (row > 0)
                {
                    MessageBox.Show("Update Data Successfuly");
                    displaydata();
                    checkboxes();
                }
                else
                {
                    MessageBox.Show("Error");
                }


                
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Starting and end will not be same");
            }
        }

        private void dataGridViewrout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
