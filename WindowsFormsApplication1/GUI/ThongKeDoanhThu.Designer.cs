namespace WindowsFormsApplication1.GUI
{
    partial class ThongKeDoanhThu
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
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.tbTongDoanhThu = new System.Windows.Forms.TextBox();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.btThongKe = new System.Windows.Forms.Button();
            this.cbbMaTour = new System.Windows.Forms.ComboBox();
            this.lbMaTour = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtDen);
            this.panel1.Controls.Add(this.tbTongDoanhThu);
            this.panel1.Controls.Add(this.dtTu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbThoiGian);
            this.panel1.Controls.Add(this.btThongKe);
            this.panel1.Controls.Add(this.cbbMaTour);
            this.panel1.Controls.Add(this.lbMaTour);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 102);
            this.panel1.TabIndex = 0;
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(360, 60);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(118, 20);
            this.dtDen.TabIndex = 7;
            // 
            // tbTongDoanhThu
            // 
            this.tbTongDoanhThu.Enabled = false;
            this.tbTongDoanhThu.Location = new System.Drawing.Point(697, 17);
            this.tbTongDoanhThu.Name = "tbTongDoanhThu";
            this.tbTongDoanhThu.Size = new System.Drawing.Size(121, 20);
            this.tbTongDoanhThu.TabIndex = 3;
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(236, 60);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(118, 20);
            this.dtTu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng doanh thu của tour: ";
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(153, 60);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(77, 16);
            this.lbThoiGian.TabIndex = 5;
            this.lbThoiGian.Text = "Thời gian:";
            // 
            // btThongKe
            // 
            this.btThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.Location = new System.Drawing.Point(682, 54);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(136, 28);
            this.btThongKe.TabIndex = 4;
            this.btThongKe.Text = "Thống kê ";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // cbbMaTour
            // 
            this.cbbMaTour.FormattingEnabled = true;
            this.cbbMaTour.Location = new System.Drawing.Point(236, 17);
            this.cbbMaTour.Name = "cbbMaTour";
            this.cbbMaTour.Size = new System.Drawing.Size(118, 21);
            this.cbbMaTour.TabIndex = 1;
            this.cbbMaTour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaTour_KeyPress);
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTour.Location = new System.Drawing.Point(153, 17);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(73, 16);
            this.lbMaTour.TabIndex = 0;
            this.lbMaTour.Text = "Mã Tour: ";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(0, 147);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.Size = new System.Drawing.Size(1029, 439);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1029, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thống kê doanh thu Tour";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeDoanhThu";
            this.Text = "ThongKeDoanhThu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.ComboBox cbbMaTour;
        private System.Windows.Forms.Label lbMaTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTongDoanhThu;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Label label2;
    }
}