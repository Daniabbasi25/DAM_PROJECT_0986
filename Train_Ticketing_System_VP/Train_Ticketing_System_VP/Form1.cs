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

namespace Train_Ticketing_System_VP
{
    public partial class Loginform : Form
    {
        public static string nametext = "";
        public static string stationtxt = "";
        public Loginform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (AdmincheckBox.Checked) {
                try {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7I43AM4;Initial Catalog=Train Ticketing System;Integrated Security=True");
                    string query = "select * from AdminLogin where username='" + idtextbox.Text.Trim() + "' and password='" + Passwordtextbox.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                
            if (dtbl.Rows.Count == 1)
                {
                    AdminDashbord adminform = new AdminDashbord();
                    this.Hide();
                    adminform.Show();
                }
                else
                {
                    MessageBox.Show("Invalid userName or password");
                }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Data.ToString());
                }
            }
            else
            {
                try { 
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7I43AM4;Initial Catalog=Train Ticketing System;Integrated Security=True");
                string query = "select * from UserLogin where username='" + idtextbox.Text.Trim() + "' and password='" + Passwordtextbox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                        nametext = idtextbox.Text.ToString();
                        stationtxt = dtbl.Rows[0]["Station"].ToString();
                    UserDashbord userform = new UserDashbord();
                    this.Hide();
                     
                     userform.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid userName or password");
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Data.ToString());
                }
            }
        }
    }
}
