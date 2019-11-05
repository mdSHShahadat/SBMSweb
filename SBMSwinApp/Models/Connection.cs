using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Models
{
    public class Connection
    {
        SqlConnection con;
        public SqlConnection GetConnection()
        {
            string conStr = ConfigurationManager.ConnectionStrings["StockManagementConnectionString"].ToString();
            con = new SqlConnection(conStr);
            con.Open();
            return con;
        }
        public void GetClose()
        {
            if (con != null)
                con.Close();
        }
    }
}
