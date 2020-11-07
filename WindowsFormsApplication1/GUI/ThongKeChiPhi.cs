using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controller;

namespace WindowsFormsApplication1.GUI
{
    public partial class ThongKeChiPhi : Form
    {
        TourBLL tour;
        DoanBLL doan;
        DataTable tbMaDoan;
        ThongKeBLL tk;
        public ThongKeChiPhi()
        {
            InitializeComponent();
            tour = new TourBLL();
            doan = new DoanBLL();
            tk = new ThongKeBLL();

            loadMaTour();
            loaddMaDoan();
            dgvDsCp.ReadOnly = true;
        }
        private void loadMaTour()
        {
            DataTable tbMaTour = tour.getDsMaTour();
            cbbMaTour.DataSource = tbMaTour;
            cbbMaTour.DisplayMember = "MaTour";
            cbbMaTour.ValueMember = "MaTour";
        }
        private void loaddMaDoan()
        {
            DataTable tbMaDoan = doan.getDsMaDoan1();
            DataRow row = tbMaDoan.NewRow();
            row[0] = -1;           
            tbMaDoan.Rows.Add(row);
            cbbMaDoan.DataSource = tbMaDoan;            
            cbbMaDoan.DisplayMember = "MaDoan";
            cbbMaDoan.ValueMember = "MaDoan";
            cbbMaDoan.Text = "-1";
        }

        private void cbbMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                    int maTour = int.Parse(cbbMaTour.Text);                    
                    tbMaDoan = doan.getDsMaDoan(maTour);
                    DataRow row = tbMaDoan.NewRow();
                    row[0] = -1;
                    tbMaDoan.Rows.Add(row);
                    cbbMaDoan.DataSource = tbMaDoan;
                    cbbMaDoan.Text = "-1";                                
            }
            catch(Exception) { }            
        }

        private void cbbMaDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int maDoan = int.Parse(cbbMaDoan.Text);
                int maTour = int.Parse(cbbMaTour.Text);
                if (maDoan != -1)
                {
                    DataTable infoDoan = doan.getInfoDoan(maDoan);
                    tbTenDoan.Text = infoDoan.Rows[0]["TenDoan"].ToString();

                    DataTable infoTour = tour.getInfoLoaiTour(maTour);
                    tbLoaiTour.Text = infoTour.Rows[0]["LoaiTour"].ToString();
                }
                else
                {
                    tbTenDoan.Text = "";                    
                }                
            } catch (Exception) { }
            
        }
        private void btThongke_Click(object sender, EventArgs e)
        {
            int maTour = int.Parse(cbbMaTour.Text);
            int maDoan =int.Parse(cbbMaDoan.Text);
            string tu1 = dtTu.Text;
            string den1 = dtDen.Text;
            DateTime TGBD = DateTime.Parse(tu1);
            DateTime TGKT = DateTime.Parse(den1);
            string tu = TGBD.ToString("yyyy - MM - dd");
            string den = TGKT.ToString("yyyy - MM - dd");
            if (maDoan==-1)
              {
                ThongKeCpTour();
                tbCPDoan.Text = "";
            }
            else
            {
                ThongKeCpTour();
                DataTable tbChiPhiDoan = tk.getTongCPDoan(maDoan,tu, den);
                tbCPDoan.Text = tbChiPhiDoan.Rows[0]["TongCPDoan"].ToString();
            }
        }
        private void ThongKeCpTour()
        {
            int maTour = int.Parse(cbbMaTour.Text);
            string tu = dtTu.Text;
            string den = dtDen.Text;
            if (ValidateTime() == false)
                MessageBox.Show("Khoảng thời gian thống kê không hợp lệ");
            else
            {
                DataTable dsChiPhi = tk.getDsCP(maTour,tu, den);
                dgvDsCp.DataSource = dsChiPhi;

                DataTable tongCp = tk.getTongChiPhi(maTour,tu,den);
                tbTongCP.Text = tongCp.Rows[0]["TongChiPhi"].ToString();

                DataTable tongCpKS = tk.getTongChiPhiKS(maTour, tu, den);
                tbCPKS.Text = tongCpKS.Rows[0]["TongCPKS"].ToString();

                DataTable tongCpAU = tk.getTongChiPhiAU(maTour, tu, den);
                tbCPAU.Text = tongCpAU.Rows[0]["TongCPAU"].ToString();

                DataTable tongCpXe = tk.getTongChiPhiXe(maTour, tu, den);
                tbCPTX.Text = tongCpXe.Rows[0]["TongCPXe"].ToString();

                DataTable tongCpKhac = tk.getTongChiPhiKhac(maTour, tu, den);
                tbCPKhac.Text = tongCpKhac.Rows[0]["TongCPKhac"].ToString();
            }            
        }
        private void cbbMaTour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }
        private void cbbMaDoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }
        private bool ValidateTime()
        {
            string tgbd = dtTu.Text;
            string tgkt = dtDen.Text;
            DateTime TGBD = DateTime.Parse(tgbd);
            DateTime TGKT = DateTime.Parse(tgbd);           
            if (TGBD > TGKT)
                return false;
            return true;
        }
    }
}
