using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class GiaDAL
    {
        ConnectDB conn = new ConnectDB();
        SqlDataAdapter da;
        SqlCommand cmd;
        public bool insertGia(Gia g)
        {
            string query = " insert into GiaTour(MaTour, ThoiGianBD, ThoiGianKT, Gia) values(@MaTour, @TGBD,@TGKT,@Gia)";
            //insert into GiaTour(MaTour, ThoiGianBD, ThoiGianKT, Gia) values(30, '2020-10-05', '2020-10-07', 1500000)
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@MaTour", SqlDbType.Int).Value = g.MaTour;
                cmd.Parameters.Add("@TGBD", SqlDbType.DateTime).Value = g.tgbd;
                cmd.Parameters.Add("@TGKT", SqlDbType.DateTime).Value = g.tgkt;
                cmd.Parameters.Add("@Gia", SqlDbType.Float).Value = g.gia;
                cmd.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        //get gia của tour
        public DataTable GetGiaour(int matour)
        {
            // string query = "Select top 1 MaTour from Tour order by MaTour desc";
            string query = "select g.MaTour, g.ThoiGianBD, g.ThoiGianKT, g.Gia from GiaTour as g where g.MaTour = "+ matour;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter da1 = new SqlDataAdapter(query, connect);
            DataTable tb = new DataTable();
            da1.Fill(tb);
            connect.Close();
            return tb;
        }
        public bool DeleteGiaTour(int matour)
        {           
            string query = "delete from GiaTour where MaTour = " + matour;
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();               
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
