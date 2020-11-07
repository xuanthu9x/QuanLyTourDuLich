using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controller
{
    class ThongKeBLL
    {
        ThongKeDAL tk ;
        public ThongKeBLL()
        {
            tk = new ThongKeDAL();
        }
        public DataTable getDsCP(int maTour,string tu, string den)
        {
            return tk.getDsChiPhi(maTour, tu, den);
        }
        public DataTable getTongChiPhi(int maTour, string tu, string den)
        {
            return tk.getTongChiPhi(maTour,  tu,  den);
        }
        public DataTable getTongChiPhiKS(int maTour, string tu, string den)
        {
            return tk.getTongChiPhiKS(maTour,tu,den);
        }
        public DataTable getTongChiPhiAU(int maTour , string tu, string den)
        {
            return tk.getTongChiPhiAU(maTour, tu, den);
        }
        public DataTable getTongChiPhiXe(int maTour, string tu, string den)
        {
            return tk.getTongChiPhiXe(maTour,tu, den);
        }
        // get tổng chi phí khác của tour
        public DataTable getTongChiPhiKhac(int maTour, string tu, string den)
        {
            return tk.getTongChiPhiKhac(maTour, tu, den);
        }
        //get tổng chi phí đoàn
        public DataTable getTongCPDoan(int maDoan, string tu, string den)
        {
            return tk.getTongCPDoan(maDoan,tu, den);
        }
        public DataTable getDsTour(int maNV, string tu, string den)
        {
            return tk.getDsTour(maNV, tu, den);
        }
        public DataTable getSoLanHDV(int maNV, string tu, string den)
        {
            return tk.getSoLanHDV(maNV, tu, den);
        }
        public DataTable getSoLanDiTour(int maNV, string tu, string den)
        {
            return tk.getSoLanDiTour(maNV, tu, den);
        }
        public DataTable getDiTourTaiXe(int maNV, string tu, string den)
        {
            return tk.getDiTourTaiXe(maNV, tu, den);
        }
        public DataTable getCSKH(int maNV, string tu, string den)
        {
            return tk.getCSKH(maNV, tu, den);
        }
        // get mã tour, mã đoàn, ngày đi, ngày về, giá đoàn
        public DataTable getThongTinDoanTheoTour(int MaTour, string tu, string den)
        {
            return tk.getThongTinDoanTheoTour(MaTour,tu, den);
        }

        // tình hình tour
        public DataTable getTinhHinhTour(int MaTour, string tu, string den)
        {
            return tk.getTinhHinhTour(MaTour, tu, den);
        }
    }
}
