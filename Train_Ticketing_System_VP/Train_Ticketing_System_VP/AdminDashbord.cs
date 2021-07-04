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
    public partial class AdminDashbord : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7I43AM4;Initial Catalog=Train Ticketing System;Integrated Security=True");

        public AdminDashbord()
        {
            InitializeComponent();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void PassengerSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminTrain admintrain = new AdminTrain();
           
            admintrain.Show();
        }

        private void routToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminRout adminRout = new AdminRout();

            adminRout.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserADD user = new UserADD();

            user.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminRout r = new AdminRout();
            AdminTrain t = new AdminTrain();
            UserADD u = new UserADD();
            Station s = new Station();
            r.Hide();
            t.Hide();
            u.Hide();
            Loginform login = new Loginform();
            login.Show();
            this.Hide();
           
        }

        private void stationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Station st = new Station();
            st.Show();
        }

        private void AdminDashbord_Load(object sender, EventArgs e)
        {
            displaydata();
        }
        public void displaydata()
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select * from Rout order by Date desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            nextTrainDataGrid.DataSource = dt;
            sqlcon.Close();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            displaydata();
        }
    }
}
