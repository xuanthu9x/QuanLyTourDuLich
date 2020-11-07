namespace WindowsFormsApplication1
{
    partial class ThemDoan
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
            this.btThem = new System.Windows.Forms.Button();
            this.dtGioVe = new System.Windows.Forms.DateTimePicker();
            this.dtGioDi = new System.Windows.Forms.DateTimePicker();
            this.tbTenDoan = new System.Windows.Forms.TextBox();
            this.lbGioVe = new System.Windows.Forms.Label();
            this.tbMaDoan = new System.Windows.Forms.TextBox();
            this.lbTenDoan = new System.Windows.Forms.Label();
            this.lbMaDoan = new System.Windows.Forms.Label();
            this.lbGioDi = new System.Windows.Forms.Label();
            this.cbbMaTour = new System.Windows.Forms.ComboBox();
            this.lbMaTour = new System.Windows.Forms.Label();
            this.cbbNhiemVu = new System.Windows.Forms.ComboBox();
            this.lbNhiemVu = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBoChonKH = new System.Windows.Forms.Button();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhiemVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhiemVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbTenCP = new System.Windows.Forms.ComboBox();
            this.btNhapLai = new System.Windows.Forms.Button();
            this.dgvChiPhi = new System.Windows.Forms.DataGridView();
            this.ChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt = new System.Windows.Forms.Button();
            this.btThemCP = new System.Windows.Forms.Button();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.tbSoTien = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbTenCP = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btBoChon = new System.Windows.Forms.Button();
            this.btChonNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.dtGioVe);
            this.panel1.Controls.Add(this.dtGioDi);
            this.panel1.Controls.Add(this.tbTenDoan);
            this.panel1.Controls.Add(this.lbGioVe);
            this.panel1.Controls.Add(this.tbMaDoan);
            this.panel1.Controls.Add(this.lbTenDoan);
            this.panel1.Controls.Add(this.lbMaDoan);
            this.panel1.Controls.Add(this.lbGioDi);
            this.panel1.Controls.Add(this.cbbMaTour);
            this.panel1.Controls.Add(this.lbMaTour);
            this.panel1.Location = new System.Drawing.Point(2, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 109);
            this.panel1.TabIndex = 0;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(501, 52);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(111, 29);
            this.btThem.TabIndex = 15;
            this.btThem.Text = "Lưu";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dtGioVe
            // 
            this.dtGioVe.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtGioVe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGioVe.Location = new System.Drawing.Point(78, 61);
            this.dtGioVe.Name = "dtGioVe";
            this.dtGioVe.Size = new System.Drawing.Size(150, 20);
            this.dtGioVe.TabIndex = 10;
            // 
            // dtGioDi
            // 
            this.dtGioDi.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtGioDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGioDi.Location = new System.Drawing.Point(78, 12);
            this.dtGioDi.Name = "dtGioDi";
            this.dtGioDi.Size = new System.Drawing.Size(150, 20);
            this.dtGioDi.TabIndex = 9;
            // 
            // tbTenDoan
            // 
            this.tbTenDoan.Location = new System.Drawing.Point(510, 11);
            this.tbTenDoan.Name = "tbTenDoan";
            this.tbTenDoan.Size = new System.Drawing.Size(102, 20);
            this.tbTenDoan.TabIndex = 6;
            // 
            // lbGioVe
            // 
            this.lbGioVe.AutoSize = true;
            this.lbGioVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioVe.Location = new System.Drawing.Point(17, 61);
            this.lbGioVe.Name = "lbGioVe";
            this.lbGioVe.Size = new System.Drawing.Size(52, 13);
            this.lbGioVe.TabIndex = 8;
            this.lbGioVe.Text = "Giờ về: ";
            // 
            // tbMaDoan
            // 
            this.tbMaDoan.Location = new System.Drawing.Point(324, 58);
            this.tbMaDoan.Name = "tbMaDoan";
            this.tbMaDoan.Size = new System.Drawing.Size(118, 20);
            this.tbMaDoan.TabIndex = 5;
            this.tbMaDoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaDoan_KeyPress);
            // 
            // lbTenDoan
            // 
            this.lbTenDoan.AutoSize = true;
            this.lbTenDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDoan.Location = new System.Drawing.Point(433, 12);
            this.lbTenDoan.Name = "lbTenDoan";
            this.lbTenDoan.Size = new System.Drawing.Size(71, 13);
            this.lbTenDoan.TabIndex = 3;
            this.lbTenDoan.Text = "Tên Đoàn: ";
            // 
            // lbMaDoan
            // 
            this.lbMaDoan.AutoSize = true;
            this.lbMaDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDoan.Location = new System.Drawing.Point(248, 61);
            this.lbMaDoan.Name = "lbMaDoan";
            this.lbMaDoan.Size = new System.Drawing.Size(66, 13);
            this.lbMaDoan.TabIndex = 2;
            this.lbMaDoan.Text = "Mã Đoàn: ";
            // 
            // lbGioDi
            // 
            this.lbGioDi.AutoSize = true;
            this.lbGioDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioDi.Location = new System.Drawing.Point(20, 18);
            this.lbGioDi.Name = "lbGioDi";
            this.lbGioDi.Size = new System.Drawing.Size(49, 13);
            this.lbGioDi.TabIndex = 7;
            this.lbGioDi.Text = "Giờ đi: ";
            // 
            // cbbMaTour
            // 
            this.cbbMaTour.FormattingEnabled = true;
            this.cbbMaTour.Location = new System.Drawing.Point(324, 9);
            this.cbbMaTour.Name = "cbbMaTour";
            this.cbbMaTour.Size = new System.Drawing.Size(82, 21);
            this.cbbMaTour.TabIndex = 4;
            this.cbbMaTour.SelectedIndexChanged += new System.EventHandler(this.cbbMaTour_SelectedIndexChanged);
            this.cbbMaTour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaTour_KeyPress);
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTour.Location = new System.Drawing.Point(252, 12);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(62, 13);
            this.lbMaTour.TabIndex = 1;
            this.lbMaTour.Text = "Mã Tour: ";
            // 
            // cbbNhiemVu
            // 
            this.cbbNhiemVu.FormattingEnabled = true;
            this.cbbNhiemVu.Location = new System.Drawing.Point(132, 61);
            this.cbbNhiemVu.Name = "cbbNhiemVu";
            this.cbbNhiemVu.Size = new System.Drawing.Size(156, 21);
            this.cbbNhiemVu.TabIndex = 14;
            this.cbbNhiemVu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbNhiemVu_KeyPress);
            // 
            // lbNhiemVu
            // 
            this.lbNhiemVu.AutoSize = true;
            this.lbNhiemVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhiemVu.Location = new System.Drawing.Point(44, 61);
            this.lbNhiemVu.Name = "lbNhiemVu";
            this.lbNhiemVu.Size = new System.Drawing.Size(68, 13);
            this.lbNhiemVu.TabIndex = 12;
            this.lbNhiemVu.Text = "Nhiệm vụ: ";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(132, 14);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(156, 21);
            this.cbbMaNV.TabIndex = 13;
            this.cbbMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaNV_KeyPress);
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(20, 14);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(92, 13);
            this.lbMaNV.TabIndex = 11;
            this.lbMaNV.Text = "Mã nhân viên: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btBoChonKH);
            this.panel2.Controls.Add(this.cbbMaKH);
            this.panel2.Controls.Add(this.lbMaKH);
            this.panel2.Controls.Add(this.dgvKH);
            this.panel2.Location = new System.Drawing.Point(2, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 230);
            this.panel2.TabIndex = 1;
            // 
            // btBoChonKH
            // 
            this.btBoChonKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBoChonKH.Location = new System.Drawing.Point(272, 6);
            this.btBoChonKH.Name = "btBoChonKH";
            this.btBoChonKH.Size = new System.Drawing.Size(75, 23);
            this.btBoChonKH.TabIndex = 18;
            this.btBoChonKH.Text = "Bỏ chọn";
            this.btBoChonKH.UseVisualStyleBackColor = true;
            this.btBoChonKH.Click += new System.EventHandler(this.btBoChonKH_Click);
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(107, 3);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(121, 21);
            this.cbbMaKH.TabIndex = 17;
            this.cbbMaKH.SelectedIndexChanged += new System.EventHandler(this.cbbMaKH_SelectedIndexChanged);
            this.cbbMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaKH_KeyPress);
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(44, 6);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(49, 13);
            this.lbMaKH.TabIndex = 16;
            this.lbMaKH.Text = "Mã KH:";
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTen,
            this.CMND,
            this.DiaChi,
            this.GioiTinh,
            this.sdt});
            this.dgvKH.Location = new System.Drawing.Point(3, 35);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.Size = new System.Drawing.Size(623, 181);
            this.dgvKH.TabIndex = 2;
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTenNV,
            this.NhiemVu,
            this.MaNhiemVu});
            this.dgvNV.Location = new System.Drawing.Point(10, 136);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.Size = new System.Drawing.Size(372, 181);
            this.dgvNV.TabIndex = 3;
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // HoTenNV
            // 
            this.HoTenNV.HeaderText = "Họ tên nhân viên";
            this.HoTenNV.Name = "HoTenNV";
            // 
            // NhiemVu
            // 
            this.NhiemVu.HeaderText = "Nhiệm vụ";
            this.NhiemVu.Name = "NhiemVu";
            // 
            // MaNhiemVu
            // 
            this.MaNhiemVu.HeaderText = "Mã nhiệm vụ";
            this.MaNhiemVu.Name = "MaNhiemVu";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbbTenCP);
            this.panel3.Controls.Add(this.btNhapLai);
            this.panel3.Controls.Add(this.dgvChiPhi);
            this.panel3.Controls.Add(this.bt);
            this.panel3.Controls.Add(this.btThemCP);
            this.panel3.Controls.Add(this.tbGhiChu);
            this.panel3.Controls.Add(this.tbSoTien);
            this.panel3.Controls.Add(this.lbGhiChu);
            this.panel3.Controls.Add(this.lbSoTien);
            this.panel3.Controls.Add(this.lbTenCP);
            this.panel3.Location = new System.Drawing.Point(2, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 204);
            this.panel3.TabIndex = 2;
            // 
            // cbbTenCP
            // 
            this.cbbTenCP.FormattingEnabled = true;
            this.cbbTenCP.Location = new System.Drawing.Point(143, 17);
            this.cbbTenCP.Name = "cbbTenCP";
            this.cbbTenCP.Size = new System.Drawing.Size(175, 21);
            this.cbbTenCP.TabIndex = 10;
            this.cbbTenCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbTenCP_KeyPress);
            // 
            // btNhapLai
            // 
            this.btNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhapLai.Location = new System.Drawing.Point(367, 121);
            this.btNhapLai.Name = "btNhapLai";
            this.btNhapLai.Size = new System.Drawing.Size(75, 23);
            this.btNhapLai.TabIndex = 9;
            this.btNhapLai.Text = "Nhập lại";
            this.btNhapLai.UseVisualStyleBackColor = true;
            this.btNhapLai.Click += new System.EventHandler(this.btNhapLai_Click);
            // 
            // dgvChiPhi
            // 
            this.dgvChiPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChiPhi,
            this.SoTien,
            this.GhiChu});
            this.dgvChiPhi.Location = new System.Drawing.Point(606, 3);
            this.dgvChiPhi.Name = "dgvChiPhi";
            this.dgvChiPhi.Size = new System.Drawing.Size(413, 192);
            this.dgvChiPhi.TabIndex = 8;
            // 
            // ChiPhi
            // 
            this.ChiPhi.HeaderText = "Chi phí";
            this.ChiPhi.Name = "ChiPhi";
            // 
            // SoTien
            // 
            this.SoTien.HeaderText = "Khoản chi";
            this.SoTien.Name = "SoTien";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // bt
            // 
            this.bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt.Location = new System.Drawing.Point(367, 62);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(75, 23);
            this.bt.TabIndex = 7;
            this.bt.Text = "Xóa";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // btThemCP
            // 
            this.btThemCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemCP.Location = new System.Drawing.Point(367, 20);
            this.btThemCP.Name = "btThemCP";
            this.btThemCP.Size = new System.Drawing.Size(75, 23);
            this.btThemCP.TabIndex = 6;
            this.btThemCP.Text = "Thêm";
            this.btThemCP.UseVisualStyleBackColor = true;
            this.btThemCP.Click += new System.EventHandler(this.btThemCP_Click);
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(143, 93);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(175, 65);
            this.tbGhiChu.TabIndex = 5;
            // 
            // tbSoTien
            // 
            this.tbSoTien.Location = new System.Drawing.Point(143, 59);
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.Size = new System.Drawing.Size(175, 20);
            this.tbSoTien.TabIndex = 4;
            this.tbSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoTien_KeyPress);
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhiChu.Location = new System.Drawing.Point(66, 96);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(55, 13);
            this.lbGhiChu.TabIndex = 2;
            this.lbGhiChu.Text = "Ghi chú:";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(70, 62);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(51, 13);
            this.lbSoTien.TabIndex = 1;
            this.lbSoTien.Text = "Số tiền:";
            // 
            // lbTenCP
            // 
            this.lbTenCP.AutoSize = true;
            this.lbTenCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenCP.Location = new System.Drawing.Point(44, 20);
            this.lbTenCP.Name = "lbTenCP";
            this.lbTenCP.Size = new System.Drawing.Size(77, 13);
            this.lbTenCP.TabIndex = 0;
            this.lbTenCP.Text = "Tên chi phí:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btBoChon);
            this.panel4.Controls.Add(this.btChonNV);
            this.panel4.Controls.Add(this.lbMaNV);
            this.panel4.Controls.Add(this.dgvNV);
            this.panel4.Controls.Add(this.cbbNhiemVu);
            this.panel4.Controls.Add(this.cbbMaNV);
            this.panel4.Controls.Add(this.lbNhiemVu);
            this.panel4.Location = new System.Drawing.Point(639, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 345);
            this.panel4.TabIndex = 3;
            // 
            // btBoChon
            // 
            this.btBoChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBoChon.Location = new System.Drawing.Point(167, 107);
            this.btBoChon.Name = "btBoChon";
            this.btBoChon.Size = new System.Drawing.Size(75, 23);
            this.btBoChon.TabIndex = 16;
            this.btBoChon.Text = "Bỏ chọn";
            this.btBoChon.UseVisualStyleBackColor = true;
            this.btBoChon.Click += new System.EventHandler(this.btBoChon_Click);
            // 
            // btChonNV
            // 
            this.btChonNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChonNV.Location = new System.Drawing.Point(47, 107);
            this.btChonNV.Name = "btChonNV";
            this.btChonNV.Size = new System.Drawing.Size(75, 23);
            this.btChonNV.TabIndex = 15;
            this.btChonNV.Text = "Chọn";
            this.btChonNV.UseVisualStyleBackColor = true;
            this.btChonNV.Click += new System.EventHandler(this.btChonNV_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1022, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thêm Đoàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThemDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemDoan";
            this.Text = "ThemDoan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbbNhiemVu;
        private System.Windows.Forms.DateTimePicker dtGioVe;
        private System.Windows.Forms.Label lbNhiemVu;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.DateTimePicker dtGioDi;
        private System.Windows.Forms.Label lbGioVe;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbGioDi;
        private System.Windows.Forms.TextBox tbTenDoan;
        private System.Windows.Forms.TextBox tbMaDoan;
        private System.Windows.Forms.ComboBox cbbMaTour;
        private System.Windows.Forms.Label lbTenDoan;
        private System.Windows.Forms.Label lbMaDoan;
        private System.Windows.Forms.Label lbMaTour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvChiPhi;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Button btThemCP;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.TextBox tbSoTien;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbTenCP;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btBoChon;
        private System.Windows.Forms.Button btChonNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhiemVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhiemVu;
        private System.Windows.Forms.Button btNhapLai;
        private System.Windows.Forms.ComboBox cbbTenCP;
        private System.Windows.Forms.Button btBoChonKH;
        private System.Windows.Forms.Label label1;
    }
}