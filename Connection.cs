using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace BicycRentalSystem
{
    internal class Connection
    {
        public static void GetConnection()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\source\repos\BicycRentalSystem\BicycleRentalSystem.accdb;Persist Security Info=False;";
            try
            {
                connection.Open();
                // MessageBox.Show("تم الاتصال بالقاعدة بنجاح", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
