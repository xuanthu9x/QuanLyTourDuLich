namespace WindowsFormsApplication1.GUI
{
    partial class TinhHinhTour
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bbThongKe = new System.Windows.Forms.Button();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.cbbMaTour = new System.Windows.Forms.ComboBox();
            this.lbMaTour = new System.Windows.Forms.Label();
            this.dgvTinhHinhTour = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSoTourDaiNgay = new System.Windows.Forms.TextBox();
            this.tbSoTourNganNgay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDoanhThu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoKhach = new System.Windows.Forms.TextBox();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.tbSoDoan = new System.Windows.Forms.TextBox();
            this.lbSoDoan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhHinhTour)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bbThongKe);
            this.panel1.Controls.Add(this.dtDen);
            this.panel1.Controls.Add(this.dtTu);
            this.panel1.Controls.Add(this.lbThoiGian);
            this.panel1.Controls.Add(this.cbbMaTour);
            this.panel1.Controls.Add(this.lbMaTour);
            this.panel1.Location = new System.Drawing.Point(1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 62);
            this.panel1.TabIndex = 0;
            // 
            // bbThongKe
            // 
            this.bbThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbThongKe.Location = new System.Drawing.Point(719, 11);
            this.bbThongKe.Name = "bbThongKe";
            this.bbThongKe.Size = new System.Drawing.Size(93, 34);
            this.bbThongKe.TabIndex = 5;
            this.bbThongKe.Text = "Thống kê";
            this.bbThongKe.UseVisualStyleBackColor = true;
            this.bbThongKe.Click += new System.EventHandler(this.bbThongKe_Click);
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(574, 17);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(109, 20);
            this.dtDen.TabIndex = 4;
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(441, 17);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(109, 20);
            this.dtTu.TabIndex = 3;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(348, 20);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(81, 16);
            this.lbThoiGian.TabIndex = 2;
            this.lbThoiGian.Text = "Thời gian: ";
            // 
            // cbbMaTour
            // 
            this.cbbMaTour.FormattingEnabled = true;
            this.cbbMaTour.Location = new System.Drawing.Point(198, 15);
            this.cbbMaTour.Name = "cbbMaTour";
            this.cbbMaTour.Size = new System.Drawing.Size(121, 21);
            this.cbbMaTour.TabIndex = 1;
            this.cbbMaTour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaTour_KeyPress);
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTour.Location = new System.Drawing.Point(129, 15);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(63, 16);
            this.lbMaTour.TabIndex = 0;
            this.lbMaTour.Text = "Mã tour:";
            // 
            // dgvTinhHinhTour
            // 
            this.dgvTinhHinhTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhHinhTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhHinhTour.Location = new System.Drawing.Point(1, 104);
            this.dgvTinhHinhTour.Name = "dgvTinhHinhTour";
            this.dgvTinhHinhTour.Size = new System.Drawing.Size(1029, 365);
            this.dgvTinhHinhTour.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbSoTourDaiNgay);
            this.panel2.Controls.Add(this.tbSoTourNganNgay);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbDoanhThu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbSoKhach);
            this.panel2.Controls.Add(this.lbKhachHang);
            this.panel2.Controls.Add(this.tbSoDoan);
            this.panel2.Controls.Add(this.lbSoDoan);
            this.panel2.Location = new System.Drawing.Point(1, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 124);
            this.panel2.TabIndex = 2;
            // 
            // tbSoTourDaiNgay
            // 
            this.tbSoTourDaiNgay.Location = new System.Drawing.Point(642, 62);
            this.tbSoTourDaiNgay.Name = "tbSoTourDaiNgay";
            this.tbSoTourDaiNgay.ReadOnly = true;
            this.tbSoTourDaiNgay.Size = new System.Drawing.Size(138, 20);
            this.tbSoTourDaiNgay.TabIndex = 9;
            // 
            // tbSoTourNganNgay
            // 
            this.tbSoTourNganNgay.Location = new System.Drawing.Point(642, 22);
            this.tbSoTourNganNgay.Name = "tbSoTourNganNgay";
            this.tbSoTourNganNgay.ReadOnly = true;
            this.tbSoTourNganNgay.Size = new System.Drawing.Size(138, 20);
            this.tbSoTourNganNgay.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số tour dài ngày: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số tour trong ngày: ";
            // 
            // tbDoanhThu
            // 
            this.tbDoanhThu.Location = new System.Drawing.Point(288, 97);
            this.tbDoanhThu.Name = "tbDoanhThu";
            this.tbDoanhThu.ReadOnly = true;
            this.tbDoanhThu.Size = new System.Drawing.Size(141, 20);
            this.tbDoanhThu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doanh thu:";
            // 
            // tbSoKhach
            // 
            this.tbSoKhach.Location = new System.Drawing.Point(288, 58);
            this.tbSoKhach.Name = "tbSoKhach";
            this.tbSoKhach.ReadOnly = true;
            this.tbSoKhach.Size = new System.Drawing.Size(141, 20);
            this.tbSoKhach.TabIndex = 3;
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.Location = new System.Drawing.Point(182, 62);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(81, 16);
            this.lbKhachHang.TabIndex = 2;
            this.lbKhachHang.Text = "Số Khách: ";
            // 
            // tbSoDoan
            // 
            this.tbSoDoan.Location = new System.Drawing.Point(288, 18);
            this.tbSoDoan.Name = "tbSoDoan";
            this.tbSoDoan.ReadOnly = true;
            this.tbSoDoan.Size = new System.Drawing.Size(141, 20);
            this.tbSoDoan.TabIndex = 1;
            // 
            // lbSoDoan
            // 
            this.lbSoDoan.AutoSize = true;
            this.lbSoDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDoan.Location = new System.Drawing.Point(182, 18);
            this.lbSoDoan.Name = "lbSoDoan";
            this.lbSoDoan.Size = new System.Drawing.Size(70, 16);
            this.lbSoDoan.TabIndex = 0;
            this.lbSoDoan.Text = "Số đoàn:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Indigo;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1029, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tình hình hoạt động của Tour";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TinhHinhTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTinhHinhTour);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TinhHinhTour";
            this.Text = "TinhHinhTour";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhHinhTour)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bbThongKe;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.ComboBox cbbMaTour;
        private System.Windows.Forms.Label lbMaTour;
        private System.Windows.Forms.DataGridView dgvTinhHinhTour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSoTourDaiNgay;
        private System.Windows.Forms.TextBox tbSoTourNganNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoKhach;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.TextBox tbSoDoan;
        private System.Windows.Forms.Label lbSoDoan;
        private System.Windows.Forms.Label label4;
    }
}