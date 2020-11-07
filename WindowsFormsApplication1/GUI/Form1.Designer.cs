namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pContraints = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýTourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSửaTourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐoànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmĐoànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSửaĐoànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêChiPhíTourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSốLầnĐiTourCủaNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìnhHìnhHoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContraints
            // 
            this.pContraints.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.trip11;
            this.pContraints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContraints.Location = new System.Drawing.Point(3, 31);
            this.pContraints.Name = "pContraints";
            this.pContraints.Size = new System.Drawing.Size(1030, 607);
            this.pContraints.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 26);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTourToolStripMenuItem,
            this.quảnLýĐoànToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýTourToolStripMenuItem
            // 
            this.quảnLýTourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmTourToolStripMenuItem,
            this.xóaSửaTourToolStripMenuItem});
            this.quảnLýTourToolStripMenuItem.Name = "quảnLýTourToolStripMenuItem";
            this.quảnLýTourToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.quảnLýTourToolStripMenuItem.Text = "Quản lý Tour";
            // 
            // thêmTourToolStripMenuItem
            // 
            this.thêmTourToolStripMenuItem.Name = "thêmTourToolStripMenuItem";
            this.thêmTourToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.thêmTourToolStripMenuItem.Text = "Thêm Tour";
            this.thêmTourToolStripMenuItem.Click += new System.EventHandler(this.thêmTourToolStripMenuItem_Click);
            // 
            // xóaSửaTourToolStripMenuItem
            // 
            this.xóaSửaTourToolStripMenuItem.Name = "xóaSửaTourToolStripMenuItem";
            this.xóaSửaTourToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.xóaSửaTourToolStripMenuItem.Text = "Xóa/Sửa Tour";
            this.xóaSửaTourToolStripMenuItem.Click += new System.EventHandler(this.xóaSửaTourToolStripMenuItem_Click);
            // 
            // quảnLýĐoànToolStripMenuItem
            // 
            this.quảnLýĐoànToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmĐoànToolStripMenuItem,
            this.xóaSửaĐoànToolStripMenuItem});
            this.quảnLýĐoànToolStripMenuItem.Name = "quảnLýĐoànToolStripMenuItem";
            this.quảnLýĐoànToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.quảnLýĐoànToolStripMenuItem.Text = "Quản lý Đoàn";
            // 
            // thêmĐoànToolStripMenuItem
            // 
            this.thêmĐoànToolStripMenuItem.Name = "thêmĐoànToolStripMenuItem";
            this.thêmĐoànToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.thêmĐoànToolStripMenuItem.Text = "Thêm đoàn";
            this.thêmĐoànToolStripMenuItem.Click += new System.EventHandler(this.thêmĐoànToolStripMenuItem_Click);
            // 
            // xóaSửaĐoànToolStripMenuItem
            // 
            this.xóaSửaĐoànToolStripMenuItem.Name = "xóaSửaĐoànToolStripMenuItem";
            this.xóaSửaĐoànToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.xóaSửaĐoànToolStripMenuItem.Text = "Xóa/Sửa đoàn";
            this.xóaSửaĐoànToolStripMenuItem.Click += new System.EventHandler(this.xóaSửaĐoànToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêChiPhíTourToolStripMenuItem,
            this.thốngKêSốLầnĐiTourCủaNVToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem,
            this.tìnhHìnhHoạtĐộngToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thốngKêChiPhíTourToolStripMenuItem
            // 
            this.thốngKêChiPhíTourToolStripMenuItem.Name = "thốngKêChiPhíTourToolStripMenuItem";
            this.thốngKêChiPhíTourToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.thốngKêChiPhíTourToolStripMenuItem.Text = "Thống kê chi phí tour";
            this.thốngKêChiPhíTourToolStripMenuItem.Click += new System.EventHandler(this.thốngKêChiPhíTourToolStripMenuItem_Click);
            // 
            // thốngKêSốLầnĐiTourCủaNVToolStripMenuItem
            // 
            this.thốngKêSốLầnĐiTourCủaNVToolStripMenuItem.Name = "thốngKêSốLầnĐiTourCủaNVToolStripMenuItem";
            this.thốngKêSốLầnĐiTourCủaNVToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.thốngKêSốLầnĐiTourCủaNVToolStripMenuItem.Text = "Thống kê số lần đi tour của NV";
            this.thốngKêSốLầnĐiTourCủaNVToolStripMenuItem.Click += new System.EventHandler(this.thốngKêSốLầnĐiTourCủaNVToolStripMenuItem_Click);
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê doanh thu";
            this.thốngKêDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.thốngKêDoanhThuToolStripMenuItem_Click);
            // 
            // tìnhHìnhHoạtĐộngToolStripMenuItem
            // 
            this.tìnhHìnhHoạtĐộngToolStripMenuItem.Name = "tìnhHìnhHoạtĐộngToolStripMenuItem";
            this.tìnhHìnhHoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.tìnhHìnhHoạtĐộngToolStripMenuItem.Text = "Tình hình hoạt động";
            this.tìnhHìnhHoạtĐộngToolStripMenuItem.Click += new System.EventHandler(this.tìnhHìnhHoạtĐộngToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pContraints);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Việt Travel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pContraints;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSửaTourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐoànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmĐoànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSửaĐoànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêChiPhíTourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSốLầnĐiTourCủaNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìnhHìnhHoạtĐộngToolStripMenuItem;
    }
}

