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
    public partial class ThongKeSLDT : Form
    {
        DoanBLL doan;
        ThongKeBLL tk;
        public ThongKeSLDT()
        {
            InitializeComponent();
            doan = new DoanBLL();
            tk = new ThongKeBLL();
            loadMaNV();
            dgvDsLan.ReadOnly = true;         
        }
        public void loadMaNV()
        {
            DataTable maNV = doan.GetMaNV();
            cbbMaNV.DataSource = maNV;
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int maNv = int.Parse(cbbMaNV.Text);
                DataTable InfoNV = doan.getInfoNV(maNv);
                tbHoTen.Text = InfoNV.Rows[0]["TenNV"].ToString();
            }
            catch(Exception) { }                     
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            if (ValidateTime() == false)
                MessageBox.Show("Khoảng thời gian thống kê không hợp lệ");
            else
            {
                int maNV = int.Parse(cbbMaNV.Text);
                string tu = dtTu.Text;
                string den = dtDen.Text;
                DataTable sdTour = tk.getDsTour(maNV, tu, den);
                dgvDsLan.DataSource = sdTour;

                DataTable SLDT = tk.getSoLanDiTour(maNV, tu, den);
                tbSLDT.Text = SLDT.Rows[0]["SoLan"].ToString();

                DataTable HDV = tk.getSoLanHDV(maNV, tu, den);
                tbHDV.Text = HDV.Rows[0]["SoLan"].ToString();

                DataTable TaiXe = tk.getDiTourTaiXe(maNV, tu, den);
                tbTaiXe.Text = TaiXe.Rows[0]["SoLan"].ToString();

                DataTable CSKH = tk.getCSKH(maNV, tu, den);
                tbCSKH.Text = CSKH.Rows[0]["SoLan"].ToString();
            }            
        }

        private void cbbMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }
        private bool ValidateTime()
        {
            string tgbd = dtTu.Text;
            string tgkt = dtDen.Text;
            DateTime TGBD = DateTime.Parse(tgbd);
            DateTime TGKT = DateTime.Parse(tgkt);
            if (TGBD > TGKT)
                return false;
            return true;
        }
    }
}
