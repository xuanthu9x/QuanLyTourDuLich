using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class ConnectDB
    {
        string conn;
        public ConnectDB()
        {
            conn = "Data Source = DESKTOP-MA3I4S3\\SQLEXPRESS; Initial Catalog= TourDuLich; Integrated Security=true";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conn);
        }
    }
}
