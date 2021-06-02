using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SoftwareProject
{
    public class SQL
    {
        public SqlConnection Sql()
        {
            SqlConnection connection = new SqlConnection("Data Source=TARDIS;Integrated Security=SSPI;Initial Catalog=YazılımProje");
            connection.Open();
            return connection;
        }
    }
}
