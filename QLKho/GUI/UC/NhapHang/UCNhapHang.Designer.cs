namespace QLKho.GUI.UC.NhapHang
{
    partial class UCNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNhapHang));
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnLuu_NhapHang = new System.Windows.Forms.Button();
            this.btnClearText_NhapHang = new System.Windows.Forms.Button();
            this.btnBack_NhapHang = new System.Windows.Forms.Button();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtMaHangHoa = new System.Windows.Forms.TextBox();
            this.btnSearch_NhapHang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa_NhapHang = new System.Windows.Forms.Button();
            this.btnSua_NhapHang = new System.Windows.Forms.Button();
            this.btnThem_NhapHang = new System.Windows.Forms.Button();
            this.cbOption_NhapHang = new System.Windows.Forms.ComboBox();
            this.txtSearch_NhapHang = new System.Windows.Forms.TextBox();
            this.pnlBody_NhapHang = new System.Windows.Forms.Panel();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.label_TongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhieuNhap = new System.Windows.Forms.TextBox();
            this.lbMaPN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBody_NhapHang.SuspendLayout();
            this.pnlThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AllowUserToAddRows = false;
            this.dgvNhapHang.AllowUserToDeleteRows = false;
            this.dgvNhapHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.MaNV,
            this.MaHH,
            this.NgayNhap,
            this.SoLuong,
            this.GiaNhap,
            this.TongTien});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhapHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhapHang.Location = new System.Drawing.Point(0, 75);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.ReadOnly = true;
            this.dgvNhapHang.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvNhapHang.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvNhapHang.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhapHang.RowTemplate.Height = 25;
            this.dgvNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapHang.Size = new System.Drawing.Size(1129, 476);
            this.dgvNhapHang.TabIndex = 7;
            this.dgvNhapHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellContentClick);
            // 
            // MaPN
            // 
            this.MaPN.HeaderText = "Mã Phiếu Nhập";
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            this.MaPN.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 150;
            // 
            // MaHH
            // 
            this.MaHH.HeaderText = "Mã Hàng Hóa";
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            this.MaHH.Width = 150;
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            this.NgayNhap.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            this.GiaNhap.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 235;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.AllowDrop = true;
            this.dtNgayNhap.CustomFormat = "yyyy/MM/dd";
            this.dtNgayNhap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayNhap.Location = new System.Drawing.Point(119, 141);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(262, 23);
            this.dtNgayNhap.TabIndex = 10;
            this.dtNgayNhap.ValueChanged += new System.EventHandler(this.dtNgayNhap_ValueChanged);
            // 
            // btnLuu_NhapHang
            // 
            this.btnLuu_NhapHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu_NhapHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu_NhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu_NhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu_NhapHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_NhapHang.Location = new System.Drawing.Point(1001, 131);
            this.btnLuu_NhapHang.Name = "btnLuu_NhapHang";
            this.btnLuu_NhapHang.Size = new System.Drawing.Size(100, 32);
            this.btnLuu_NhapHang.TabIndex = 56;
            this.btnLuu_NhapHang.Text = "Lưu";
            this.btnLuu_NhapHang.UseVisualStyleBackColor = false;
            this.btnLuu_NhapHang.Click += new System.EventHandler(this.btnLuu_NhapHang_Click);
            // 
            // btnClearText_NhapHang
            // 
            this.btnClearText_NhapHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearText_NhapHang.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnClearText_NhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnClearText_NhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.btnClearText_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearText_NhapHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearText_NhapHang.Location = new System.Drawing.Point(875, 131);
            this.btnClearText_NhapHang.Name = "btnClearText_NhapHang";
            this.btnClearText_NhapHang.Size = new System.Drawing.Size(100, 32);
            this.btnClearText_NhapHang.TabIndex = 55;
            this.btnClearText_NhapHang.Text = "Clear";
            this.btnClearText_NhapHang.UseVisualStyleBackColor = false;
            this.btnClearText_NhapHang.Click += new System.EventHandler(this.btnClearText_NhapHang_Click);
            // 
            // btnBack_NhapHang
            // 
            this.btnBack_NhapHang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack_NhapHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack_NhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack_NhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack_NhapHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_NhapHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack_NhapHang.Location = new System.Drawing.Point(749, 131);
            this.btnBack_NhapHang.Name = "btnBack_NhapHang";
            this.btnBack_NhapHang.Size = new System.Drawing.Size(100, 32);
            this.btnBack_NhapHang.TabIndex = 57;
            this.btnBack_NhapHang.Text = "Ẩn";
            this.btnBack_NhapHang.UseVisualStyleBackColor = false;
            this.btnBack_NhapHang.Click += new System.EventHandler(this.btnBack_NhapHang_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(119, 98);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(262, 23);
            this.txtMaNhanVien.TabIndex = 53;
            this.txtMaNhanVien.TextChanged += new System.EventHandler(this.txtMaNhanVien_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(653, 11);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(278, 23);
            this.txtSoLuong.TabIndex = 52;
            this.txtSoLuong.Text = "0";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(653, 52);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(278, 23);
            this.txtGiaNhap.TabIndex = 49;
            this.txtGiaNhap.Text = "0";
            this.txtGiaNhap.TextChanged += new System.EventHandler(this.txtGiaNhap_TextChanged);
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHangHoa.Location = new System.Drawing.Point(119, 50);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(262, 23);
            this.txtMaHangHoa.TabIndex = 9;
            this.txtMaHangHoa.TextChanged += new System.EventHandler(this.txtMaHangHoa_TextChanged);
            // 
            // btnSearch_NhapHang
            // 
            this.btnSearch_NhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_NhapHang.Image")));
            this.btnSearch_NhapHang.Location = new System.Drawing.Point(448, 20);
            this.btnSearch_NhapHang.Name = "btnSearch_NhapHang";
            this.btnSearch_NhapHang.Size = new System.Drawing.Size(38, 34);
            this.btnSearch_NhapHang.TabIndex = 2;
            this.btnSearch_NhapHang.UseVisualStyleBackColor = true;
            this.btnSearch_NhapHang.Click += new System.EventHandler(this.btnSearch_NhapHang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa_NhapHang);
            this.panel1.Controls.Add(this.btnSua_NhapHang);
            this.panel1.Controls.Add(this.btnThem_NhapHang);
            this.panel1.Controls.Add(this.cbOption_NhapHang);
            this.panel1.Controls.Add(this.txtSearch_NhapHang);
            this.panel1.Controls.Add(this.btnSearch_NhapHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 69);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnXoa_NhapHang
            // 
            this.btnXoa_NhapHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa_NhapHang.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnXoa_NhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnXoa_NhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnXoa_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_NhapHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_NhapHang.Location = new System.Drawing.Point(1001, 20);
            this.btnXoa_NhapHang.Name = "btnXoa_NhapHang";
            this.btnXoa_NhapHang.Size = new System.Drawing.Size(100, 32);
            this.btnXoa_NhapHang.TabIndex = 5;
            this.btnXoa_NhapHang.Text = "Xóa";
            this.btnXoa_NhapHang.UseVisualStyleBackColor = false;
            this.btnXoa_NhapHang.Click += new System.EventHandler(this.btnXoa_NhapHang_Click);
            // 
            // btnSua_NhapHang
            // 
            this.btnSua_NhapHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua_NhapHang.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnSua_NhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnSua_NhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnSua_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_NhapHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_NhapHang.Location = new System.Drawing.Point(875, 20);
            this.btnSua_NhapHang.Name = "btnSua_NhapHang";
            this.btnSua_NhapHang.Size = new System.Drawing.Size(100, 32);
            this.btnSua_NhapHang.TabIndex = 4;
            this.btnSua_NhapHang.Text = "Sửa";
            this.btnSua_NhapHang.UseVisualStyleBackColor = false;
            this.btnSua_NhapHang.Click += new System.EventHandler(this.btnSua_NhapHang_Click);
            // 
            // btnThem_NhapHang
            // 
            this.btnThem_NhapHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem_NhapHang.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem_NhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem_NhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_NhapHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_NhapHang.Location = new System.Drawing.Point(749, 20);
            this.btnThem_NhapHang.Name = "btnThem_NhapHang";
            this.btnThem_NhapHang.Size = new System.Drawing.Size(100, 32);
            this.btnThem_NhapHang.TabIndex = 6;
            this.btnThem_NhapHang.Text = "Thêm";
            this.btnThem_NhapHang.UseVisualStyleBackColor = false;
            this.btnThem_NhapHang.Click += new System.EventHandler(this.btnThem_NhapHang_Click);
            // 
            // cbOption_NhapHang
            // 
            this.cbOption_NhapHang.BackColor = System.Drawing.SystemColors.Control;
            this.cbOption_NhapHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption_NhapHang.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOption_NhapHang.FormattingEnabled = true;
            this.cbOption_NhapHang.Items.AddRange(new object[] {
            "Mã Phiếu nhập",
            "Mã Hàng hóa",
            "Mã Nhân viên",
            "Tổng tiền",
            "Giá Nhập",
            "Số lượng"});
            this.cbOption_NhapHang.Location = new System.Drawing.Point(293, 22);
            this.cbOption_NhapHang.Name = "cbOption_NhapHang";
            this.cbOption_NhapHang.Size = new System.Drawing.Size(149, 30);
            this.cbOption_NhapHang.TabIndex = 1;
            this.cbOption_NhapHang.Tag = "";
            this.cbOption_NhapHang.SelectedIndexChanged += new System.EventHandler(this.cbOption_NhapHang_SelectedIndexChanged);
            // 
            // txtSearch_NhapHang
            // 
            this.txtSearch_NhapHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_NhapHang.Location = new System.Drawing.Point(12, 22);
            this.txtSearch_NhapHang.Name = "txtSearch_NhapHang";
            this.txtSearch_NhapHang.Size = new System.Drawing.Size(275, 27);
            this.txtSearch_NhapHang.TabIndex = 0;
            this.txtSearch_NhapHang.TextChanged += new System.EventHandler(this.txtSearch_NhapHang_TextChanged);
            // 
            // pnlBody_NhapHang
            // 
            this.pnlBody_NhapHang.Controls.Add(this.pnlThongTin);
            this.pnlBody_NhapHang.Controls.Add(this.dgvNhapHang);
            this.pnlBody_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody_NhapHang.Location = new System.Drawing.Point(0, 0);
            this.pnlBody_NhapHang.Name = "pnlBody_NhapHang";
            this.pnlBody_NhapHang.Size = new System.Drawing.Size(1129, 551);
            this.pnlBody_NhapHang.TabIndex = 9;
            this.pnlBody_NhapHang.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_NhapHang_Paint);
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.BackColor = System.Drawing.Color.White;
            this.pnlThongTin.Controls.Add(this.label_TongTien);
            this.pnlThongTin.Controls.Add(this.dtNgayNhap);
            this.pnlThongTin.Controls.Add(this.btnLuu_NhapHang);
            this.pnlThongTin.Controls.Add(this.btnClearText_NhapHang);
            this.pnlThongTin.Controls.Add(this.btnBack_NhapHang);
            this.pnlThongTin.Controls.Add(this.txtMaNhanVien);
            this.pnlThongTin.Controls.Add(this.txtSoLuong);
            this.pnlThongTin.Controls.Add(this.txtGiaNhap);
            this.pnlThongTin.Controls.Add(this.txtMaHangHoa);
            this.pnlThongTin.Controls.Add(this.label9);
            this.pnlThongTin.Controls.Add(this.label8);
            this.pnlThongTin.Controls.Add(this.label6);
            this.pnlThongTin.Controls.Add(this.label3);
            this.pnlThongTin.Controls.Add(this.label2);
            this.pnlThongTin.Controls.Add(this.label1);
            this.pnlThongTin.Controls.Add(this.txtPhieuNhap);
            this.pnlThongTin.Controls.Add(this.lbMaPN);
            this.pnlThongTin.Location = new System.Drawing.Point(0, 373);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(1129, 178);
            this.pnlThongTin.TabIndex = 8;
            this.pnlThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThongTin_Paint);
            // 
            // label_TongTien
            // 
            this.label_TongTien.AutoSize = true;
            this.label_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TongTien.Location = new System.Drawing.Point(653, 98);
            this.label_TongTien.Name = "label_TongTien";
            this.label_TongTien.Size = new System.Drawing.Size(0, 20);
            this.label_TongTien.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Mã Nhân viên";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(575, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Số lượng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tổng Tiền";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ngày nhập";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Giá Nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã Hàng hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPhieuNhap
            // 
            this.txtPhieuNhap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhieuNhap.Location = new System.Drawing.Point(119, 8);
            this.txtPhieuNhap.Name = "txtPhieuNhap";
            this.txtPhieuNhap.Size = new System.Drawing.Size(262, 23);
            this.txtPhieuNhap.TabIndex = 8;
            this.txtPhieuNhap.TextChanged += new System.EventHandler(this.txtPhieuNhap_TextChanged);
            // 
            // lbMaPN
            // 
            this.lbMaPN.AutoSize = true;
            this.lbMaPN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPN.Location = new System.Drawing.Point(9, 11);
            this.lbMaPN.Name = "lbMaPN";
            this.lbMaPN.Size = new System.Drawing.Size(104, 17);
            this.lbMaPN.TabIndex = 33;
            this.lbMaPN.Text = "Mã Phiếu nhập";
            this.lbMaPN.Click += new System.EventHandler(this.lbMaPN_Click);
            // 
            // UCNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBody_NhapHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UCNhapHang";
            this.Text = "UCNhapHang";
            this.Load += new System.EventHandler(this.UCNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBody_NhapHang.ResumeLayout(false);
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Button btnLuu_NhapHang;
        private System.Windows.Forms.Button btnClearText_NhapHang;
        private System.Windows.Forms.Button btnBack_NhapHang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.Button btnSearch_NhapHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa_NhapHang;
        private System.Windows.Forms.Button btnSua_NhapHang;
        private System.Windows.Forms.Button btnThem_NhapHang;
        private System.Windows.Forms.ComboBox cbOption_NhapHang;
        private System.Windows.Forms.TextBox txtSearch_NhapHang;
        private System.Windows.Forms.Panel pnlBody_NhapHang;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhieuNhap;
        private System.Windows.Forms.Label lbMaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label label_TongTien;
    }
}