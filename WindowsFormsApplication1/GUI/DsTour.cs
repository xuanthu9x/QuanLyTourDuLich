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

namespace WindowsFormsApplication1
{
    public partial class DsTour : Form
    {
        TourBLL tour;
        GiaBLL gia;
        DiaDiemBLL dd;
        public int pos = 0;
        public int vtRow1;
        public int vtRow2;
        public int vtRow3;
        DataTable tbDD;
        DataTable TBGia;
        int flag = 0;
        public DsTour()
        {
            InitializeComponent();
            tour = new TourBLL();
            gia = new GiaBLL();
            dd = new DiaDiemBLL();
            dgvDsTour.ReadOnly = true;
            dgvDiaDiem.ReadOnly = true;
            dgvDiaDiem1.ReadOnly = true;
            dgvGia.ReadOnly = true;
        }

        private void DsTour_Load(object sender, EventArgs e)
        {
            showAllTour();
            showAllDiaDDiem();
            LoadLoaiTour();          
        }
        public void showAllTour()
        {
            DataTable tb = tour.getAllTour();
            dgvDsTour.DataSource = tb;
        }        
        public void LoadLoaiTour()
        {
            DataTable tb = tour.LoadLoaiTour();
            cbbLoaiTour.DataSource = tb;
            cbbLoaiTour.DisplayMember = "LoaiTour";
            cbbLoaiTour.ValueMember = "Id";
        }
        public void showAllDiaDDiem()
        {
            DataTable tb = dd.GetAllDiaDiem();
            dgvDiaDiem1.DataSource = tb;
            DataTable table = tour.geMaTour();
            tbMaTour.Text = (int.Parse(table.Rows[pos]["MaTour"].ToString()) + 1).ToString();
        }
        private void dgvDsTour_Click(object sender, EventArgs e)
        {
            int VT = dgvDsTour.CurrentCell.RowIndex;
            try
            {
                int matour = int.Parse(dgvDsTour.Rows[VT].Cells[0].Value.ToString());
                tbMaTour.Text = matour.ToString();
                tbTenTour.Text = dgvDsTour.Rows[VT].Cells[2].Value.ToString();
                if (dgvDsTour.Rows[VT].Cells[1].Value.ToString().Equals("1"))
                    cbbLoaiTour.Text = "Tour trong ngày";
                else
                    cbbLoaiTour.Text = "Tour dài ngày";
                tbDD = tour.GetCTTour(matour);
                dgvDiaDiem.DataSource = tbDD;
                TBGia = gia.GetGiaTour(matour);
                dgvGia.DataSource = TBGia;

                DataTable tgbd = tour.GetTGBD(matour);
                string TGBD = tgbd.Rows[0]["ThoiGianBatDau"].ToString();
                dtTGBD.Text = TGBD;
                cbbLoaiTour.Enabled = false;

            }
            catch (Exception) { }
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            int stt = dgvDiaDiem.RowCount;
            int vt = vtRow1;
            if(dgvDiaDiem.DataSource==null)
            {
                MessageBox.Show("Vui lòng chọn tour cần sửa");
            }
            else
            {
                DataRow row = tbDD.NewRow();
                row[0] = dgvDiaDiem1.Rows[vt].Cells[0].Value.ToString();
                row[1] = dgvDiaDiem1.Rows[vt].Cells[1].Value.ToString();
                row[2] = stt.ToString();
                tbDD.Rows.Add(row);
                dgvDiaDiem.DataSource = tbDD;
            }            
        }

        private void dgvDiaDiem1_Click(object sender, EventArgs e)
        {
            int VT = dgvDiaDiem1.CurrentRow.Index;
            vtRow1 = VT;
        }

