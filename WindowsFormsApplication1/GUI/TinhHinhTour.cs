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
    public partial class TinhHinhTour : Form
    {
        TourBLL tour;
        ThongKeBLL tk;
        public TinhHinhTour()
        {
            InitializeComponent();
            tour = new TourBLL();
            tk = new ThongKeBLL();
            loadMaTour();
            dgvTinhHinhTour.ReadOnly = true;
        }
        private void loadMaTour()
        {
            DataTable tbMaTour = tour.getDsMaTour();
            cbbMaTour.DataSource = tbMaTour;
            cbbMaTour.DisplayMember = "MaTour";
            cbbMaTour.ValueMember = "MaTour";
        }

        private void bbThongKe_Click(object sender, EventArgs e)
        {
            if (ValidateTime() == false)
                MessageBox.Show("Khoảng thời gian thống kê không hợp lệ");
            else
            {
                int MaTour = int.Parse(cbbMaTour.Text);
                string tu = dtTu.Text;
                string den = dtDen.Text;
                DataTable tinhHinhTour = tk.getTinhHinhTour(MaTour, tu, den);
                dgvTinhHinhTour.DataSource = tinhHinhTour;
                tbSoDoan.Text = (dgvTinhHinhTour.RowCount - 1).ToString();
                int soKhach = 0;
                int DoanhThu = 0;
                int SoTourTrongNgay = 0;
                int SoTourDaiNgay = 0;
                for (int i = 0; i < dgvTinhHinhTour.RowCount - 1; i++)
                {
                    soKhach = soKhach + int.Parse(dgvTinhHinhTour.Rows[i].Cells[1].Value.ToString());
                    DoanhThu = DoanhThu + int.Parse(dgvTinhHinhTour.Rows[i].Cells[2].Value.ToString());
                    if (dgvTinhHinhTour.Rows[i].Cells[3].Value.ToString().Equals("Tour trong ngày"))
                        SoTourTrongNgay += 1;
                    else
                        SoTourDaiNgay += 1;
                }
                tbSoKhach.Text = soKhach.ToString();
                tbDoanhThu.Text = DoanhThu.ToString();
                tbSoTourNganNgay.Text = SoTourTrongNgay.ToString();
                tbSoTourDaiNgay.Text = SoTourDaiNgay.ToString();
            }            
    }

        private void cbbMaTour_KeyPress(object sender, KeyPressEventArgs e)
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
