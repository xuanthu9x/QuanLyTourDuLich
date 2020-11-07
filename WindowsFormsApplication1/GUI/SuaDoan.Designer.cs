namespace WindowsFormsApplication1.GUI
{
    partial class SuaDoan
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
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.cbbMaDoan = new System.Windows.Forms.ComboBox();
            this.lbMaDoan = new System.Windows.Forms.Label();
            this.tbTenDoan = new System.Windows.Forms.TextBox();
            this.lbTenDoan = new System.Windows.Forms.Label();
            this.lbGioVe = new System.Windows.Forms.Label();
            this.lbGioDi = new System.Windows.Forms.Label();
            this.dtGioVe = new System.Windows.Forms.DateTimePicker();
            this.dtGioDi = new System.Windows.Forms.DateTimePicker();
            this.cbbMaTour = new System.Windows.Forms.ComboBox();
            this.lbMaTour = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.btXoaKH = new System.Windows.Forms.Button();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbTenCP = new System.Windows.Forms.ComboBox();
            this.btNhapMoi = new System.Windows.Forms.Button();
            this.btXoaCP = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvChiPhi = new System.Windows.Forms.DataGridView();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.tbSoTien = new System.Windows.Forms.TextBox();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbChiPhi = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNhiemVu = new System.Windows.Forms.Label();
            this.cbbNhiemVu = new System.Windows.Forms.ComboBox();
            this.btChonNV = new System.Windows.Forms.Button();
            this.btBoChonNV = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btLuu);
            this.panel1.Controls.Add(this.cbbMaDoan);
            this.panel1.Controls.Add(this.lbMaDoan);
            this.panel1.Controls.Add(this.tbTenDoan);
            this.panel1.Controls.Add(this.lbTenDoan);
            this.panel1.Controls.Add(this.lbGioVe);
            this.panel1.Controls.Add(this.lbGioDi);
            this.panel1.Controls.Add(this.dtGioVe);
            this.panel1.Controls.Add(this.dtGioDi);
            this.panel1.Controls.Add(this.cbbMaTour);
            this.panel1.Controls.Add(this.lbMaTour);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 128);
            this.panel1.TabIndex = 0;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(517, 94);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(517, 47);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 10;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // cbbMaDoan
            // 
            this.cbbMaDoan.FormattingEnabled = true;
            this.cbbMaDoan.Location = new System.Drawing.Point(342, 91);
            this.cbbMaDoan.Name = "cbbMaDoan";
            this.cbbMaDoan.Size = new System.Drawing.Size(100, 21);
            this.cbbMaDoan.TabIndex = 9;
            this.cbbMaDoan.SelectedIndexChanged += new System.EventHandler(this.cbbMaDoan_SelectedIndexChanged);
            this.cbbMaDoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaDoan_KeyPress);
            // 
            // lbMaDoan
            // 
            this.lbMaDoan.AutoSize = true;
            this.lbMaDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDoan.Location = new System.Drawing.Point(257, 99);
            this.lbMaDoan.Name = "lbMaDoan";
            this.lbMaDoan.Size = new System.Drawing.Size(61, 13);
            this.lbMaDoan.TabIndex = 8;
            this.lbMaDoan.Text = "Mã đoàn:";
            // 
            // tbTenDoan
            // 
            this.tbTenDoan.Location = new System.Drawing.Point(342, 54);
            this.tbTenDoan.Name = "tbTenDoan";
            this.tbTenDoan.Size = new System.Drawing.Size(100, 20);
            this.tbTenDoan.TabIndex = 7;
            // 
            // lbTenDoan
            // 
            this.lbTenDoan.AutoSize = true;
            this.lbTenDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDoan.Location = new System.Drawing.Point(257, 57);
            this.lbTenDoan.Name = "lbTenDoan";
            this.lbTenDoan.Size = new System.Drawing.Size(66, 13);
            this.lbTenDoan.TabIndex = 6;
            this.lbTenDoan.Text = "Tên đoàn:";
            // 
            // lbGioVe
            // 
            this.lbGioVe.AutoSize = true;
            this.lbGioVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioVe.Location = new System.Drawing.Point(21, 100);
            this.lbGioVe.Name = "lbGioVe";
            this.lbGioVe.Size = new System.Drawing.Size(48, 13);
            this.lbGioVe.TabIndex = 5;
            this.lbGioVe.Text = "Giờ về:";
            // 
            // lbGioDi
            // 
            this.lbGioDi.AutoSize = true;
            this.lbGioDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioDi.Location = new System.Drawing.Point(21, 63);
            this.lbGioDi.Name = "lbGioDi";
            this.lbGioDi.Size = new System.Drawing.Size(45, 13);
            this.lbGioDi.TabIndex = 4;
            this.lbGioDi.Text = "Giờ đi:";
            // 
            // dtGioVe
            // 
            this.dtGioVe.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtGioVe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGioVe.Location = new System.Drawing.Point(85, 93);
            this.dtGioVe.Name = "dtGioVe";
            this.dtGioVe.Size = new System.Drawing.Size(148, 20);
            this.dtGioVe.TabIndex = 3;
            // 
            // dtGioDi
            // 
            this.dtGioDi.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtGioDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGioDi.Location = new System.Drawing.Point(85, 57);
            this.dtGioDi.Name = "dtGioDi";
            this.dtGioDi.Size = new System.Drawing.Size(148, 20);
            this.dtGioDi.TabIndex = 2;
            // 
            // cbbMaTour
            // 
            this.cbbMaTour.FormattingEnabled = true;
            this.cbbMaTour.Location = new System.Drawing.Point(85, 18);
            this.cbbMaTour.Name = "cbbMaTour";
            this.cbbMaTour.Size = new System.Drawing.Size(114, 21);
            this.cbbMaTour.TabIndex = 1;
            this.cbbMaTour.SelectedIndexChanged += new System.EventHandler(this.cbbMaTour_SelectedIndexChanged);
            this.cbbMaTour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaTour_KeyPress);
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTour.Location = new System.Drawing.Point(21, 21);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(58, 13);
            this.lbMaTour.TabIndex = 0;
            this.lbMaTour.Text = "Mã Tour:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvKH);
            this.panel2.Controls.Add(this.btXoaKH);
            this.panel2.Controls.Add(this.cbbMaKH);
            this.panel2.Controls.Add(this.lbMaKH);
            this.panel2.Location = new System.Drawing.Point(0, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 230);
            this.panel2.TabIndex = 1;
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(11, 32);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.Size = new System.Drawing.Size(598, 193);
            this.dgvKH.TabIndex = 4;
            // 
            // btXoaKH
            // 
            this.btXoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaKH.Location = new System.Drawing.Point(322, 3);
            this.btXoaKH.Name = "btXoaKH";
            this.btXoaKH.Size = new System.Drawing.Size(75, 23);
            this.btXoaKH.TabIndex = 3;
            this.btXoaKH.Text = "Xóa KH";
            this.btXoaKH.UseVisualStyleBackColor = true;
            this.btXoaKH.Click += new System.EventHandler(this.btXoaKH_Click);
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(162, 3);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(114, 21);
            this.cbbMaKH.TabIndex = 2;
            this.cbbMaKH.SelectedIndexChanged += new System.EventHandler(this.cbbMaKH_SelectedIndexChanged);
            this.cbbMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaKH_KeyPress);
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(91, 6);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(49, 13);
            this.lbMaKH.TabIndex = 1;
            this.lbMaKH.Text = "Mã KH:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbbTenCP);
            this.panel4.Controls.Add(this.btNhapMoi);
            this.panel4.Controls.Add(this.btXoaCP);
            this.panel4.Controls.Add(this.btThem);
            this.panel4.Controls.Add(this.dgvChiPhi);
            this.panel4.Controls.Add(this.tbGhiChu);
            this.panel4.Controls.Add(this.lbGhiChu);
            this.panel4.Controls.Add(this.tbSoTien);
            this.panel4.Controls.Add(this.lbSoTien);
            this.panel4.Controls.Add(this.lbChiPhi);
            this.panel4.Location = new System.Drawing.Point(0, 407);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1030, 184);
            this.panel4.TabIndex = 3;
            // 
            // cbbTenCP
            // 
            this.cbbTenCP.FormattingEnabled = true;
            this.cbbTenCP.Location = new System.Drawing.Point(211, 10);
            this.cbbTenCP.Name = "cbbTenCP";
            this.cbbTenCP.Size = new System.Drawing.Size(146, 21);
            this.cbbTenCP.TabIndex = 17;
            this.cbbTenCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbTenCP_KeyPress);
            // 
            // btNhapMoi
            // 
            this.btNhapMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhapMoi.Location = new System.Drawing.Point(459, 96);
            this.btNhapMoi.Name = "btNhapMoi";
            this.btNhapMoi.Size = new System.Drawing.Size(75, 23);
            this.btNhapMoi.TabIndex = 16;
            this.btNhapMoi.Text = "Nhập lại";
            this.btNhapMoi.UseVisualStyleBackColor = true;
            this.btNhapMoi.Click += new System.EventHandler(this.btNhapMoi_Click);
            // 
            // btXoaCP
            // 
            this.btXoaCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaCP.Location = new System.Drawing.Point(459, 55);
            this.btXoaCP.Name = "btXoaCP";
            this.btXoaCP.Size = new System.Drawing.Size(75, 23);
            this.btXoaCP.TabIndex = 15;
            this.btXoaCP.Text = "Xóa";
            this.btXoaCP.UseVisualStyleBackColor = true;
            this.btXoaCP.Click += new System.EventHandler(this.btXoaCP_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(459, 13);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvChiPhi
            // 
            this.dgvChiPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiPhi.Location = new System.Drawing.Point(632, 10);
            this.dgvChiPhi.Name = "dgvChiPhi";
            this.dgvChiPhi.Size = new System.Drawing.Size(381, 164);
            this.dgvChiPhi.TabIndex = 13;
            this.dgvChiPhi.Click += new System.EventHandler(this.dgvChiPhi_Click);
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(208, 83);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(175, 65);
            this.tbGhiChu.TabIndex = 12;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhiChu.Location = new System.Drawing.Point(127, 96);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(55, 13);
            this.lbGhiChu.TabIndex = 11;
            this.lbGhiChu.Text = "Ghi chú:";
            // 
            // tbSoTien
            // 
            this.tbSoTien.Location = new System.Drawing.Point(211, 57);
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.Size = new System.Drawing.Size(146, 20);
            this.tbSoTien.TabIndex = 10;
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(131, 55);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(51, 13);
            this.lbSoTien.TabIndex = 9;
            this.lbSoTien.Text = "Số tiền:";
            // 
            // lbChiPhi
            // 
            this.lbChiPhi.AutoSize = true;
            this.lbChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiPhi.Location = new System.Drawing.Point(105, 13);
            this.lbChiPhi.Name = "lbChiPhi";
            this.lbChiPhi.Size = new System.Drawing.Size(77, 13);
            this.lbChiPhi.TabIndex = 2;
            this.lbChiPhi.Text = "Tên chi phí:";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(93, 52);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(158, 21);
            this.cbbMaNV.TabIndex = 10;
            this.cbbMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaNV_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV:";
            // 
            // lbNhiemVu
            // 
            this.lbNhiemVu.AutoSize = true;
            this.lbNhiemVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhiemVu.Location = new System.Drawing.Point(15, 99);
            this.lbNhiemVu.Name = "lbNhiemVu";
            this.lbNhiemVu.Size = new System.Drawing.Size(60, 13);
            this.lbNhiemVu.TabIndex = 11;
            this.lbNhiemVu.Text = "Nhiệm vụ";
            // 
            // cbbNhiemVu
            // 
            this.cbbNhiemVu.FormattingEnabled = true;
            this.cbbNhiemVu.Location = new System.Drawing.Point(93, 91);
            this.cbbNhiemVu.Name = "cbbNhiemVu";
            this.cbbNhiemVu.Size = new System.Drawing.Size(158, 21);
            this.cbbNhiemVu.TabIndex = 12;
            this.cbbNhiemVu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbNhiemVu_KeyPress);
            // 
            // btChonNV
            // 
            this.btChonNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChonNV.Location = new System.Drawing.Point(277, 50);
            this.btChonNV.Name = "btChonNV";
            this.btChonNV.Size = new System.Drawing.Size(75, 23);
            this.btChonNV.TabIndex = 13;
            this.btChonNV.Text = "Chọn";
            this.btChonNV.UseVisualStyleBackColor = true;
            this.btChonNV.Click += new System.EventHandler(this.btChonNV_Click);
            // 
            // btBoChonNV
            // 
            this.btBoChonNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBoChonNV.Location = new System.Drawing.Point(277, 89);
            this.btBoChonNV.Name = "btBoChonNV";
            this.btBoChonNV.Size = new System.Drawing.Size(75, 23);
            this.btBoChonNV.TabIndex = 14;
            this.btBoChonNV.Text = "Bỏ chọn";
            this.btBoChonNV.UseVisualStyleBackColor = true;
            this.btBoChonNV.Click += new System.EventHandler(this.btBoChonNV_Click);
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(7, 144);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.Size = new System.Drawing.Size(377, 215);
            this.dgvNV.TabIndex = 15;
            this.dgvNV.Click += new System.EventHandler(this.dgvNV_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvNV);
            this.panel3.Controls.Add(this.btBoChonNV);
            this.panel3.Controls.Add(this.cbbMaNV);
            this.panel3.Controls.Add(this.btChonNV);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbbNhiemVu);
            this.panel3.Controls.Add(this.lbNhiemVu);
            this.panel3.Location = new System.Drawing.Point(633, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 360);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1030, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sửa/Xóa Đoàn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuaDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuaDoan";
            this.Text = "SuaDoan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbMaTour;
        private System.Windows.Forms.ComboBox cbbMaTour;
        private System.Windows.Forms.Label lbGioVe;
        private System.Windows.Forms.Label lbGioDi;
        private System.Windows.Forms.DateTimePicker dtGioVe;
        private System.Windows.Forms.DateTimePicker dtGioDi;
        private System.Windows.Forms.Label lbMaDoan;
        private System.Windows.Forms.TextBox tbTenDoan;
        private System.Windows.Forms.Label lbTenDoan;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.ComboBox cbbMaDoan;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Button btBoChonNV;
        private System.Windows.Forms.Button btChonNV;
        private System.Windows.Forms.ComboBox cbbNhiemVu;
        private System.Windows.Forms.Label lbNhiemVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Button btXoaKH;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.TextBox tbSoTien;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbChiPhi;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Button btNhapMoi;
        private System.Windows.Forms.Button btXoaCP;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvChiPhi;
        private System.Windows.Forms.ComboBox cbbTenCP;
        private System.Windows.Forms.Label label2;
    }
}