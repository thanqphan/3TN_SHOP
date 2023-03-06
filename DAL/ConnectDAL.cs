using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectDAL
    {
        public SqlConnection connect = new SqlConnection(@"Data Source=MrTHAWNG;Initial Catalog=3TN_Shop;Integrated Security=True");

    }
}
