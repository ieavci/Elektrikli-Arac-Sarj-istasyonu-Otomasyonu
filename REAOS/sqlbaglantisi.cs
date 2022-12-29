using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace REAOS
{
    class sqlbaglantisi
    {
        public SqlConnection connection()
        {

            SqlConnection conn = new SqlConnection("Data Source=ISMAILAVCI\\SQLEXPRESS;Initial Catalog=REAOS;Integrated Security=True");
            conn.Open();
            return conn;

        }
    }
}
