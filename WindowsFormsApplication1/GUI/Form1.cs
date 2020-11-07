using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication1.Controller;
using WindowsFormsApplication1.GUI;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }                                                               
        private void thêmTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pContraints.Controls.Clear();
            ThemTour ThemTour = new ThemTour()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            pContraints.Controls.Add(ThemTour);
            ThemTour.Show();
        }

        private void xóaSửaTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pContraints.Controls.Clear();
            DsTour dsTour = new DsTour()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            pContraints.Controls.Add(dsTour);
            dsTour.Show();
        }

        private void thêmĐoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pContraints.Controls.Clear();
            ThemDoan ThemDoan = new ThemDoan()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            pContraints.Controls.Add(ThemDoan);
            ThemDoan.Show();
        }

        private void xóaSửaĐoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pContraints.Controls.Clear();
            SuaDoan duaDoan = new SuaDoan()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            pContraints.Controls.Add(duaDoan);
            duaDoan.Show();
        }

        private void thốngKêChiPhíTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pContraints.Controls.Clear();
            ThongKeChiPhi tkcp = new ThongKeChiPhi()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            pContraints.Controls.Add(tkcp);
            tkcp.Show();
        }

        private void thốngKêSốLầnĐiTourCủaNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pContraints.Controls.Clear();
            ThongKeSLDT tkcp = new ThongKeSLDT()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            pContraints.Controls.Add(tkcp);
            tkcp.Show();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pContraints.Controls.Clear();
            ThongKeDoanhThu tkdt = new ThongKeDoanhThu()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            pContraints.Controls.Add(tkdt);
            tkdt.Show();
        }

        private void tìnhHìnhHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pContraints.Controls.Clear();
            TinhHinhTour ThTour = new TinhHinhTour()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            pContraints.Controls.Add(ThTour);
            ThTour.Show();
        }
    }
}
