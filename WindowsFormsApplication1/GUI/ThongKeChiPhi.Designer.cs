namespace WindowsFormsApplication1.GUI
{
    partial class ThongKeChiPhi
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
            this.lbMaTour = new System.Windows.Forms.Label();
            this.cbbMaTour = new System.Windows.Forms.ComboBox();
            this.lbMaDoan = new System.Windows.Forms.Label();
            this.cbbMaDoan = new System.Windows.Forms.ComboBox();
            this.lbTenDoan = new System.Windows.Forms.Label();
            this.tbTenDoan = new System.Windows.Forms.TextBox();
            this.lbLoaiTour = new System.Windows.Forms.Label();
            this.btThongke = new System.Windows.Forms.Button();
            this.dgvDsCp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCPDoan = new System.Windows.Forms.TextBox();
            this.tbCPKhac = new System.Windows.Forms.TextBox();
            this.lbCPKhac = new System.Windows.Forms.Label();
            this.lbCPDoan = new System.Windows.Forms.Label();
            this.tbCPTX = new System.Windows.Forms.TextBox();
            this.lbCPTX = new System.Windows.Forms.Label();
            this.tbCPAU = new System.Windows.Forms.TextBox();
            this.lbCPAU = new System.Windows.Forms.Label();
            this.tbCPKS = new System.Windows.Forms.TextBox();
            this.lbCPKS = new System.Windows.Forms.Label();
            this.tbTongCP = new System.Windows.Forms.TextBox();
            this.lbTongCP = new System.Windows.Forms.Label();
            this.tbLoaiTour = new System.Windows.Forms.TextBox();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTour.Location = new System.Drawing.Point(97, 46);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(58, 13);
            this.lbMaTour.TabIndex = 0;
            this.lbMaTour.Text = "Mã Tour:";
            // 
            // cbbMaTour
            // 
            this.cbbMaTour.FormattingEnabled = true;
            this.cbbMaTour.Location = new System.Drawing.Point(168, 43);
            this.cbbMaTour.Name = "cbbMaTour";
            this.cbbMaTour.Size = new System.Drawing.Size(92, 21);
            this.cbbMaTour.TabIndex = 1;
            this.cbbMaTour.SelectedIndexChanged += new System.EventHandler(this.cbbMaTour_SelectedIndexChanged);
            this.cbbMaTour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaTour_KeyPress);
            // 
            // lbMaDoan
            // 
            this.lbMaDoan.AutoSize = true;
            this.lbMaDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDoan.Location = new System.Drawing.Point(336, 46);
            this.lbMaDoan.Name = "lbMaDoan";
            this.lbMaDoan.Size = new System.Drawing.Size(61, 13);
            this.lbMaDoan.TabIndex = 2;
            this.lbMaDoan.Text = "Mã đoàn:";
            // 
            // cbbMaDoan
            // 
            this.cbbMaDoan.FormattingEnabled = true;
            this.cbbMaDoan.Location = new System.Drawing.Point(415, 43);
            this.cbbMaDoan.Name = "cbbMaDoan";
            this.cbbMaDoan.Size = new System.Drawing.Size(103, 21);
            this.cbbMaDoan.TabIndex = 3;
            this.cbbMaDoan.SelectedIndexChanged += new System.EventHandler(this.cbbMaDoan_SelectedIndexChanged);
            this.cbbMaDoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaDoan_KeyPress);
            // 
            // lbTenDoan
            // 
            this.lbTenDoan.AutoSize = true;
            this.lbTenDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDoan.Location = new System.Drawing.Point(336, 84);
            this.lbTenDoan.Name = "lbTenDoan";
            this.lbTenDoan.Size = new System.Drawing.Size(66, 13);
            this.lbTenDoan.TabIndex = 4;
            this.lbTenDoan.Text = "Tên đoàn:";
            // 
            // tbTenDoan
            // 
            this.tbTenDoan.Enabled = false;
            this.tbTenDoan.Location = new System.Drawing.Point(415, 80);
            this.tbTenDoan.Name = "tbTenDoan";
            this.tbTenDoan.Size = new System.Drawing.Size(122, 20);
            this.tbTenDoan.TabIndex = 5;
            // 
            // lbLoaiTour
            // 
            this.lbLoaiTour.AutoSize = true;
            this.lbLoaiTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiTour.Location = new System.Drawing.Point(97, 80);
            this.lbLoaiTour.Name = "lbLoaiTour";
            this.lbLoaiTour.Size = new System.Drawing.Size(65, 13);
            this.lbLoaiTour.TabIndex = 6;
            this.lbLoaiTour.Text = "Loại Tour:";
            // 
            // btThongke
            // 
            this.btThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongke.Location = new System.Drawing.Point(667, 80);
            this.btThongke.Name = "btThongke";
            this.btThongke.Size = new System.Drawing.Size(120, 35);
            this.btThongke.TabIndex = 8;
            this.btThongke.Text = "Thống kê";
            this.btThongke.UseVisualStyleBackColor = true;
            this.btThongke.Click += new System.EventHandler(this.btThongke_Click);
            // 
            // dgvDsCp
            // 
            this.dgvDsCp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsCp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsCp.Location = new System.Drawing.Point(4, 132);
            this.dgvDsCp.Name = "dgvDsCp";
            this.dgvDsCp.Size = new System.Drawing.Size(1014, 287);
            this.dgvDsCp.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCPDoan);
            this.panel1.Controls.Add(this.tbCPKhac);
            this.panel1.Controls.Add(this.lbCPKhac);
            this.panel1.Controls.Add(this.lbCPDoan);
            this.panel1.Controls.Add(this.tbCPTX);
            this.panel1.Controls.Add(this.lbCPTX);
            this.panel1.Controls.Add(this.tbCPAU);
            this.panel1.Controls.Add(this.lbCPAU);
            this.panel1.Controls.Add(this.tbCPKS);
            this.panel1.Controls.Add(this.lbCPKS);
            this.panel1.Controls.Add(this.tbTongCP);
            this.panel1.Controls.Add(this.lbTongCP);
            this.panel1.Location = new System.Drawing.Point(4, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 168);
            this.panel1.TabIndex = 10;
            // 
            // tbCPDoan
            // 
            this.tbCPDoan.Enabled = false;
            this.tbCPDoan.Location = new System.Drawing.Point(731, 30);
            this.tbCPDoan.Name = "tbCPDoan";
            this.tbCPDoan.Size = new System.Drawing.Size(149, 20);
            this.tbCPDoan.TabIndex = 12;
            // 
            // tbCPKhac
            // 
            this.tbCPKhac.Enabled = false;
            this.tbCPKhac.Location = new System.Drawing.Point(731, 82);
            this.tbCPKhac.Name = "tbCPKhac";
            this.tbCPKhac.Size = new System.Drawing.Size(149, 20);
            this.tbCPKhac.TabIndex = 11;
            // 
            // lbCPKhac
            // 
            this.lbCPKhac.AutoSize = true;
            this.lbCPKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPKhac.Location = new System.Drawing.Point(576, 86);
            this.lbCPKhac.Name = "lbCPKhac";
            this.lbCPKhac.Size = new System.Drawing.Size(134, 16);
            this.lbCPKhac.TabIndex = 10;
            this.lbCPKhac.Text = "Tổng chi phí khác:";
            // 
            // lbCPDoan
            // 
            this.lbCPDoan.AutoSize = true;
            this.lbCPDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPDoan.Location = new System.Drawing.Point(574, 34);
            this.lbCPDoan.Name = "lbCPDoan";
            this.lbCPDoan.Size = new System.Drawing.Size(136, 16);
            this.lbCPDoan.TabIndex = 8;
            this.lbCPDoan.Text = "Tổng chi phí đoàn:";
            // 
            // tbCPTX
            // 
            this.tbCPTX.Enabled = false;
            this.tbCPTX.Location = new System.Drawing.Point(731, 120);
            this.tbCPTX.Name = "tbCPTX";
            this.tbCPTX.Size = new System.Drawing.Size(149, 20);
            this.tbCPTX.TabIndex = 7;
            // 
            // lbCPTX
            // 
            this.lbCPTX.AutoSize = true;
            this.lbCPTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPTX.Location = new System.Drawing.Point(563, 124);
            this.lbCPTX.Name = "lbCPTX";
            this.lbCPTX.Size = new System.Drawing.Size(150, 16);
            this.lbCPTX.TabIndex = 6;
            this.lbCPTX.Text = "Tổng chi phí thuê xe:";
            // 
            // tbCPAU
            // 
            this.tbCPAU.Enabled = false;
            this.tbCPAU.Location = new System.Drawing.Point(277, 124);
            this.tbCPAU.Name = "tbCPAU";
            this.tbCPAU.Size = new System.Drawing.Size(140, 20);
            this.tbCPAU.TabIndex = 5;
            // 
            // lbCPAU
            // 
            this.lbCPAU.AutoSize = true;
            this.lbCPAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPAU.Location = new System.Drawing.Point(100, 128);
            this.lbCPAU.Name = "lbCPAU";
            this.lbCPAU.Size = new System.Drawing.Size(156, 16);
            this.lbCPAU.TabIndex = 4;
            this.lbCPAU.Text = "Tổng chi phí ăn uống:";
            // 
            // tbCPKS
            // 
            this.tbCPKS.Enabled = false;
            this.tbCPKS.Location = new System.Drawing.Point(277, 86);
            this.tbCPKS.Name = "tbCPKS";
            this.tbCPKS.Size = new System.Drawing.Size(140, 20);
            this.tbCPKS.TabIndex = 3;
            // 
            // lbCPKS
            // 
            this.lbCPKS.AutoSize = true;
            this.lbCPKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPKS.Location = new System.Drawing.Point(85, 86);
            this.lbCPKS.Name = "lbCPKS";
            this.lbCPKS.Size = new System.Drawing.Size(171, 16);
            this.lbCPKS.TabIndex = 2;
            this.lbCPKS.Text = "Tổng chi phí khách sạn:";
            // 
            // tbTongCP
            // 
            this.tbTongCP.Enabled = false;
            this.tbTongCP.Location = new System.Drawing.Point(277, 30);
            this.tbTongCP.Name = "tbTongCP";
            this.tbTongCP.Size = new System.Drawing.Size(140, 20);
            this.tbTongCP.TabIndex = 1;
            // 
            // lbTongCP
            // 
            this.lbTongCP.AutoSize = true;
            this.lbTongCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongCP.Location = new System.Drawing.Point(100, 34);
            this.lbTongCP.Name = "lbTongCP";
            this.lbTongCP.Size = new System.Drawing.Size(156, 16);
            this.lbTongCP.TabIndex = 0;
            this.lbTongCP.Text = "Tổng chi phí của tour:";
            // 
            // tbLoaiTour
            // 
            this.tbLoaiTour.Enabled = false;
            this.tbLoaiTour.Location = new System.Drawing.Point(168, 77);
            this.tbLoaiTour.Name = "tbLoaiTour";
            this.tbLoaiTour.Size = new System.Drawing.Size(120, 20);
            this.tbLoaiTour.TabIndex = 11;
            // 
            // dtTu
            // 
            this.dtTu.CustomFormat = "dd - MM - yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(650, 44);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(92, 20);
            this.dtTu.TabIndex = 12;
            // 
            // dtDen
            // 
            this.dtDen.CustomFormat = "dd-MM-yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(748, 44);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(93, 20);
            this.dtDen.TabIndex = 13;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(580, 46);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(64, 13);
            this.lbThoiGian.TabIndex = 14;
            this.lbThoiGian.Text = "Thời gian:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(-3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thống kê chi phí của Tour";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThongKeChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.tbLoaiTour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDsCp);
            this.Controls.Add(this.btThongke);
            this.Controls.Add(this.lbLoaiTour);
            this.Controls.Add(this.tbTenDoan);
            this.Controls.Add(this.lbTenDoan);
            this.Controls.Add(this.cbbMaDoan);
            this.Controls.Add(this.lbMaDoan);
            this.Controls.Add(this.cbbMaTour);
            this.Controls.Add(this.lbMaTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeChiPhi";
            this.Text = "ThongKeChiPhi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaTour;
        private System.Windows.Forms.ComboBox cbbMaTour;
        private System.Windows.Forms.Label lbMaDoan;
        private System.Windows.Forms.ComboBox cbbMaDoan;
        private System.Windows.Forms.Label lbTenDoan;
        private System.Windows.Forms.TextBox tbTenDoan;
        private System.Windows.Forms.Label lbLoaiTour;
        private System.Windows.Forms.Button btThongke;
        private System.Windows.Forms.DataGridView dgvDsCp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTongCP;
        private System.Windows.Forms.TextBox tbTongCP;
        private System.Windows.Forms.Label lbCPDoan;
        private System.Windows.Forms.TextBox tbCPTX;
        private System.Windows.Forms.Label lbCPTX;
        private System.Windows.Forms.TextBox tbCPAU;
        private System.Windows.Forms.Label lbCPAU;
        private System.Windows.Forms.TextBox tbCPKS;
        private System.Windows.Forms.Label lbCPKS;
        private System.Windows.Forms.TextBox tbCPKhac;
        private System.Windows.Forms.Label lbCPKhac;
        private System.Windows.Forms.TextBox tbLoaiTour;
        private System.Windows.Forms.TextBox tbCPDoan;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Label label1;
    }
}