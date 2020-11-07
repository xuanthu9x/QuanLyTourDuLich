using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Object;

namespace WindowsFormsApplication1.Model
{
    class DoanDAL
    {
        ConnectDB conn = new ConnectDB();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        // lấy mã đoàn
        public DataTable GetMaDoan()
        {
            string query = "Select top 1 MaDoan from Doan order by MaDoan desc";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daMaDoan = new SqlDataAdapter(query, connect);
            DataTable tbMaDoan = new DataTable();
            daMaDoan.Fill(tbMaDoan);
            connect.Close();
            return tbMaDoan;
        }

        // lấy danh sách mã nhân viên 
        public DataTable GetMaNhanVien()
        {
            string query = "Select MaNV from NhanVien";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daMaNV = new SqlDataAdapter(query, connect);
            DataTable tbMaNV = new DataTable();
            daMaNV.Fill(tbMaNV);
            connect.Close();
            return tbMaNV;
        }
        //get Loại tour của Đoàn
        public DataTable GetLoaiTour(int maTour)
        {
            string query = "select MaLoaiTour from Tour where MaTour= " + maTour;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daLoaiMT = new SqlDataAdapter(query, connect);
            DataTable tbLoaiMaTour = new DataTable();
            daLoaiMT.Fill(tbLoaiMaTour);
            connect.Close();
            return tbLoaiMaTour;
        }

        internal bool insertChiPhi(object p)
        {
            throw new NotImplementedException();
        }

