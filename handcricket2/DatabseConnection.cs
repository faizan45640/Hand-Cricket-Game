using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace handcricket2
{
    internal class DatabseConnection
    {
        public static SqlConnection GetConnection()

        {
            string connectionString = "Data Source=desktop-mdfvllc\\sqlexpress;Initial Catalog=handcricket;Integrated Security=True;Encrypt=False;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
