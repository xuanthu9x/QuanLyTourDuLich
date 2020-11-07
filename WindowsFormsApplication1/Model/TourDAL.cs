using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Model
{
    class TourDAL
    {

        ConnectDB conn = new ConnectDB();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        //Select Tour
        public DataTable getAllTour()
        {
            //string query = "select t.MaTour, t.TenTour, g.ThoiGianBD, g.ThoiGianKT, g.Gia from Tour as t join GiaTour as g on t.MaTour = g.MaTour where g.ThoiGianKT > '2020-09-30'";
            string query = "select * from Tour";
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
        public DataTable LoadLoaiTour()
        {
            string query = "Select * from LoaiTour";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter da1 = new SqlDataAdapter(query, connect);
            DataTable tb = new DataTable();
            da1.Fill(tb);
            connect.Close();
            return tb;
        }
        //
        public DataTable GetMaTour()
        {
            string query = "Select top 1 MaTour from Tour order by MaTour desc";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter da2 = new SqlDataAdapter(query, connect);
            DataTable tb = new DataTable();
            da2.Fill(tb);
            connect.Close();
            return tb;
        }
        //get danh sách mã tour
        public DataTable GetDsMaTour()
        {
            string query = "select MaTour from Tour";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter da4 = new SqlDataAdapter(query, connect);
            DataTable tb = new DataTable();
            da4.Fill(tb);
            connect.Close();
            return tb;
        }
        //load ngày bắt đầu hợp lệ để edit bảng giá
       
        public DataTable GetTGBD(int maTour)
        {
            string query = "select  DATEADD(minute,1,ThoiGianKT) as ThoiGianBatDau from GiaTour where MaTour="+maTour
                +" and ThoiGianKT =(select top 1 ThoiGianKT from GiaTour where MaTour="+maTour+" order by Id desc) ";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daTGBD = new SqlDataAdapter(query, connect);
            DataTable tbTGBD = new DataTable();
            daTGBD.Fill(tbTGBD);
            connect.Close();
            return tbTGBD;
        }  
        // Insert Tour
        public bool insertTour(Tour t)
        {
            string query = "insert into Tour (MaLoaiTour, TenTour) values(@MaLoaiTour, @TenTour)";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@MaLoaiTour", SqlDbType.Int).Value = t.MaLoaiTour;
                cmd.Parameters.Add("@TenTour", SqlDbType.NVarChar).Value = t.TenTour;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        // Update Tour 
        public bool UpdateTour(Tour t)
        {
            string query = "Update Tour set MaLoaiTour = @MaLoaiTour, TenTour=@TenTour where MaTour=@MaTour";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@MaLoaiTour", SqlDbType.Int).Value = t.MaLoaiTour;
                cmd.Parameters.Add("@TenTour", SqlDbType.NVarChar).Value = t.TenTour;
                cmd.Parameters.Add("@MaTour", SqlDbType.Int).Value = t.MaTour;
                cmd.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        // Delete Tour 
        public bool DeleteTour(int matour)
        {
            string query = "Delete Tour where MaTour=@MaTour";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@MaTour", SqlDbType.Int).Value = matour;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // Delete Tour 
        public bool DeleteCTTour(int matour)
        {
            string query = "Delete ChiTietTour where MaTour=@MaTour";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@MaTour", SqlDbType.Int).Value = matour;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        //Insert Chi Tiet Tour
        public bool insertCTTour(Tour t)
        {
            string query = "insert into ChiTietTour (MaTour, MaDiaDiem, ThuTu) values(@MaTour, @MaDiaDiem,@ThuTu)";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@MaTour", SqlDbType.Int).Value = t.MaTour;
                cmd.Parameters.Add("@MaDiaDiem", SqlDbType.NVarChar).Value = t.MaDiaDiem;
                cmd.Parameters.Add("@ThuTu", SqlDbType.Int).Value = t.thutu;
                cmd.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable GetCTTour(int matour)
        {
            // string query = "Select top 1 MaTour from Tour order by MaTour desc";
            string query = "select dd.Id as MaDiaDiem, dd.DiaDiem, ctt.ThuTu from ChiTietTour as ctt join DiaDiem as dd on ctt.MaDiaDiem = dd.Id where ctt.MaTour = "+ matour;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter da3 = new SqlDataAdapter(query, connect);
            DataTable tb = new DataTable();
            da3.Fill(tb);
            connect.Close();
            return tb;
        }
        public DataTable getInfoLoaiTour(int maTour)
        {
            string query = "select lt.* from LoaiTour as lt join Tour as t on lt.Id=t.MaLoaiTour where t.MaTour = " + maTour;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daInfoTour = new SqlDataAdapter(query, connect);
            DataTable tbInfoTour = new DataTable();
            daInfoTour.Fill(tbInfoTour);
            connect.Close();
            return tbInfoTour;
        }
      
    }
}
