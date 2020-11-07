namespace WindowsFormsApplication1.GUI
{
    partial class ThongKeSLDT
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
            this.pThongTin = new System.Windows.Forms.Panel();
            this.btThongKe = new System.Windows.Forms.Button();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.dgvDsLan = new System.Windows.Forms.DataGridView();
            this.lbTSTour = new System.Windows.Forms.Label();
            this.tbSLDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTaiXe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCSKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLan)).BeginInit();
            this.SuspendLayout();
            // 
            // pThongTin
            // 
            this.pThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pThongTin.Controls.Add(this.btThongKe);
            this.pThongTin.Controls.Add(this.dtDen);
            this.pThongTin.Controls.Add(this.dtTu);
            this.pThongTin.Controls.Add(this.lbThoiGian);
            this.pThongTin.Controls.Add(this.tbHoTen);
            this.pThongTin.Controls.Add(this.lbHoTen);
            this.pThongTin.Controls.Add(this.cbbMaNV);
            this.pThongTin.Controls.Add(this.lbMaNV);
            this.pThongTin.Location = new System.Drawing.Point(4, 34);
            this.pThongTin.Name = "pThongTin";
            this.pThongTin.Size = new System.Drawing.Size(1025, 58);
            this.pThongTin.TabIndex = 0;
            // 
            // btThongKe
            // 
            this.btThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.Location = new System.Drawing.Point(884, 8);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(116, 36);
            this.btThongKe.TabIndex = 7;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // dtDen
            // 
            this.dtDen.CustomFormat = "dd-MM-yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(743, 18);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(112, 20);
            this.dtDen.TabIndex = 6;
            // 
            // dtTu
            // 
            this.dtTu.CustomFormat = "yyyy-MM-dd";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(635, 18);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(102, 20);
            this.dtTu.TabIndex = 5;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(552, 21);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(77, 16);
            this.lbThoiGian.TabIndex = 4;
            this.lbThoiGian.Text = "Thời gian:";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Enabled = false;
            this.tbHoTen.Location = new System.Drawing.Point(385, 17);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(136, 20);
            this.tbHoTen.TabIndex = 3;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(322, 17);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(57, 16);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "Họ tên:";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(166, 16);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(136, 21);
            this.cbbMaNV.TabIndex = 1;
            this.cbbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbbMaNV_SelectedIndexChanged);
            this.cbbMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaNV_KeyPress);
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(102, 16);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(58, 16);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã NV:";
            // 
            // dgvDsLan
            // 
            this.dgvDsLan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsLan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsLan.Location = new System.Drawing.Point(4, 98);
            this.dgvDsLan.Name = "dgvDsLan";
            this.dgvDsLan.Size = new System.Drawing.Size(1029, 380);
            this.dgvDsLan.TabIndex = 2;
            // 
            // lbTSTour
            // 
            this.lbTSTour.AutoSize = true;
            this.lbTSTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTSTour.Location = new System.Drawing.Point(164, 498);
            this.lbTSTour.Name = "lbTSTour";
            this.lbTSTour.Size = new System.Drawing.Size(141, 16);
            this.lbTSTour.TabIndex = 3;
            this.lbTSTour.Text = "Tổng số lần đi tour:";
            // 
            // tbSLDT
            // 
            this.tbSLDT.Enabled = false;
            this.tbSLDT.Location = new System.Drawing.Point(326, 494);
            this.tbSLDT.Name = "tbSLDT";
            this.tbSLDT.Size = new System.Drawing.Size(91, 20);
            this.tbSLDT.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hướng dẫn viên du lịch:";
            // 
            // tbHDV
            // 
            this.tbHDV.Enabled = false;
            this.tbHDV.Location = new System.Drawing.Point(326, 545);
            this.tbHDV.Name = "tbHDV";
            this.tbHDV.Size = new System.Drawing.Size(91, 20);
            this.tbHDV.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tài xế:";
            // 
            // tbTaiXe
            // 
            this.tbTaiXe.Enabled = false;
            this.tbTaiXe.Location = new System.Drawing.Point(707, 494);
            this.tbTaiXe.Name = "tbTaiXe";
            this.tbTaiXe.Size = new System.Drawing.Size(100, 20);
            this.tbTaiXe.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chăm sóc khách hàng:";
            // 
            // tbCSKH
            // 
            this.tbCSKH.Enabled = false;
            this.tbCSKH.Location = new System.Drawing.Point(707, 545);
            this.tbCSKH.Name = "tbCSKH";
            this.tbCSKH.Size = new System.Drawing.Size(100, 20);
            this.tbCSKH.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Indigo;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1029, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thống kê số lần tham gia Tour của nhân viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThongKeSLDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCSKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTaiXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSLDT);
            this.Controls.Add(this.lbTSTour);
            this.Controls.Add(this.dgvDsLan);
            this.Controls.Add(this.pThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeSLDT";
            this.Text = "ThongKeSLDT";
            this.pThongTin.ResumeLayout(false);
            this.pThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pThongTin;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.DataGridView dgvDsLan;
        private System.Windows.Forms.Label lbTSTour;
        private System.Windows.Forms.TextBox tbSLDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTaiXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCSKH;
        private System.Windows.Forms.Label label4;
    }
}