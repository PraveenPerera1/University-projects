using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahead_Life
{
    internal class config
    {
        public SqlConnection con;
        public string str;
        public config()
        {
            str = @"Data
Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\PRAVEEN\DESKTOP\AHEAD LIFE APP\AHEAD LIFE\AHEAD LIFE\DATABASE1.MDF;Integrated
Security=True";

            try
            {
                con = new SqlConnection(str);
                con.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}
