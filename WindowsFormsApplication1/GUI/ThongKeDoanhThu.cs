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
    public partial class ThongKeDoanhThu : Form
    {
        TourBLL tour;
        DoanBLL doan;
        DataTable tbMaDoan;
        ThongKeBLL tk;
        public ThongKeDoanhThu()
        {
            InitializeComponent();
            tour = new TourBLL();
            doan = new DoanBLL();
            tk = new ThongKeBLL();

            loadMaTour();
            dgvDoanhThu.ReadOnly = true;          
        }
        private void loadMaTour()
        {
            DataTable tbMaTour = tour.getDsMaTour();
            cbbMaTour.DataSource = tbMaTour;
            cbbMaTour.DisplayMember = "MaTour";
            cbbMaTour.ValueMember = "MaTour";
        }               
        private void btThongKe_Click(object sender, EventArgs e)
        {
            if (ValidateTime() == false)
                MessageBox.Show("Khoảng thời gian thống kê không hợp lệ");
            else
            {
                int maTour = int.Parse(cbbMaTour.Text);
                string tu = dtTu.Text;
                string den = dtDen.Text;
                DataTable dgv = tk.getThongTinDoanTheoTour(maTour, tu, den);
                dgvDoanhThu.DataSource = dgv;

                int tongDT = 0;

                for (int i = 0; i < dgvDoanhThu.RowCount - 1; i++)
                {
                    tongDT = tongDT + int.Parse(dgvDoanhThu.Rows[i].Cells[7].Value.ToString());
                }
                tbTongDoanhThu.Text = tongDT.ToString();
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