        // lấy danh sách tên nhiệm vụ
        public DataTable GetTenNhiemVu()
        {
            string query = "Select TenNhiemVu from NhiemVu";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daTenNv = new SqlDataAdapter(query, connect);
            DataTable tbManv = new DataTable();
            daTenNv.Fill(tbManv);
            connect.Close();
            return tbManv;
        }
        public DataTable GetMaNhiemVu(string tenNhiemVu)
        {
            string query = "Select MaNhiemVu from NhiemVu where TenNhiemVu = '" + tenNhiemVu + "'";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daManv = new SqlDataAdapter(query, connect);
            DataTable tbManv = new DataTable();
            daManv.Fill(tbManv);
            connect.Close();
            return tbManv;
        }
        // lấy danh sách mã khách hàng
        public DataTable GetMaKH()
        {
            string query = "Select MaKH from KhachHang";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daMaKH = new SqlDataAdapter(query, connect);
            DataTable tbMaKH = new DataTable();
            daMaKH.Fill(tbMaKH);
            connect.Close();
            return tbMaKH;
        }
        // lấy ds mã đoàn 
        public DataTable GetDsMaDoan(int maTour)
        {
            string query = "Select MaDoan from Doan where MaTour= " + maTour;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daMaDoan = new SqlDataAdapter(query, connect);
            DataTable tbMaDoan = new DataTable();
            daMaDoan.Fill(tbMaDoan);
            connect.Close();
            return tbMaDoan;
        }
        public DataTable GetDsMaDoan1()
        {

            string query = "Select MaDoan from Doan where MaTour = (select top 1 MaTour from Tour order by MaTour asc)";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daMaDoan = new SqlDataAdapter(query, connect);
            DataTable tbMaDoan = new DataTable();
            daMaDoan.Fill(tbMaDoan);
            connect.Close();
            return tbMaDoan;
        }
        // get danh sách khách hàng
        public DataTable GetDsKH(int MaKH)
        {
            string query = "select * from KhachHang where MaKH = " + MaKH;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daDsKH = new SqlDataAdapter(query, connect);
            DataTable tbDsKH = new DataTable();
            daDsKH.Fill(tbDsKH);
            connect.Close();
            return tbDsKH;
        }
        public DataTable GetInfoNV(int maNV)
        {
            string query = "select * from NhanVien where MaNV = " + maNV;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daInfoNV = new SqlDataAdapter(query, connect);
            DataTable tbInfoNV = new DataTable();
            daInfoNV.Fill(tbInfoNV);
            connect.Close();
            return tbInfoNV;
        }
        // insert chi phí
        public bool insertChiPhi(ChiPhi cp)
        {
            string query = "insert into ChiPhi (MaDoan,TenChiPhi,SoTien,GhiChu) values(@MaDoan,@TenCP,@SoTien,@GhiChu)";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@MaDoan", SqlDbType.Int).Value = cp.MaDoan;
                cmd.Parameters.Add("@TenCP", SqlDbType.NVarChar).Value = cp.tenCP;
                cmd.Parameters.Add("@SoTien", SqlDbType.Float).Value = cp.sotien;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = cp.ghiChu;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        //insert chitietDoan
        public bool insertCTDoan(int makh, int madoan)
        {
            string query = "insert into ChiTietDoan (MaDoan,MaKH) values(@MaDoan,@MaKH)";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@MaDoan", SqlDbType.Int).Value = madoan;
                cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = makh;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        // insert nhavientheodoan
        public bool insertNVTheoDoan(int manv, int madoan, int maNhiemVu)
        {
            string query = "insert into NhanVienTheoDoan (MaDoan,MaNV, MaNhiemVu) values(@MaDoan,@MaNV,@maNhiemVu)";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@MaDoan", SqlDbType.Int).Value = madoan;
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = manv;
                cmd.Parameters.Add("@maNhiemVu", SqlDbType.Int).Value = maNhiemVu;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        // Insert Doan
        public bool insertDoan(Doan d)
        {
            string query = "insert into Doan (GioDi,GioVe,MaTour,TenDoan) values(@GioDi,@GioVe,@MaTour,@TenDoan)";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                // cmd.Parameters.Add("@MaDoan", SqlDbType.Int).Value =d.MaDoan;
                cmd.Parameters.Add("@GioDi", SqlDbType.DateTime).Value = d.GioDi;
                cmd.Parameters.Add("@GioVe", SqlDbType.DateTime).Value = d.GioVe;
                cmd.Parameters.Add("@MaTour", SqlDbType.Int).Value = d.MaTour;
                cmd.Parameters.Add("@TenDoan", SqlDbType.NVarChar).Value = d.TenDoan;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        //get InfoDoan theo mã đoàn
        public DataTable getInfoDoan(int madoan)
        {
            string query = "select * from Doan where MaDoan = " + madoan;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daInfoDoan = new SqlDataAdapter(query, connect);
            DataTable tbInfoDoan = new DataTable();
            daInfoDoan.Fill(tbInfoDoan);
            connect.Close();
            return tbInfoDoan;
        }
        //get InfoDoan theo mã đoàn
        public DataTable getKhachHang(int madoan)
        {
            string query = "select kh.* from ChiTietDoan as ctd join KhachHang as kh on ctd.MaKH = kh.MaKH  where ctd.MaDoan = " + madoan;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daKH = new SqlDataAdapter(query, connect);
            DataTable tbKH = new DataTable();
            daKH.Fill(tbKH);
            connect.Close();
            return tbKH;
        }
        //get Nhân viên theo đoàn theo mã đoàn
        public DataTable getNVTD(int madoan)
        {
            string query = "select nv.*,b.* from NhanVienTheoDoan as nvtd join NhanVien as nv on nvtd.MaNV = nv.MaNV join NhiemVu as b on nvtd.MaNhiemVu = b.MaNhiemVu where nvtd.MaDoan =" + madoan;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daNvTd = new SqlDataAdapter(query, connect);
            DataTable tbNvTd = new DataTable();
            daNvTd.Fill(tbNvTd);
            connect.Close();
            return tbNvTd;
        }
        //get chi phi theo mã đoàn
        public DataTable getChiPhi(int madoan)
        {
            string query = "select cp.TenChiPhi, cp.SoTien, cp.GhiChu from ChiPhi as cp where MaDoan=" + madoan;
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daNvTd = new SqlDataAdapter(query, connect);
            DataTable tbNvTd = new DataTable();
            daNvTd.Fill(tbNvTd);
            connect.Close();
            return tbNvTd;
        }
        // Update Doan 
        public bool UpdateDoan(Doan d)
        {
            string query = "Update Doan set MaTour = @MaTour, GioDi=@GioDi, GioVe=@GioVe,TenDoan=@TenDoan  where MaDoan=@MaDoan";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@MaDoan", SqlDbType.Int).Value = d.MaDoan;
                cmd.Parameters.Add("@MaTour", SqlDbType.Int).Value = d.MaTour;
                cmd.Parameters.Add("@TenDoan", SqlDbType.NVarChar).Value = d.TenDoan;
                cmd.Parameters.Add("@GioDi", SqlDbType.NVarChar).Value = d.GioDi;
                cmd.Parameters.Add("@GioVe", SqlDbType.NVarChar).Value = d.GioVe;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        //delete nhân viên theo đoàn
        public bool XoaNVTheoDoan(int maDoan)
        {
            string query = "delete from NhanVienTheoDoan where MaDoan= @maDoan";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@maDoan", SqlDbType.Int).Value = maDoan;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        //delete chi tiết theo đoàn
        public bool XoaChiTietDoan(int maDoan)
        {
            string query = "delete from ChiTietDoan where MaDoan= @maDoan";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@maDoan", SqlDbType.Int).Value = maDoan;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        //delete chi phí theo đoàn
        public bool XoaChiPhiDoan(int maDoan)
        {
            string query = "delete from ChiPhi where MaDoan= @maDoan";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@maDoan", SqlDbType.Int).Value = maDoan;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteDoan(int maDoan)
        {
            string query = "delete from Doan where MaDoan=@maDoan";
            SqlConnection connect = conn.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.Parameters.Add("@maDoan", SqlDbType.Int).Value = maDoan;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }
        //get Ten chi phi 
        public DataTable getTenChiPhi()
        {
            string query = "select * from LoaiChiPhi ";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daLCP = new SqlDataAdapter(query, connect);
            DataTable tbLCP = new DataTable();
            daLCP.Fill(tbLCP);
            connect.Close();
            return tbLCP;
        }
    }   
}
