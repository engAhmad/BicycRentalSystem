using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace BicycRentalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // Connection.GetConnection();
           UsersDataGridView.DataSource = GetUsers();
        }
        // this method to get users from the database
        private DataTable GetUsers()
        {
            DataTable dtUsers = new DataTable();
            // fix the column name
            string conString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM users", con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtUsers.Load(reader);
                }
            }
            return dtUsers;
        }
    }
}
