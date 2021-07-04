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
    public partial class BookTIcket : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7I43AM4;Initial Catalog=Train Ticketing System;Integrated Security=True");

        public BookTIcket()
        {
            InitializeComponent();
        }

        private void BookTIcket_Load(object sender, EventArgs e)
        {
            combo();
        }
        public void combo()
        {
            try
            {
                string s = UserDashbord.sou;
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select * from Rout where Source='" + s+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DestinationcomboBox.DataSource = dt;
                DestinationcomboBox.DisplayMember = "Destination";
                DestinationcomboBox.ValueMember = "id";
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            if (FclasstextBox.Text != "0" || BctextBox.Text != "0" || EcsptextBox.Text != "0")
            {
                try
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"insert into Passenger (IDCard,name,Destination,FCSeets,BCSeets,ECSeets) values('" + idtextBox.Text.ToString() + "','" + pnametextBox.Text.ToString() + "','" + DestinationcomboBox.Text.ToString() + "','" + int.Parse(FclasstextBox.Text) + "','" + int.Parse(BctextBox.Text) + "','" + int.Parse(EcsptextBox.Text) + "')";
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("save Data in Database");
                    Passenger p = new Passenger();
                    p.Show();
                    this.Hide();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Atleast Enter 1 seet");
            }

          
        }
    }
}
