using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Controller
{
    class ThongKeDAL
    {
        ConnectDB conn = new ConnectDB();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public DataTable getDsChiPhi(int maTour, string tu, string den)
        {
            string query = "select d.MaDoan, cp.TenChiPhi,cp.SoTien,cp.GhiChu from ChiPhi as cp join Doan as d on cp.MaDoan=d.MaDoan  where d.MaDoan in (select MaDoan from Doan where MaTour = " + maTour
                +" and d.GioDi <= '"+den+"' and d.GioVe>= '"+tu+"')";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daDsCP = new SqlDataAdapter(query, connect);
            DataTable tbDsCp = new DataTable();
            daDsCP.Fill(tbDsCp);
            connect.Close();
            return tbDsCp;
        }
        public DataTable getTongChiPhi(int maTour, string tu, string den)
        {
            string query = "select SUM(cp.SoTien) as TongChiPhi from ChiPhi as cp join Doan as d on cp.MaDoan = d.MaDoan join Tour as t on t.MaTour = d.MaTour where t.MaTour = "+maTour + " and d.GioDi <= '" + den + "' and d.GioVe >= '" + tu + "'";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daTCP = new SqlDataAdapter(query, connect);            
            DataTable tbTCP = new DataTable();
            daTCP.Fill(tbTCP);
            connect.Close();
            return tbTCP;
        }
        public DataTable getTongChiPhiKS(int maTour,string tu, string den)
        {
            string query = "select SUM(cp.SoTien) as TongCPKS from ChiPhi as cp join Doan as d on cp.MaDoan = d.MaDoan join Tour as t on t.MaTour = d.MaTour where t.MaTour = "+maTour+ " and cp.TenChiPhi = 'Khach san' and d.GioDi <= '" + den + "' and d.GioVe >= '" + tu + "'";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daTCP = new SqlDataAdapter(query, connect);
            DataTable tbTCP = new DataTable();
            daTCP.Fill(tbTCP);
            connect.Close();
            return tbTCP;
        }
        public DataTable getTongChiPhiAU(int maTour, string tu, string den)
        {
            string query = "select SUM(cp.SoTien) as TongCPAU from ChiPhi as cp join Doan as d on cp.MaDoan = d.MaDoan join Tour as t on t.MaTour = d.MaTour where t.MaTour = " + maTour + " and cp.TenChiPhi = 'An uong' and d.GioDi <= '" + den + "' and d.GioVe >= '" + tu + "'";
            Console.WriteLine(query);
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daCPAU = new SqlDataAdapter(query, connect);
            DataTable tbCPAU = new DataTable();
            daCPAU.Fill(tbCPAU);
            connect.Close();
            return tbCPAU;
        }
        //tổng chi phí khác của tour
        public DataTable getTongChiPhiXe(int maTour, string tu, string den)
        {
            string query = "select SUM(cp.SoTien) as TongCPXe from ChiPhi as cp join Doan as d on cp.MaDoan = d.MaDoan join Tour as t on t.MaTour = d.MaTour where t.MaTour = " + maTour + " and cp.TenChiPhi = 'Thue Xe' and d.GioDi <=  '" + den + "' and d.GioVe >= '" + tu + "'";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daCPXe = new SqlDataAdapter(query, connect);
            Console.WriteLine(query);
            DataTable tbCPXe = new DataTable();
            daCPXe.Fill(tbCPXe);
            connect.Close();
            return tbCPXe;
        }
        // tổng chi phí khác 
        public DataTable getTongChiPhiKhac(int maTour, string tu, string den)
        {
            string query = "select SUM(cp.SoTien) as TongCPKhac from ChiPhi as cp join Doan as d on cp.MaDoan = d.MaDoan join Tour as t on t.MaTour = d.MaTour where t.MaTour = " + maTour + " and cp.TenChiPhi = 'Chi phi khac' and d.GioDi <= '" + den + "' and d.GioVe >= '" + tu + "'";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daCPKhac = new SqlDataAdapter(query, connect);
            DataTable tbCPKhac = new DataTable();
            daCPKhac.Fill(tbCPKhac);
            connect.Close();
            return tbCPKhac;
        }
        // tổng chi phí của Đoàn
        public DataTable getTongCPDoan(int maDoan, string tu, string den)
        {
            string query = "select SUM(SoTien) as TongCPDoan from ChiPhi as cp join Doan as d on cp.MaDoan=d.MaDoan"
                            +" where d.MaDoan = "+maDoan+" and d.GioDi <= '"+ den + "' and d.GioVe >= '"+ tu + "'";
            Console.WriteLine(query);
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daCPDoan = new SqlDataAdapter(query, connect);
            DataTable tbCPDoan = new DataTable();
            daCPDoan.Fill(tbCPDoan);
            connect.Close();
            return tbCPDoan;
        }
        //thống kê ds số lần đi tour của nhân viên
        public DataTable getDsTour(int maNV, string tu, string den)
        {
            string query = "select t.MaTour,nv.MaDoan,Nhv.* from NhanVienTheoDoan as nv join Doan as d on nv.MaDoan = d.MaDoan join Tour as t on t.MaTour = d.MaTour join NhiemVu as Nhv on nv.MaNhiemVu=Nhv.MaNhiemVu where nv.MaNV = " + maNV + " and d.GioDi <='" + den + "' and GioVe>= '" + tu+ "'";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daDsTour = new SqlDataAdapter(query, connect);
            DataTable tbDsTour = new DataTable();
            daDsTour.Fill(tbDsTour);
            connect.Close();
            return tbDsTour;
        }
        //tổng số lần đi tour
        public DataTable getSoLanDiTour(int maNV, string tu, string den)
        {
            string query = "select Count(*) as SoLan from NhanVienTheoDoan as nv join Doan as d on nv.MaDoan = d.MaDoan join Tour as t on t.MaTour = d.MaTour where nv.MaNV = " + maNV + " and d.GioDi <='" + den + "' and GioVe>= '" + tu + "'";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daDsTour = new SqlDataAdapter(query, connect);
            DataTable tbDsTour = new DataTable();
            daDsTour.Fill(tbDsTour);
            connect.Close();
            return tbDsTour;
        }
        //thống kê số lần làm hướng dẫn viên du lịch
        public DataTable getSoLanHDV(int maNV, string tu, string den)
        {
            string query = "select Count(*) as SoLan from NhanVienTheoDoan as nv join Doan as d on nv.MaDoan = d.MaDoan join Tour as t on t.MaTour = d.MaTour where nv.MaNV = " + maNV + " and d.GioDi <= '" + den + "' and GioVe>= '" + tu + "' and nv.MaNhiemVu=1";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daDsTour = new SqlDataAdapter(query, connect);
            DataTable tbDsTour = new DataTable();
            daDsTour.Fill(tbDsTour);
            connect.Close();
            return tbDsTour;
        }
        //thống kê số lần làm tài xế
        public DataTable getDiTourTaiXe(int maNV, string tu, string den)
        {
            string query = "select Count(*) as SoLan from NhanVienTheoDoan as nv join Doan as d on nv.MaDoan = d.MaDoan join Tour as t on t.MaTour = d.MaTour where nv.MaNV = " + maNV + " and d.GioDi <= '" + den + "' and GioVe>= '" + tu + "' and nv.MaNhiemVu=2";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daDsTour = new SqlDataAdapter(query, connect);
            DataTable tbDsTour = new DataTable();
            daDsTour.Fill(tbDsTour);
            connect.Close();
            return tbDsTour;
        }
        //thống kê số lần làm nv chăm sóc khách hàng
        public DataTable getCSKH(int maNV, string tu, string den)
        {
            string query = "select Count(*) as SoLan from NhanVienTheoDoan as nv join Doan as d on nv.MaDoan = d.MaDoan join Tour as t on t.MaTour = d.MaTour where nv.MaNV = " + maNV + " and d.GioDi <= '" + den + "' and GioVe>= '" + tu + "' and nv.MaNhiemVu=3";
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daDsTour = new SqlDataAdapter(query, connect);
            DataTable tbDsTour = new DataTable();
            daDsTour.Fill(tbDsTour);
            connect.Close();
            return tbDsTour;
        }

        // get mã tour, mã đoàn, ngày đi, ngày về, giá đoàn // thong kê doanh thu
        public DataTable getThongTinDoanTheoTour(int MaTour, string tu, string den)
        {
            string query = "select distinct  A.MaDoan, A.NgayDi,A.NgayVe,A.Gia,B.SoKhach, (Gia*B.SoKhach) as TongThu,"
                            +" ISNULL(A.ChiPhi,0) as ChiPhi,((Gia*B.SoKhach) - ISNULL(A.ChiPhi,0)) as DoanhThu"
                            +" from"
                            +" (select distinct  d.MaDoan, d.GioDi, d.GioVe, gt.Gia, lt.LoaiTour, SUM(cp.SoTien) as ChiPhi"
                            +" from Tour as t"
                            +" left join Doan as d on t.MaTour = d.MaTour"
                            +" right join GiaTour as gt on gt.MaTour = t.MaTour"
                            +" right join LoaiTour as lt on lt.Id = t.MaLoaiTour"
                            +" left join ChiPhi as cp on cp.MaDoan = d.MaDoan"
                            +" where  t.MaTour = "+MaTour+" and  d.GioDi >= gt.ThoiGianBD and d.GioDi < gt.ThoiGianKT and d.GioDi <= '"+den+"' and d.GioVe >= '"+tu+"'"
                            +" group by d.MaDoan, d.GioDi, d.GioVe, gt.Gia, lt.LoaiTour) as A(MaDoan, NgayDi, NgayVe, Gia, LoaiTour, ChiPhi),"
                            +" (select ctd.MaDoan,COUNT(*) as SoKhach"
                            +" from ChiTietDoan as ctd  left join Doan as d on d.MaDoan = ctd.MaDoan"
                            +" group by ctd.MaDoan) as B(MaDoan, SoKhach)"
                            +" where A.MaDoan = B.MaDoan";
            Console.WriteLine(query);
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daDsTour = new SqlDataAdapter(query, connect);
            DataTable tbDsTour = new DataTable();
            daDsTour.Fill(tbDsTour);
            connect.Close();
            return tbDsTour;
        }

        // tình hình tour
        public DataTable getTinhHinhTour(int MaTour, string tu, string den)
        {
            string query = "select distinct  A.MaDoan,B.SoKhach, ((Gia*B.SoKhach) - ISNULL(A.ChiPhi,0)) as DoanhThu,A.LoaiTour"
+" from"
+" (select distinct  d.MaDoan, d.GioDi, d.GioVe, gt.Gia, lt.LoaiTour, SUM(cp.SoTien) as ChiPhi"
+" from Tour as t"
+" left join Doan as d on t.MaTour = d.MaTour"
+" right join GiaTour as gt on gt.MaTour = t.MaTour"
+" right join LoaiTour as lt on lt.Id = t.MaLoaiTour"
+" left join ChiPhi as cp on cp.MaDoan = d.MaDoan"
+" where  t.MaTour = "+MaTour+" and  d.GioDi >= gt.ThoiGianBD and d.GioDi < gt.ThoiGianKT and d.GioDi <= '"+den+"' and d.GioVe >= '"+tu+"'"
+" group by d.MaDoan, d.GioDi, d.GioVe, gt.Gia, lt.LoaiTour) as A(MaDoan, NgayDi, NgayVe, Gia, LoaiTour, ChiPhi),"
+" (select ctd.MaDoan,COUNT(*) as SoKhach"
+" from ChiTietDoan as ctd  left join Doan as d on d.MaDoan = ctd.MaDoan"
+" group by ctd.MaDoan) as B(MaDoan, SoKhach)"
+" where A.MaDoan = B.MaDoan";
            Console.WriteLine(query);
            SqlConnection connect = conn.getConnect();
            SqlDataAdapter daDsTour = new SqlDataAdapter(query, connect);
            DataTable tbDsTour = new DataTable();
            daDsTour.Fill(tbDsTour);
            connect.Close();
            return tbDsTour;
        }
    }
}
