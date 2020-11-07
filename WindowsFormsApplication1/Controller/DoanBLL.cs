using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;
using WindowsFormsApplication1.Object;

namespace WindowsFormsApplication1.Controller
{
    class DoanBLL
    {
        DoanDAL doan;
        public DoanBLL()
        {
            doan = new DoanDAL();
        }
        public DataTable GetMaDoan()
        {
            return doan.GetMaDoan();
        }
        public DataTable GetMaNV()
        {
            return doan.GetMaNhanVien();
        }
        public DataTable GetTenNhiemVu()
        {
            return doan.GetTenNhiemVu();
        }
        public DataTable getDsMaDoan(int maTour)
        {
            return doan.GetDsMaDoan(maTour);
        }
        public DataTable getDsMaDoan1()
        {
            return doan.GetDsMaDoan1();
        }
        public DataTable GetMaNhiemVU(string tenNhiemVu)
        {
            return doan.GetMaNhiemVu(tenNhiemVu);
        }
        public DataTable GetMaKH()
        {
            return doan.GetMaKH();
        }
        public DataTable getDsKH(int maKH)
        {
            return doan.GetDsKH(maKH);
        }
        public DataTable getInfoNV(int manv)
        {
            return doan.GetInfoNV(manv);
        }
        public DataTable getInfoDoan(int madoan)
        {
            return doan.getInfoDoan(madoan);
        }
        public DataTable getKhachHang(int madoan)
        {
            return doan.getKhachHang(madoan);
        }
        public DataTable getNVTD(int madoan)
        {
            return doan.getNVTD(madoan);
        }
        public DataTable getChiPhi(int madoan)
        {
            return doan.getChiPhi(madoan);
        }
        public bool insertChiPhi(ChiPhi cp)
        {
            return doan.insertChiPhi(cp);
        }
        public bool insertCTDoan(int MaKH, int MaDoan)
        {
            return doan.insertCTDoan(MaKH, MaDoan);
        }
        public bool insertNVTheoDoan(int manv, int maDoan, int maNhiemVu)
        {
            return doan.insertNVTheoDoan(manv, maDoan, maNhiemVu);
        }
        public bool insertDoan(Doan d)
        {
            return doan.insertDoan(d);
        }
        public bool UpdateDoan(Doan d)
        {
            return doan.UpdateDoan(d);
        }
        public bool XoaNVTheoDoan(int maDoan)
        {
           return doan.XoaNVTheoDoan(maDoan);
        }
        public bool XoaChiTietDoan(int maDoan)
        {
            return doan.XoaChiTietDoan(maDoan);
        }
        public bool XoaChiPhiDoan(int maDoan)
        {
            return doan.XoaChiPhiDoan(maDoan);
        }
        public bool DeleteDoan(int maDoan)
        {
            return doan.DeleteDoan(maDoan);
        }
        public DataTable getTenLCP()
        {
            return doan.getTenChiPhi();
        }
        //get Loại tour của Đoàn
        public DataTable GetLoaiTour(int maTour)
        {
            return doan.GetLoaiTour(maTour);
        }

    }
}
