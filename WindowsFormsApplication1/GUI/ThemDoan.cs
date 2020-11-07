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
using WindowsFormsApplication1.Model;
using WindowsFormsApplication1.Object;

namespace WindowsFormsApplication1
{
    public partial class ThemDoan : Form
    {
        TourBLL tour;
        DoanBLL doan;
        int loaitour;
        public ThemDoan()
        {
            InitializeComponent();
            tour = new TourBLL();
            doan = new DoanBLL();
            LoadMaTour();
            ShowMaDoan();
            LoadMaNhanVien();
            LoadTenNhiemVu();
            LoadMaKH();
            LoadTenCP();
            dtGioDi.Format = DateTimePickerFormat.Custom;
            dtGioDi.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            dtGioVe.Format = DateTimePickerFormat.Custom;
            dtGioVe.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            dgvNV.ReadOnly = true;
            dgvKH.ReadOnly = true;
            dgvChiPhi.ReadOnly = true;            
        }
        public void LoadMaTour()
        {
            DataTable tb = tour.getDsMaTour();
            cbbMaTour.DataSource = tb;
            cbbMaTour.DisplayMember = "MaTour";
            cbbMaTour.ValueMember = "MaTour";
        }
        public void ShowMaDoan()
        {
            int pos = 0;
            DataTable MaDoan = doan.GetMaDoan();
            tbMaDoan.Text = (int.Parse(MaDoan.Rows[pos]["MaDoan"].ToString()) + 1).ToString();
        }
        public void LoadMaNhanVien()
        {
            DataTable tbNhanVien = doan.GetMaNV();
            cbbMaNV.DataSource = tbNhanVien;
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";
        }
        public void LoadTenNhiemVu()
        {
            DataTable tbNhiemVu = doan.GetTenNhiemVu();
            cbbNhiemVu.DataSource = tbNhiemVu;
            cbbNhiemVu.DisplayMember = "TenNhiemVu";
            cbbNhiemVu.ValueMember = "TenNhiemVu";
        }
        public void LoadMaKH()
        {
            DataTable tbKH = doan.GetMaKH();
            cbbMaKH.DataSource = tbKH;
            cbbMaKH.DisplayMember = "MaKH";
            cbbMaKH.ValueMember = "MaKH";
        }
        public void LoadTenCP()
        {
            DataTable tbTCP = doan.getTenLCP();
            cbbTenCP.DataSource = tbTCP;
            cbbTenCP.DisplayMember = "LoaiCP";
            cbbTenCP.ValueMember = "LoaiCP";
        }

