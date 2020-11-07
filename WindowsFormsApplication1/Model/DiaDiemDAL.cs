using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class DiaDiemDAL
    {
        ConnectDB conn = new ConnectDB();
        SqlDataAdapter da;
        SqlCommand cmd;
        //Select Tour
        public DataTable getAllDiaDiem()
        {
            string query = "select * from DiaDiem";
            //B2: Tạo kết nối đến sql 
            SqlConnection connect = conn.getConnect();
            // B3: Khởi tạo đối tượng của lớp DataAdapter 
            da = new SqlDataAdapter(query, connect);
            // Mở kết nối 
            connect.Open();
            //Đổ data từ SqlDataAdapter vào Data table
            DataTable dataTB = new DataTable();
            da.Fill(dataTB);
            // Bước 6: Đóng kết nối
            connect.Close();
            return dataTB;
        }
    }
}
