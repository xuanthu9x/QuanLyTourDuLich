namespace WindowsFormsApplication1
{
    partial class ThemTour
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
            this.btReEnter = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.cbb_LoaiTour = new System.Windows.Forms.ComboBox();
            this.lbLoaiTour = new System.Windows.Forms.Label();
            this.tbTenTour = new System.Windows.Forms.TextBox();
            this.lbTenTour = new System.Windows.Forms.Label();
            this.tbMaTour = new System.Windows.Forms.TextBox();
            this.lbMaTour = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_BoChon = new System.Windows.Forms.Button();
            this.btChon = new System.Windows.Forms.Button();
            this.GridViewDD2 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridViewDiaDiem = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXoaGia = new System.Windows.Forms.Button();
            this.btThemGia = new System.Windows.Forms.Button();
            this.dgvGia = new System.Windows.Forms.DataGridView();
            this.MaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.dtTGKT = new System.Windows.Forms.DateTimePicker();
            this.dtTGBD = new System.Windows.Forms.DateTimePicker();
            this.lbTGKT = new System.Windows.Forms.Label();
            this.lbTGBD = new System.Windows.Forms.Label();
            this.lbMenu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDiaDiem)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btReEnter);
            this.panel1.Controls.Add(this.bt_Them);
            this.panel1.Controls.Add(this.cbb_LoaiTour);
            this.panel1.Controls.Add(this.lbLoaiTour);
            this.panel1.Controls.Add(this.tbTenTour);
            this.panel1.Controls.Add(this.lbTenTour);
            this.panel1.Controls.Add(this.tbMaTour);
            this.panel1.Controls.Add(this.lbMaTour);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 98);
            this.panel1.TabIndex = 0;
            // 
            // btReEnter
            // 
            this.btReEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReEnter.Image = global::WindowsFormsApplication1.Properties.Resources.reload;
            this.btReEnter.Location = new System.Drawing.Point(744, 26);
            this.btReEnter.Name = "btReEnter";
            this.btReEnter.Size = new System.Drawing.Size(110, 41);
            this.btReEnter.TabIndex = 1;
            this.btReEnter.Text = "Nhập lại";
            this.btReEnter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btReEnter.UseVisualStyleBackColor = true;
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Image = global::WindowsFormsApplication1.Properties.Resources.floppy_disk__1_;
            this.bt_Them.Location = new System.Drawing.Point(594, 26);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(109, 41);
            this.bt_Them.TabIndex = 6;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // cbb_LoaiTour
            // 
            this.cbb_LoaiTour.FormattingEnabled = true;
            this.cbb_LoaiTour.Location = new System.Drawing.Point(401, 26);
            this.cbb_LoaiTour.Name = "cbb_LoaiTour";
            this.cbb_LoaiTour.Size = new System.Drawing.Size(158, 21);
            this.cbb_LoaiTour.TabIndex = 5;
            this.cbb_LoaiTour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbb_LoaiTour_KeyPress);
            // 
            // lbLoaiTour
            // 
            this.lbLoaiTour.AutoSize = true;
            this.lbLoaiTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiTour.Location = new System.Drawing.Point(305, 26);
            this.lbLoaiTour.Name = "lbLoaiTour";
            this.lbLoaiTour.Size = new System.Drawing.Size(69, 13);
            this.lbLoaiTour.TabIndex = 4;
            this.lbLoaiTour.Text = "Loại Tour: ";
            // 
            // tbTenTour
            // 
            this.tbTenTour.Location = new System.Drawing.Point(110, 56);
            this.tbTenTour.Name = "tbTenTour";
            this.tbTenTour.Size = new System.Drawing.Size(152, 20);
            this.tbTenTour.TabIndex = 3;
            // 
            // lbTenTour
            // 
            this.lbTenTour.AutoSize = true;
            this.lbTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTour.Location = new System.Drawing.Point(27, 56);
            this.lbTenTour.Name = "lbTenTour";
            this.lbTenTour.Size = new System.Drawing.Size(67, 13);
            this.lbTenTour.TabIndex = 2;
            this.lbTenTour.Text = "Tên Tour: ";
            // 
            // tbMaTour
            // 
            this.tbMaTour.Location = new System.Drawing.Point(110, 19);
            this.tbMaTour.Name = "tbMaTour";
            this.tbMaTour.Size = new System.Drawing.Size(152, 20);
            this.tbMaTour.TabIndex = 1;
            this.tbMaTour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaTour_KeyPress);
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTour.Location = new System.Drawing.Point(32, 19);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(62, 13);
            this.lbMaTour.TabIndex = 0;
            this.lbMaTour.Text = "Mã Tour: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bt_BoChon);
            this.panel2.Controls.Add(this.btChon);
            this.panel2.Controls.Add(this.GridViewDD2);
            this.panel2.Controls.Add(this.GridViewDiaDiem);
            this.panel2.Location = new System.Drawing.Point(0, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 211);
            this.panel2.TabIndex = 1;
            // 
            // bt_BoChon
            // 
            this.bt_BoChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BoChon.Location = new System.Drawing.Point(455, 112);
            this.bt_BoChon.Name = "bt_BoChon";
            this.bt_BoChon.Size = new System.Drawing.Size(75, 23);
            this.bt_BoChon.TabIndex = 3;
            this.bt_BoChon.Text = "Bỏ Chọn";
            this.bt_BoChon.UseVisualStyleBackColor = true;
            this.bt_BoChon.Click += new System.EventHandler(this.bt_BoChon_Click);
            // 
            // btChon
            // 
            this.btChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChon.Location = new System.Drawing.Point(455, 52);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 23);
            this.btChon.TabIndex = 2;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // GridViewDD2
            // 
            this.GridViewDD2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewDD2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDD2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DD});
            this.GridViewDD2.Location = new System.Drawing.Point(604, 11);
            this.GridViewDD2.Name = "GridViewDD2";
            this.GridViewDD2.Size = new System.Drawing.Size(364, 187);
            this.GridViewDD2.TabIndex = 1;
            this.GridViewDD2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridViewDD2_MouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Mã địa điểm";
            this.Id.Name = "Id";
            // 
            // DD
            // 
            this.DD.HeaderText = "Tên địa điểm";
            this.DD.Name = "DD";
            // 
            // GridViewDiaDiem
            // 
            this.GridViewDiaDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDiaDiem.Location = new System.Drawing.Point(30, 11);
            this.GridViewDiaDiem.Name = "GridViewDiaDiem";
            this.GridViewDiaDiem.Size = new System.Drawing.Size(380, 187);
            this.GridViewDiaDiem.TabIndex = 0;
            this.GridViewDiaDiem.Click += new System.EventHandler(this.GridViewDiaDiem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btXoaGia);
            this.panel3.Controls.Add(this.btThemGia);
            this.panel3.Controls.Add(this.dgvGia);
            this.panel3.Controls.Add(this.tbGia);
            this.panel3.Controls.Add(this.lbGia);
            this.panel3.Controls.Add(this.dtTGKT);
            this.panel3.Controls.Add(this.dtTGBD);
            this.panel3.Controls.Add(this.lbTGKT);
            this.panel3.Controls.Add(this.lbTGBD);
            this.panel3.Location = new System.Drawing.Point(0, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 219);
            this.panel3.TabIndex = 2;
            // 
            // btXoaGia
            // 
            this.btXoaGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaGia.Location = new System.Drawing.Point(286, 158);
            this.btXoaGia.Name = "btXoaGia";
            this.btXoaGia.Size = new System.Drawing.Size(75, 23);
            this.btXoaGia.TabIndex = 8;
            this.btXoaGia.Text = "Xóa";
            this.btXoaGia.UseVisualStyleBackColor = true;
            this.btXoaGia.Click += new System.EventHandler(this.btXoaGia_Click);
            // 
            // btThemGia
            // 
            this.btThemGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemGia.Location = new System.Drawing.Point(175, 158);
            this.btThemGia.Name = "btThemGia";
            this.btThemGia.Size = new System.Drawing.Size(75, 23);
            this.btThemGia.TabIndex = 7;
            this.btThemGia.Text = "Thêm";
            this.btThemGia.UseVisualStyleBackColor = true;
            this.btThemGia.Click += new System.EventHandler(this.btThemGia_Click);
            // 
            // dgvGia
            // 
            this.dgvGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTour,
            this.TGBD,
            this.TGKT,
            this.Gia});
            this.dgvGia.Location = new System.Drawing.Point(530, 14);
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.Size = new System.Drawing.Size(419, 189);
            this.dgvGia.TabIndex = 6;
            this.dgvGia.Click += new System.EventHandler(this.dgvGia_Click);
            // 
            // MaTour
            // 
            this.MaTour.HeaderText = "Mã Tour";
            this.MaTour.Name = "MaTour";
            // 
            // TGBD
            // 
            this.TGBD.HeaderText = "Thời gian bắt đầu";
            this.TGBD.Name = "TGBD";
            // 
            // TGKT
            // 
            this.TGKT.HeaderText = "Thời gian kết thúc";
            this.TGKT.Name = "TGKT";
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(175, 117);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(100, 20);
            this.tbGia.TabIndex = 5;
            this.tbGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGia_KeyPress);
            // 
            // lbGia
            // 
            this.lbGia.Location = new System.Drawing.Point(61, 117);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(23, 13);
            this.lbGia.TabIndex = 4;
            this.lbGia.Text = "Giá:4";
            // 
            // dtTGKT
            // 
            this.dtTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTGKT.Location = new System.Drawing.Point(175, 75);
            this.dtTGKT.Name = "dtTGKT";
            this.dtTGKT.Size = new System.Drawing.Size(200, 20);
            this.dtTGKT.TabIndex = 3;
            // 
            // dtTGBD
            // 
            this.dtTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTGBD.Location = new System.Drawing.Point(175, 27);
            this.dtTGBD.Name = "dtTGBD";
            this.dtTGBD.Size = new System.Drawing.Size(200, 20);
            this.dtTGBD.TabIndex = 2;
            // 
            // lbTGKT
            // 
            this.lbTGKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGKT.Location = new System.Drawing.Point(61, 75);
            this.lbTGKT.Name = "lbTGKT";
            this.lbTGKT.Size = new System.Drawing.Size(93, 15);
            this.lbTGKT.TabIndex = 1;
            this.lbTGKT.Text = "Thời gian kết thúc ";
            // 
            // lbTGBD
            // 
            this.lbTGBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGBD.Location = new System.Drawing.Point(63, 27);
            this.lbTGBD.Name = "lbTGBD";
            this.lbTGBD.Size = new System.Drawing.Size(91, 15);
            this.lbTGBD.TabIndex = 0;
            this.lbTGBD.Text = "Thời gian bắt đầu ";
            // 
            // lbMenu
            // 
            this.lbMenu.BackColor = System.Drawing.Color.Indigo;
            this.lbMenu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.Color.Transparent;
            this.lbMenu.Location = new System.Drawing.Point(0, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(1030, 34);
            this.lbMenu.TabIndex = 3;
            this.lbMenu.Text = "Thêm Tour";
            this.lbMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThemTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 594);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemTour";
            this.Text = "ThemTour";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDiaDiem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMaTour;
        private System.Windows.Forms.Label lbMaTour;
        private System.Windows.Forms.TextBox tbTenTour;
        private System.Windows.Forms.Label lbTenTour;
        private System.Windows.Forms.Label lbLoaiTour;
        private System.Windows.Forms.ComboBox cbb_LoaiTour;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button btReEnter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GridViewDiaDiem;
        private System.Windows.Forms.DataGridView GridViewDD2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DD;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.Button bt_BoChon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTGBD;
        private System.Windows.Forms.Label lbTGKT;
        private System.Windows.Forms.DateTimePicker dtTGKT;
        private System.Windows.Forms.DateTimePicker dtTGBD;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.DataGridView dgvGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Button btXoaGia;
        private System.Windows.Forms.Button btThemGia;
        private System.Windows.Forms.Label lbMenu;
    }
}