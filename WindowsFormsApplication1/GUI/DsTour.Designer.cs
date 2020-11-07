namespace WindowsFormsApplication1
{
    partial class DsTour
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
            this.btBoChon = new System.Windows.Forms.Button();
            this.btChon = new System.Windows.Forms.Button();
            this.dgvDiaDiem1 = new System.Windows.Forms.DataGridView();
            this.dgvDiaDiem = new System.Windows.Forms.DataGridView();
            this.dgvDsTour = new System.Windows.Forms.DataGridView();
            this.pContrains = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.dtTGKT = new System.Windows.Forms.DateTimePicker();
            this.dtTGBD = new System.Windows.Forms.DateTimePicker();
            this.lb = new System.Windows.Forms.Label();
            this.lbTGKT = new System.Windows.Forms.Label();
            this.lbTGBD = new System.Windows.Forms.Label();
            this.dgvGia = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btRemove = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.cbbLoaiTour = new System.Windows.Forms.ComboBox();
            this.tbTenTour = new System.Windows.Forms.TextBox();
            this.tbMaTour = new System.Windows.Forms.TextBox();
            this.lbLoaiTour = new System.Windows.Forms.Label();
            this.lbTenTour = new System.Windows.Forms.Label();
            this.lbMaTour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btNhapMoiGia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDiem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTour)).BeginInit();
            this.pContrains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btBoChon);
            this.panel1.Controls.Add(this.btChon);
            this.panel1.Controls.Add(this.dgvDiaDiem1);
            this.panel1.Controls.Add(this.dgvDiaDiem);
            this.panel1.Location = new System.Drawing.Point(4, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 184);
            this.panel1.TabIndex = 0;
            // 
            // btBoChon
            // 
            this.btBoChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBoChon.Location = new System.Drawing.Point(445, 104);
            this.btBoChon.Name = "btBoChon";
            this.btBoChon.Size = new System.Drawing.Size(75, 23);
            this.btBoChon.TabIndex = 3;
            this.btBoChon.Text = "Bỏ chọn";
            this.btBoChon.UseVisualStyleBackColor = true;
            this.btBoChon.Click += new System.EventHandler(this.btBoChon_Click);
            // 
            // btChon
            // 
            this.btChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChon.Location = new System.Drawing.Point(445, 37);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 23);
            this.btChon.TabIndex = 2;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // dgvDiaDiem1
            // 
            this.dgvDiaDiem1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiaDiem1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaDiem1.Location = new System.Drawing.Point(62, 3);
            this.dgvDiaDiem1.Name = "dgvDiaDiem1";
            this.dgvDiaDiem1.Size = new System.Drawing.Size(328, 162);
            this.dgvDiaDiem1.TabIndex = 1;
            this.dgvDiaDiem1.Click += new System.EventHandler(this.dgvDiaDiem1_Click);
            // 
            // dgvDiaDiem
            // 
            this.dgvDiaDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaDiem.Location = new System.Drawing.Point(591, 3);
            this.dgvDiaDiem.Name = "dgvDiaDiem";
            this.dgvDiaDiem.Size = new System.Drawing.Size(367, 162);
            this.dgvDiaDiem.TabIndex = 0;
            this.dgvDiaDiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDiaDiem_MouseClick);
            // 
            // dgvDsTour
            // 
            this.dgvDsTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsTour.EnableHeadersVisualStyles = false;
            this.dgvDsTour.Location = new System.Drawing.Point(502, 3);
            this.dgvDsTour.Name = "dgvDsTour";
            this.dgvDsTour.Size = new System.Drawing.Size(458, 162);
            this.dgvDsTour.TabIndex = 1;
            this.dgvDsTour.Click += new System.EventHandler(this.dgvDsTour_Click);
            // 
            // pContrains
            // 
            this.pContrains.Controls.Add(this.btNhapMoiGia);
            this.pContrains.Controls.Add(this.btXoa);
            this.pContrains.Controls.Add(this.btThem);
            this.pContrains.Controls.Add(this.tbGia);
            this.pContrains.Controls.Add(this.dtTGKT);
            this.pContrains.Controls.Add(this.dtTGBD);
            this.pContrains.Controls.Add(this.lb);
            this.pContrains.Controls.Add(this.lbTGKT);
            this.pContrains.Controls.Add(this.lbTGBD);
            this.pContrains.Controls.Add(this.dgvGia);
            this.pContrains.Location = new System.Drawing.Point(4, 399);
            this.pContrains.Name = "pContrains";
            this.pContrains.Size = new System.Drawing.Size(1022, 194);
            this.pContrains.TabIndex = 2;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(284, 135);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(169, 135);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(169, 100);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(100, 20);
            this.tbGia.TabIndex = 7;
            this.tbGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGia_KeyPress);
            // 
            // dtTGKT
            // 
            this.dtTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTGKT.Location = new System.Drawing.Point(169, 61);
            this.dtTGKT.Name = "dtTGKT";
            this.dtTGKT.Size = new System.Drawing.Size(200, 20);
            this.dtTGKT.TabIndex = 6;
            // 
            // dtTGBD
            // 
            this.dtTGBD.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtTGBD.Enabled = false;
            this.dtTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTGBD.Location = new System.Drawing.Point(169, 23);
            this.dtTGBD.Name = "dtTGBD";
            this.dtTGBD.Size = new System.Drawing.Size(200, 20);
            this.dtTGBD.TabIndex = 5;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(109, 100);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(34, 13);
            this.lb.TabIndex = 4;
            this.lb.Text = "Giá: ";
            // 
            // lbTGKT
            // 
            this.lbTGKT.AutoSize = true;
            this.lbTGKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGKT.Location = new System.Drawing.Point(27, 61);
            this.lbTGKT.Name = "lbTGKT";
            this.lbTGKT.Size = new System.Drawing.Size(119, 13);
            this.lbTGKT.TabIndex = 3;
            this.lbTGKT.Text = "Thời gian kết thúc: ";
            // 
            // lbTGBD
            // 
            this.lbTGBD.AutoSize = true;
            this.lbTGBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGBD.Location = new System.Drawing.Point(27, 23);
            this.lbTGBD.Name = "lbTGBD";
            this.lbTGBD.Size = new System.Drawing.Size(116, 13);
            this.lbTGBD.TabIndex = 2;
            this.lbTGBD.Text = "Thời gian bắt đầu: ";
            // 
            // dgvGia
            // 
            this.dgvGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGia.Location = new System.Drawing.Point(545, 19);
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.Size = new System.Drawing.Size(416, 164);
            this.dgvGia.TabIndex = 1;
            this.dgvGia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvGia_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btRemove);
            this.panel3.Controls.Add(this.btSave);
            this.panel3.Controls.Add(this.cbbLoaiTour);
            this.panel3.Controls.Add(this.tbTenTour);
            this.panel3.Controls.Add(this.tbMaTour);
            this.panel3.Controls.Add(this.lbLoaiTour);
            this.panel3.Controls.Add(this.lbTenTour);
            this.panel3.Controls.Add(this.lbMaTour);
            this.panel3.Controls.Add(this.dgvDsTour);
            this.panel3.Location = new System.Drawing.Point(4, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 181);
            this.panel3.TabIndex = 2;
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(254, 120);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(89, 30);
            this.btRemove.TabIndex = 10;
            this.btRemove.Text = "Xóa";
            this.btRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(142, 120);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(101, 30);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Sửa";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbbLoaiTour
            // 
            this.cbbLoaiTour.FormattingEnabled = true;
            this.cbbLoaiTour.Location = new System.Drawing.Point(168, 83);
            this.cbbLoaiTour.Name = "cbbLoaiTour";
            this.cbbLoaiTour.Size = new System.Drawing.Size(175, 21);
            this.cbbLoaiTour.TabIndex = 7;
            this.cbbLoaiTour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLoaiTour_KeyPress);
            // 
            // tbTenTour
            // 
            this.tbTenTour.Location = new System.Drawing.Point(168, 45);
            this.tbTenTour.Name = "tbTenTour";
            this.tbTenTour.Size = new System.Drawing.Size(175, 20);
            this.tbTenTour.TabIndex = 6;
            // 
            // tbMaTour
            // 
            this.tbMaTour.Enabled = false;
            this.tbMaTour.Location = new System.Drawing.Point(168, 10);
            this.tbMaTour.Name = "tbMaTour";
            this.tbMaTour.Size = new System.Drawing.Size(175, 20);
            this.tbMaTour.TabIndex = 5;
            // 
            // lbLoaiTour
            // 
            this.lbLoaiTour.AutoSize = true;
            this.lbLoaiTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiTour.Location = new System.Drawing.Point(61, 86);
            this.lbLoaiTour.Name = "lbLoaiTour";
            this.lbLoaiTour.Size = new System.Drawing.Size(69, 13);
            this.lbLoaiTour.TabIndex = 4;
            this.lbLoaiTour.Text = "Loại Tour: ";
            // 
            // lbTenTour
            // 
            this.lbTenTour.AutoSize = true;
            this.lbTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTour.Location = new System.Drawing.Point(63, 48);
            this.lbTenTour.Name = "lbTenTour";
            this.lbTenTour.Size = new System.Drawing.Size(67, 13);
            this.lbTenTour.TabIndex = 3;
            this.lbTenTour.Text = "Tên Tour: ";
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTour.Location = new System.Drawing.Point(68, 17);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(62, 13);
            this.lbMaTour.TabIndex = 2;
            this.lbMaTour.Text = "Mã Tour: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1022, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = " Sửa/Xóa Tour";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btNhapMoiGia
            // 
            this.btNhapMoiGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhapMoiGia.Location = new System.Drawing.Point(401, 135);
            this.btNhapMoiGia.Name = "btNhapMoiGia";
            this.btNhapMoiGia.Size = new System.Drawing.Size(95, 23);
            this.btNhapMoiGia.TabIndex = 10;
            this.btNhapMoiGia.Text = "Nhập mới";
            this.btNhapMoiGia.UseVisualStyleBackColor = true;
            this.btNhapMoiGia.Click += new System.EventHandler(this.btNhapMoiGia_Click);
            // 
            // DsTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pContrains);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DsTour";
            this.Text = "DsTour";
            this.Load += new System.EventHandler(this.DsTour_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDiem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTour)).EndInit();
            this.pContrains.ResumeLayout(false);
            this.pContrains.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDsTour;
        private System.Windows.Forms.Panel pContrains;
        private System.Windows.Forms.DataGridView dgvGia;
        private System.Windows.Forms.DataGridView dgvDiaDiem;
        private System.Windows.Forms.Button btBoChon;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.DataGridView dgvDiaDiem1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.DateTimePicker dtTGKT;
        private System.Windows.Forms.DateTimePicker dtTGBD;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbTGKT;
        private System.Windows.Forms.Label lbTGBD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbbLoaiTour;
        private System.Windows.Forms.TextBox tbTenTour;
        private System.Windows.Forms.TextBox tbMaTour;
        private System.Windows.Forms.Label lbLoaiTour;
        private System.Windows.Forms.Label lbTenTour;
        private System.Windows.Forms.Label lbMaTour;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNhapMoiGia;
    }
}