        private void dgvDiaDiem_MouseClick(object sender, MouseEventArgs e)
        {
            if(dgvDiaDiem.DataSource != null && dgvDiaDiem.RowCount > 1)
            {
                int VT = dgvDiaDiem.CurrentCell.RowIndex; // Lấy ra stt của row đang được chọn
                vtRow2 = VT;
            }           
        }
        private void btBoChon_Click(object sender, EventArgs e)
        {
            if (dgvDiaDiem.RowCount > 1)
            {
                int vt = vtRow2;
                dgvDiaDiem.Rows.RemoveAt(vt);
            }
            else
                MessageBox.Show("Không còn địa điểm được chọn");
            
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            int VT = dgvDsTour.CurrentCell.RowIndex;
            int matour = int.Parse(dgvDsTour.Rows[VT].Cells[0].Value.ToString());
            string tgbd = dtTGBD.Value.ToString("yyyy/MM/dd");
            string tgkt = dtTGKT.Value.ToString("yyyy/MM/dd");
            if(dgvGia.DataSource==null)
            {
                MessageBox.Show("Vui lòng chọn tour cần sửa");
            }     
            else                 
            if (ValidateTime() == false)
                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc");
            else if(tbGia.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập giá tour");
            }
            else
            {
                float gia = float.Parse(tbGia.Text);
                DataRow row = TBGia.NewRow();
                row[0] = tbMaTour.Text;
                row[1] = tgbd;
                row[2] = tgkt;
                row[3] = gia.ToString();
                TBGia.Rows.Add(row);
                dgvGia.DataSource = TBGia;
            }            
        }
        private bool ValidateTime()
        {
            string tgbd = dtTGBD.Text;
            string tgkt = dtTGKT.Text;
            DateTime TGBD = DateTime.Parse(tgbd);
            DateTime TGKT = DateTime.Parse(tgkt);
            if (TGBD > TGKT)
                return false;
            return true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (dgvGia.RowCount > 1 && dgvDiaDiem.RowCount > 1)
            {
                int VT = dgvDsTour.CurrentCell.RowIndex;
                int matour = int.Parse(dgvDsTour.Rows[VT].Cells[0].Value.ToString());
                //delete chi tiết tour, giá tour
                tour.deleteCTTour(matour);
                gia.deleteGiaTour(matour);
                // thêm lại
                //Thêm Chi Tiết tour
                Tour t = new Tour();
                int flag = 0;
                if (dgvDiaDiem.RowCount == 0)
                    MessageBox.Show("Không thêm chi tiết tour");
                else
                {
                    for (int tt = 0; tt < dgvDiaDiem1.RowCount - 1; tt++)
                    {
                        try
                        {
                            t.MaTour = matour;
                            string mdd = dgvDiaDiem.Rows[tt].Cells[0].Value.ToString();
                            t.MaDiaDiem = mdd;
                            t.thutu = int.Parse(dgvDiaDiem.Rows[tt].Cells[2].Value.ToString());
                            if (tour.insertCTTour(t))
                                flag = 0;
                            else
                            {
                                flag = 1;
                                MessageBox.Show("Thêm chi tiết tour thất bại");
                                break;
                            }
                        }
                        catch (Exception)
                        { }
                    }
                    if (flag == 0)
                        MessageBox.Show("Thêm chi tiết tour thành công");
                }
                //Thêm Giá Tour
                Gia g = new Gia();
                int flag1 = 0;
                if (dgvGia.RowCount == 0)
                    MessageBox.Show("Tour này chưa được thêm giá");
                for (int i = pos; i < dgvGia.RowCount - 1; i++)
                {
                    string tgbd = dgvGia.Rows[pos].Cells[1].Value.ToString();
                    //DateTime TGBD = Convert.ToDateTime(tgbd);
                    string tgkt = dgvGia.Rows[pos].Cells[2].Value.ToString();
                    //DateTime TGKT = Convert.ToDateTime(tgkt);
                    float giatour = float.Parse(dgvGia.Rows[pos].Cells[3].Value.ToString());

                    //Set data cho g
                    g.MaTour = int.Parse(tbMaTour.Text);
                    g.tgbd = tgbd;
                    g.tgkt = tgkt;
                    g.gia = giatour;

                    // insert into table Gia           
                    if (gia.insertGia(g))
                        flag1 = 0;
                    else
                    {
                        flag1 = 1;
                        MessageBox.Show("Thêm giá thứ " + pos + " thất bại");
                        break;
                    }
                }
                if (flag1 == 0)
                    MessageBox.Show("Thêm giá tour thành công");
            }
            else
                MessageBox.Show("Vui lòng thêm địa điểm và giá tour");


        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(dgvGia.RowCount >1)
            {
                int vt = vtRow3;
                dgvGia.Rows.RemoveAt(vt);
            }
            else
            {
                MessageBox.Show("Không còn giá được thêm");
            }
            
        }
        private void dgvGia_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvGia.DataSource != null && dgvGia.RowCount >1)
            {
                int VT = dgvGia.CurrentCell.RowIndex; // Lấy ra stt của row đang được chọn
                vtRow3 = VT;
                dtTGBD.Text= dgvGia.Rows[VT].Cells[1].Value.ToString();
                dtTGKT.Text = dgvGia.Rows[VT].Cells[2].Value.ToString();
                tbGia.Text= dgvGia.Rows[VT].Cells[3].Value.ToString();
                dtTGBD.Enabled = false;
                dtTGKT.Enabled = false;
            }          
        }
        private void btRemove_Click(object sender, EventArgs e)
        {            
            string message = "Bạn có chắc chắn xóa tour không?";
            string caption = "Xác nhận xóa tour";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {                
                int VT = dgvDsTour.CurrentCell.RowIndex;
                int matour = int.Parse(dgvDsTour.Rows[VT].Cells[0].Value.ToString());
                tour.deleteCTTour(matour);
                gia.deleteGiaTour(matour);
                tour.deleteTour(matour);
                dgvDsTour.Rows.RemoveAt(VT);
            }
        }

        private void tbGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbbLoaiTour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void btNhapMoiGia_Click(object sender, EventArgs e)
        {
            int matour = int.Parse(tbMaTour.Text);
            DataTable tgbd = tour.GetTGBD(matour);
            string TGBD = tgbd.Rows[0]["ThoiGianBatDau"].ToString();
            dtTGBD.Text = TGBD;
          
            dtTGKT.Enabled = true;
        }
    }    
}
