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
    public partial class AdminTrain : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7I43AM4;Initial Catalog=Train Ticketing System;Integrated Security=True");
        public AdminTrain()
        {
            InitializeComponent();
        }

        private void AdminTrain_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
           
            try
            {
                sqlcon.Open();
                SqlDataAdapter d = new SqlDataAdapter("Train_insert", sqlcon);
                d.SelectCommand.CommandType = CommandType.StoredProcedure;
                d.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = TidtextBox.Text;
                d.SelectCommand.Parameters.Add("@name", SqlDbType.VarChar, (50)).Value = tnametextBox.Text;
                d.SelectCommand.Parameters.Add("@fcseets", SqlDbType.VarChar, (50)).Value = TfctextBox.Text;
                d.SelectCommand.Parameters.Add("@bcseets", SqlDbType.VarChar, (50)).Value = TbctextBox.Text;
                d.SelectCommand.Parameters.Add("@ecSeets", SqlDbType.VarChar, (50)).Value = TectextBox.Text;

                d.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("save Data in Database");                
                displaydata();
              
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
            cmd.CommandText = @"select * from Train";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           

            sqlcon.Close();

        }

        private void Deletbutton_Click(object sender, EventArgs e)
        {
            try
            {

                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"delete from Train where id='" +int.Parse( TidtextBox.Text) + "' ";

                int row =   cmd.ExecuteNonQuery();
                sqlcon.Close();
                if (row > 0)
                {
                    MessageBox.Show("Delete Data Successfuly");
                }
                else
                {
                    MessageBox.Show("Error");
                }
               
                displaydata();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {

                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"update  Train set name='" + tnametextBox.Text.ToString() + "',fcseets='" + int.Parse(TfctextBox.Text) + "',bcseets='" + int.Parse(TbctextBox.Text) + "',ecSeets= '" + int.Parse(TectextBox.Text) + "'where id='" + int.Parse(TidtextBox.Text) + "' ";

                int row = cmd.ExecuteNonQuery();
                sqlcon.Close();
                if (row > 0)
                {
                    MessageBox.Show("Update Data Successfuly");
                }
                else
                {
                    MessageBox.Show("Error");
                }

                displaydata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try { 
            //get the data from data grid view and fell in text boxes respectedly 
            int rowindex = e.RowIndex;
            TidtextBox.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            tnametextBox.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            TfctextBox.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            TbctextBox.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            TectextBox.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
