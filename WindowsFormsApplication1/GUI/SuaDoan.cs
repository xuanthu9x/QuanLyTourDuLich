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

namespace WindowsFormsApplication1.GUI
{
    public partial class SuaDoan : Form
    {
        TourBLL tour;
        DoanBLL doan;
        DataTable tbKh;
        DataTable tbNV;
        DataTable tbCp;
        public SuaDoan()
        {
            InitializeComponent();
            tour = new TourBLL();
            doan = new DoanBLL();
            LoadMaTour();
            LoadMaDoan();
            LoadMaNhanVien();
            LoadTenNhiemVu();
            LoadMaKH();
            LoadTenCP();

            dtGioDi.Format = DateTimePickerFormat.Custom;
            dtGioDi.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            dtGioVe.Format = DateTimePickerFormat.Custom;
            dtGioVe.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            dgvChiPhi.ReadOnly = true;
            dgvKH.ReadOnly = true;
            dgvNV.ReadOnly = true;         
        }            
        public void LoadMaTour()
        {
            DataTable tb = tour.getDsMaTour();
            cbbMaTour.DataSource = tb;
            cbbMaTour.DisplayMember = "MaTour";
            cbbMaTour.ValueMember = "MaTour";
        }
        public void LoadMaNhanVien()
        {
            DataTable tbNhanVien = doan.GetMaNV();
            cbbMaNV.DataSource = tbNhanVien;
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";
        }
        public void LoadMaDoan()
        {            
            DataTable tbMaDoan = doan.getDsMaDoan1();
            cbbMaDoan.DataSource = tbMaDoan;
            cbbMaDoan.DisplayMember = "MaDoan";
            cbbMaDoan.ValueMember = "MaDoan";
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
            DataTable tbTenCP = doan.getTenLCP();
            cbbTenCP.DataSource = tbTenCP;
            cbbTenCP.DisplayMember = "LoaiCP";
            cbbTenCP.ValueMember = "LoaiCP";
        }
        private void cbbMaDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int maDoan = int.Parse(cbbMaDoan.Text);                
                DataTable tbDoan = doan.getInfoDoan(maDoan);
                cbbMaTour.Text = tbDoan.Rows[0]["MaTour"].ToString();
                tbTenDoan.Text = tbDoan.Rows[0]["TenDoan"].ToString();
                dtGioDi.Text = tbDoan.Rows[0]["GioDi"].ToString();
                dtGioVe.Text = tbDoan.Rows[0]["GioVe"].ToString();

                tbKh = doan.getKhachHang(maDoan);
                dgvKH.DataSource = tbKh;

                tbNV = doan.getNVTD(maDoan);
                dgvNV.DataSource = tbNV;