        private void cbbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                int maKH = int.Parse(cbbMaKH.Text);
                //kiểm tra khách hàng đã đăng ký đoàn chưa             
                    for (int i = 0; i < dgvKH.RowCount - 1; i++)
                    {
                        int v = int.Parse(dgvKH.Rows[i].Cells[0].Value.ToString());
                        if (maKH == v)
                        {
                            flag = 1;
                            break;
                        }
                        else
                        {
                            flag = 0;
                        }
                    }
                //thêm khách hàng đã có thông tin trong DB vào đoàn đã tạo
                    if (flag == 1)
                        MessageBox.Show("Khách hàng này đã đăng ký đoàn");
                    else
                    {                    
                            // int maKH = int.Parse(cbbMaKH.Text);
                            DataTable tbDsKH = doan.getDsKH(maKH);

                            int makh = int.Parse(tbDsKH.Rows[0]["MaKH"].ToString());
                            string hoten = tbDsKH.Rows[0]["HoTen"].ToString();
                            string cmnd = tbDsKH.Rows[0]["CMND"].ToString();
                            string diachi = tbDsKH.Rows[0]["DiaChi"].ToString();
                            string gioitinh = tbDsKH.Rows[0]["GioiTinh"].ToString();
                            string sdt = tbDsKH.Rows[0]["Sdt"].ToString();

                            dgvKH.Rows.Add(makh, hoten, cmnd, diachi, gioitinh, sdt);                   
                    }
            }
            catch (Exception)
            { }
        }

        private void btChonNV_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(cbbMaNV.Text);
            string nhiemvu = cbbNhiemVu.Text;
            DataTable nv = doan.getInfoNV(manv);
            string tenNV = nv.Rows[0]["TenNV"].ToString();

            DataTable NhiemVu = doan.GetMaNhiemVU(nhiemvu);
            int MaNhiemVu = int.Parse(NhiemVu.Rows[0]["MaNhiemVu"].ToString());
            dgvNV.Rows.Add(manv, tenNV, nhiemvu, MaNhiemVu);
        }

        private void btBoChon_Click(object sender, EventArgs e)
        {
            if (dgvNV.RowCount > 1)
            {
                int VT = dgvNV.CurrentCell.RowIndex;
                dgvNV.Rows.RemoveAt(VT);
            }
            else
                MessageBox.Show("Chưa có nhân viên theo đoàn");
            
        }

        private void btThemCP_Click(object sender, EventArgs e)
        {
            if(cbbTenCP.Text.Equals("") || tbSoTien.Text.Equals("")||tbGhiChu.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn loại chi phí và nhập số tiền");
            }
            else
            {
                string chiphi = cbbTenCP.Text;
                float giatien = float.Parse(tbSoTien.Text);
                string ghichu = tbGhiChu.Text;
                dgvChiPhi.Rows.Add(chiphi, giatien, ghichu);
            }            
        }

        private void bt_Click(object sender, EventArgs e)
        {
            if (dgvChiPhi.RowCount > 1)
            {
                int VT = dgvChiPhi.CurrentCell.RowIndex;
                dgvChiPhi.Rows.RemoveAt(VT);
            }
            else
                MessageBox.Show("Chưa có chi phí được thêm");
            
        }
        private void ThemDoan1()
        {
            int madoan = int.Parse(tbMaDoan.Text);
            // Thêm đoàn
            Doan d = new Doan();
            //   d.MaDoan = madoan;
            d.MaTour = int.Parse(cbbMaTour.Text);
            d.TenDoan = tbTenDoan.Text;
            d.GioDi = dtGioDi.Text;
            d.GioVe = dtGioVe.Text;
            try
            {
                if (doan.insertDoan(d))
                    MessageBox.Show("thêm đoàn thành công");
                else
                    MessageBox.Show("thêm đoàn thất bại");
            }
            catch (Exception) { }

            // Thêm chi phí
            int flag = 0;
            for (int row = 0; row < dgvChiPhi.RowCount - 1; row++)
            {
                ChiPhi cp = new ChiPhi();
                cp.MaDoan = int.Parse(tbMaDoan.Text);
                cp.tenCP = dgvChiPhi.Rows[row].Cells[0].Value.ToString();
                cp.sotien = float.Parse(dgvChiPhi.Rows[row].Cells[1].Value.ToString());
                cp.ghiChu = dgvChiPhi.Rows[row].Cells[2].Value.ToString();
                try
                {
                    if (doan.insertChiPhi(cp))
                        flag = 0;
                    else
                    {
                        flag = 1;
                        MessageBox.Show("Thêm chi phí đoàn thất bại");
                        break;
                    }
                }
                catch (Exception) { }
            }
            if (flag == 0)
                MessageBox.Show("thêm chi phí đoàn thành công");
            // Thêm nhân viên theo đoàn
            int flag2 = 0;
            for (int vt = 0; vt < dgvNV.RowCount - 1; vt++)
            {
                int nhiemVu = int.Parse(dgvNV.Rows[vt].Cells[3].Value.ToString());
                int manv = int.Parse(dgvNV.Rows[vt].Cells[0].Value.ToString());
                try
                {
                    if (doan.insertNVTheoDoan(manv, madoan, nhiemVu))
                        flag2 = 0;
                    else
                    {
                        flag2 = 1;
                        MessageBox.Show("thêm nhân viên thất bại");
                        break;
                    }
                }
                catch (Exception) { }
            }
            if (flag == 0)
                MessageBox.Show("Thêm nhân viên của đoàn thành công");

            //Thêm chi tiết đoàn 
            int flag3 = 0;
            for (int i = 0; i < dgvKH.RowCount - 1; i++)
            {
                int makh = int.Parse(dgvKH.Rows[i].Cells[0].Value.ToString());
                try
                {
                    if (doan.insertCTDoan(makh, madoan))
                        flag3 = 0;
                    else
                    {
                        flag3 = 1;
                        MessageBox.Show("Thêm chi tiết đoàn thất bại");
                        break;
                    }
                }
                catch (Exception) { }
            }
            if (flag3 == 0)
                MessageBox.Show("Thêm chi tiết đoàn thành công");
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            
            if(loaitour == 2)
            {
                if (Validate() == true && ValidateTime2() == true)
                {
                    ThemDoan1();
                }
                else
                    MessageBox.Show("Vui lòng thêm tên đoàn,nhân viên theo đoàn, khách hàng của đoàn và thời gian phải hợp lệ");
            }
            else if (loaitour==1)
            {

                if (Validate() == true && ValidateTime() == true)
                {
                    ThemDoan1();
                }
                else
                    MessageBox.Show("Vui lòng thêm tên đoàn,nhân viên theo đoàn, khách hàng của đoàn và thời gian phải hợp lệ - Tour của bạn là tour trong ngày");
            }
        }                         

        private bool Validate()
        {
            if (dgvNV.RowCount < 2 || dgvKH.RowCount < 2 || tbTenDoan.Text.Equals(""))
                return false;
            return true;
        }
        private bool ValidateTime2()
        {          
                string tgbd = dtGioDi.Text;
                string tgkt = dtGioVe.Text;
                DateTime TGBD = DateTime.Parse(tgbd);
                DateTime TGKT = DateTime.Parse(tgkt);
                if (TGBD > TGKT)
                    return false;
                return true;                                 
        }
        private bool ValidateTime()
        {
            string tgbd1 = dtGioDi.Text;
            string tgkt1 = dtGioVe.Text;
            DateTime TGBD1 = DateTime.Parse(tgbd1);
            DateTime TGKT1 = DateTime.Parse(tgkt1);
            string tgbd = TGBD1.ToString("MM/dd/yyyy");
            string tgkt = TGKT1.ToString("MM/dd/yyyy");
            DateTime TGBD = DateTime.Parse(tgbd);
            DateTime TGKT = DateTime.Parse(tgkt);
            if (TGBD != TGKT)
                return false;
            return true;
        }
        private void btNhapLai_Click(object sender, EventArgs e)
        {
            cbbTenCP.Text = "";
            tbSoTien.Text = "";
            tbGhiChu.Text = "";        
        }

        private void tbSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbMaDoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btBoChonKH_Click(object sender, EventArgs e)
        {
            if (dgvKH.RowCount > 1)
            {
                int VT = dgvKH.CurrentCell.RowIndex;
                dgvKH.Rows.RemoveAt(VT);
            }
            else
                MessageBox.Show("Chưa có khách hàng của đoàn");
        }

        private void cbbMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cbbNhiemVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cbbMaTour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cbbMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cbbTenCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cbbMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int maTour = int.Parse(cbbMaTour.Text);
                DataTable tbLoaiTour = doan.GetLoaiTour(maTour);
                loaitour = int.Parse(tbLoaiTour.Rows[0]["MaLoaiTour"].ToString());
            }catch(Exception )
            { }
                      
        }
    }
}
