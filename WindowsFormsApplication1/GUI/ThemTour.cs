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
    public partial class ThemTour : Form
    {
        TourBLL tour;
        DiaDiemBLL ddBLL;
        GiaBLL giaBLL;
        public int vtRow1;
        public int vtRow2;
        public int vtRow3;
        public int pos = 0;
        public ThemTour()
        {
            InitializeComponent();
            tour = new TourBLL();
            ddBLL = new DiaDiemBLL();
            giaBLL = new GiaBLL();
            LoadLoaiTour();
            showAllDD();
            dgvGia.ReadOnly = true;
            GridViewDD2.ReadOnly = true;
        }           
        public void showAllDD()
        {
            DataTable tb = ddBLL.GetAllDiaDiem();
            GridViewDiaDiem.DataSource = tb;
            DataTable table = tour.geMaTour();
            tbMaTour.Text = (int.Parse(table.Rows[pos]["MaTour"].ToString()) + 1).ToString();
        }
        public void LoadLoaiTour()
        {
            DataTable tb = tour.LoadLoaiTour();
            cbb_LoaiTour.DataSource = tb;
            cbb_LoaiTour.DisplayMember = "LoaiTour";
            cbb_LoaiTour.ValueMember = "Id";
        }

        private void btChon_Click(object sender, EventArgs e)
        {
                int vt = vtRow1;
                GridViewDD2.Rows.Add(GridViewDiaDiem.Rows[vt].Cells[0].Value.ToString(), GridViewDiaDiem.Rows[vt].Cells[1].Value.ToString());                        
        }

        private void bt_BoChon_Click(object sender, EventArgs e)
        {

            if (GridViewDD2.RowCount > 1)
            {
                int vt = vtRow2;
                GridViewDD2.Rows.RemoveAt(vt);
            }
            else
                MessageBox.Show("Không còn địa điểm được chọn");
        }

        private void GridViewDD2_MouseClick(object sender, MouseEventArgs e)
        {
            if(GridViewDD2.DataSource != null && GridViewDD2.RowCount > 1)
            {
                int VT = GridViewDD2.CurrentCell.RowIndex; // Lấy ra stt của row đang được chọn
                vtRow2 = VT;
            }           
        }

        private void GridViewDiaDiem_Click(object sender, EventArgs e)
        {
            int VT = GridViewDiaDiem.CurrentRow.Index;
            vtRow1 = VT;

        }
        public bool ValiateTime()
        {
            string tgbd = dtTGBD.Text;
            string tgkg = dtTGKT.Text;
            DateTime TGBD = DateTime.Parse(tgbd);
            DateTime TGKT = DateTime.Parse(tgkg);
            if (TGBD > TGKT)
                return false;
            return true;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (Validate() == false)
                MessageBox.Show("Vui lòng thêm địa điểm tour và giá tour và tên tour");
            else
            {
                //Thêm Tour
                Tour t = new Tour();
                string MaTour = tbMaTour.Text;
                string TenTour = tbTenTour.Text;
                t.MaTour = int.Parse(tbMaTour.Text);
                t.TenTour = tbTenTour.Text;
                t.MaLoaiTour = cbb_LoaiTour.SelectedIndex + 1;
                if (tour.insertTour(t))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
                //Thêm Chi Tiết tour
                int flag = 0;
                if (GridViewDD2.RowCount == 0)
                    MessageBox.Show("Không thêm chi tiết tour");
                else
                {
                    for (int tt = 0; tt < GridViewDiaDiem.RowCount - 1; tt++)
                    {
                        try
                        {
                            string mdd = GridViewDD2.Rows[tt].Cells[0].Value.ToString();
                            t.MaDiaDiem = mdd;
                            t.thutu = tt + 1;
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
                    float gia = float.Parse(dgvGia.Rows[pos].Cells[3].Value.ToString());

                    //Set data cho g
                    g.MaTour = int.Parse(tbMaTour.Text);
                    g.tgbd = tgbd;
                    g.tgkt = tgkt;
                    g.gia = gia;

                    // insert into table Gia           
                    if (giaBLL.insertGia(g))
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
        }
        private void btThemGia_Click(object sender, EventArgs e)
        {
            if (ValiateTime() == false)
                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc");
            else if (tbGia.Text.Equals(""))
                MessageBox.Show("Vui lòng nhập giá");
            else
            {
                Tour t = new Tour();
                string tgbd = dtTGBD.Value.ToString("yyyy/MM/dd");
                string tgkt = dtTGKT.Value.ToString("yyyy/MM/dd");
                DateTime TGBD = Convert.ToDateTime(tgbd);
                DateTime TGKT = Convert.ToDateTime(tgkt);
                t.MaTour = int.Parse(tbMaTour.Text);
                float gia = float.Parse(tbGia.Text);
                dgvGia.Rows.Add(t.MaTour, tgbd, tgkt, gia);
            }
        }
        public bool Validate()
        {
            if (dgvGia.RowCount < 2 || GridViewDD2.RowCount < 2 || tbTenTour.Text.Equals(""))
                return false;
            return true;
        }

        private void btXoaGia_Click(object sender, EventArgs e)
        {
            if (dgvGia.RowCount > 1)
            {
                int vt = vtRow3;
                dgvGia.Rows.RemoveAt(vt);
            }
            else
                MessageBox.Show("Không còn giá được thêm");
        }

        private void dgvGia_Click(object sender, EventArgs e)
        {
            if(dgvGia.DataSource != null && dgvGia.RowCount >1)
            {
                int VT = dgvGia.CurrentCell.RowIndex; // Lấy ra stt của row đang được chọn
                vtRow3 = VT;
            }           
        }

        private void tbMaTour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbb_LoaiTour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }
    }
}