                tbCp = doan.getChiPhi(maDoan);
                dgvChiPhi.DataSource = tbCp;
            }
            catch (Exception ) { }             
        }

        private void dgvChiPhi_Click(object sender, EventArgs e)
        {
            if(dgvChiPhi.DataSource != null && dgvChiPhi.RowCount > 1)
            {
                int VT = dgvChiPhi.CurrentCell.RowIndex;
                cbbTenCP.Text = dgvChiPhi.Rows[VT].Cells[0].Value.ToString();
                tbSoTien.Text = dgvChiPhi.Rows[VT].Cells[1].Value.ToString();
                tbGhiChu.Text = dgvChiPhi.Rows[VT].Cells[2].Value.ToString();
            }           
        }

        private void dgvNV_Click(object sender, EventArgs e)
        {
            if(dgvNV.DataSource != null && dgvNV.RowCount > 1)
            {
                int VT = dgvNV.CurrentCell.RowIndex;
                cbbMaNV.Text = dgvNV.Rows[VT].Cells[0].Value.ToString();
                cbbNhiemVu.Text = dgvNV.Rows[VT].Cells[3].Value.ToString();
            }           
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
                    DataTable tbDsKH = doan.getDsKH(maKH);
                    //lấy giá trị từng field của table trả về - note- table trả về chỉ có 1 row
                    int makh = int.Parse(tbDsKH.Rows[0]["MaKH"].ToString());
                    string hoten = tbDsKH.Rows[0]["HoTen"].ToString();
                    string cmnd = tbDsKH.Rows[0]["CMND"].ToString();
                    string diachi = tbDsKH.Rows[0]["DiaChi"].ToString();
                    string gioitinh = tbDsKH.Rows[0]["GioiTinh"].ToString();
                    string sdt = tbDsKH.Rows[0]["Sdt"].ToString();

                    DataRow row = tbKh.NewRow();
                    row[0] = makh;
                    row[1] = hoten;
                    row[2] = cmnd;
                    row[3] = diachi;
                    row[4] = gioitinh;
                    row[5] = sdt;
                    tbKh.Rows.Add(row);
                    dgvKH.DataSource = tbKh;
                }                 
            }// try
            catch (Exception)
            { }
        }

        private void btXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvKH.DataSource == null)
                MessageBox.Show("Vui lòng chọn đoàn cần sửa");
            else if (dgvKH.RowCount < 2)
                MessageBox.Show("Chưa có khách hàng nào được thêm vào đoàn");
            else
            {
                int VT = dgvKH.CurrentCell.RowIndex;
                dgvKH.Rows.RemoveAt(VT);
            }            
        }

        private void btChonNV_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(cbbMaNV.Text);
            DataTable t = doan.getInfoNV(manv);
            string tenNV= t.Rows[0]["TenNV"].ToString();
            DataRow row = tbNV.NewRow();
            row[0] = manv;
            row[1] = tenNV;
            string tenNhiemVu = cbbNhiemVu.Text;
            DataTable MaNhiemvu = doan.GetMaNhiemVU(tenNhiemVu);
            int maNhiemVu =int.Parse(MaNhiemvu.Rows[0]["MaNhiemVu"].ToString());
            row[2] = maNhiemVu;
            row[3] = cbbNhiemVu.Text;
            tbNV.Rows.Add(row);
            dgvNV.DataSource = tbNV;
        }

        private void btBoChonNV_Click(object sender, EventArgs e)
        {
            if (dgvNV.DataSource == null)
                MessageBox.Show("Vui lòng chọn đoàn cần sửa");
            else if (dgvNV.RowCount < 2)
                MessageBox.Show("không có nhân viên nào đang được chọn cho đoàn"); 
            else       
            {
                int VT = dgvNV.CurrentCell.RowIndex;
                dgvNV.Rows.RemoveAt(VT);
            }           
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataRow row = tbCp.NewRow();
            row[0] = cbbTenCP.Text;
            row[1] = tbSoTien.Text;
            row[2] = tbGhiChu.Text;
            tbCp.Rows.Add(row);
            dgvChiPhi.DataSource = tbCp;
        }

        private void btNhapMoi_Click(object sender, EventArgs e)
        {
            cbbTenCP.Text = "";
            tbSoTien.Text = "";
            tbGhiChu.Text = "";        
        }

        private void btXoaCP_Click(object sender, EventArgs e)
        {
            if (dgvChiPhi.DataSource == null)
                MessageBox.Show("Vui lòng chọn đoàn cần sửa");
            else if (dgvChiPhi.RowCount < 2)
                MessageBox.Show("Không có chi phí được thêm");
            else
            {
                int VT = dgvChiPhi.CurrentCell.RowIndex;
                dgvChiPhi.Rows.RemoveAt(VT);
            }            
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            //update đoàn
            if (Validate() == true)
            {
                Doan d = new Doan();
                d.MaDoan = int.Parse(cbbMaDoan.Text);
                d.MaTour = int.Parse(cbbMaTour.Text);
                d.TenDoan = tbTenDoan.Text;
                d.GioDi = dtGioDi.Text;
                d.GioVe = dtGioVe.Text;
                if (doan.UpdateDoan(d))
                    MessageBox.Show("Sửa đoàn thành công");
                else
                    MessageBox.Show("Sửa đoàn thất bại");
                try
                {
                    int maDoan = int.Parse(cbbMaDoan.Text);
                    //xóa nhân viên theo đoàn
                    int flag = 0;
                    if (doan.XoaNVTheoDoan(maDoan))
                    {
                        Console.WriteLine("Xóa nhân viên theo đoàn thành công");
                        for (int i = 0; i < dgvNV.RowCount - 1; i++)
                        {
                            int maNV = int.Parse(dgvNV.Rows[i].Cells[0].Value.ToString());
                            int maNhiemVu = int.Parse(dgvNV.Rows[i].Cells[2].Value.ToString());
                            if (doan.insertNVTheoDoan(maNV, maDoan, maNhiemVu))
                            {
                                flag = 0;
                            }
                            else
                            {
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 0)
                            MessageBox.Show("Sửa danh sách nhân viên theo đoàn thành công");
                    }
                    // xóa chi tiết đoàn 
                    int flag1 = 0;
                    if (doan.XoaChiTietDoan(maDoan))
                    {
                        Console.WriteLine("Xóa chi tiết đoàn thành công");
                        for (int vt = 0; vt < dgvKH.RowCount - 1; vt++)
                        {
                            int maKH = int.Parse(dgvKH.Rows[vt].Cells[0].Value.ToString());
                            if (doan.insertCTDoan(maKH, maDoan))
                            {
                                flag1 = 0;
                            }
                            else
                            {
                                flag1 = 1;
                                break;
                            }
                        }
                        if (flag1 == 0)
                            MessageBox.Show("Sửa danh sách chi tiết đoàn thành công");
                    }//if
                     //xóa chi phí đoàn
                    int flag2 = 0;
                    if (doan.XoaChiPhiDoan(maDoan))
                    {
                        Console.WriteLine("Xóa danh sách chi phí đoàn thành công");
                        for (int r = 0; r < dgvChiPhi.RowCount - 1; r++)
                        {
                            ChiPhi p = new ChiPhi();
                            p.tenCP = dgvChiPhi.Rows[r].Cells[0].Value.ToString();
                            p.sotien = float.Parse(dgvChiPhi.Rows[r].Cells[1].Value.ToString());
                            p.ghiChu = dgvChiPhi.Rows[r].Cells[2].Value.ToString();
                            p.MaDoan = int.Parse(cbbMaDoan.Text);
                            if (doan.insertChiPhi(p))
                            {
                                flag2 = 0;
                            }
                            else
                            {
                                flag2 = 1;
                                break;
                            }
                        }
                        if (flag2 == 0)
                            MessageBox.Show("Sửa danh sách chi phí của đoàn thành công");
                    }
                    else
                    {
                        Console.WriteLine("Xóa danh sách chi phí thất bại");
                    }
                }
                catch (Exception) { }
            }
            else
                MessageBox.Show("Vui lòng nhập tên đoàn, thêm khách hàng, và nhân viên cho đoàn");
            
        }
        private void cbbMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int maTour = int.Parse(cbbMaTour.Text);
                DataTable tbMaDoan = doan.getDsMaDoan(maTour);
                cbbMaDoan.DataSource = tbMaDoan;
            }
            catch(Exception) { }          
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int maDoan =int.Parse(cbbMaDoan.Text);
            //xóa nhân viên theo đoàn
            if (doan.XoaNVTheoDoan(maDoan))
                MessageBox.Show("Xóa nhân viên theo đoàn thành công");
            else
                Console.WriteLine("Xóa nhân viên theo đoàn thất bại");
            //xóa chi phí của đoàn
            if (doan.XoaChiPhiDoan(maDoan))
                MessageBox.Show("Xóa chi phí đoàn thành công");
            else
                Console.WriteLine("Xóa chi phí của đoàn thất bại");
            //xóa chi tiết đoàn           
            if (doan.XoaChiTietDoan(maDoan))
                MessageBox.Show("Xóa chi tiết đoàn thành công");
            else
                MessageBox.Show("Xóa chi tiết đoàn thất bại");
            //xóa đoàn
            if (doan.DeleteDoan(maDoan))
                MessageBox.Show("Xóa đoàn thành công");
            else
                MessageBox.Show("Xóa đoàn thất bại");
            //load lại combobox mã đoàn
            int maTour = int.Parse(cbbMaTour.Text);
            DataTable t = doan.getDsMaDoan(maTour);
            cbbMaDoan.DataSource = t;
            //xóa dgvNhanvien
            dgvNV.DataSource = null;
            //xóa dgvChiPhi
            dgvChiPhi.DataSource = null;
            //xóa dgvKhachHang
            dgvKH.DataSource = null;
        }
        private bool Validate()
        {
            if (dgvNV.RowCount < 2 || dgvKH.RowCount < 2 || tbTenDoan.Text.Equals(""))
                return false;
            return true;
        }

        private void cbbMaDoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cbbMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cbbNhiemVu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbbMaTour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }
    }   
}
