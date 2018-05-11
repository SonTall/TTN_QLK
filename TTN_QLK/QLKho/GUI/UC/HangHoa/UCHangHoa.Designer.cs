namespace QLKho.GUI.UC.HangHoa
{
    partial class UCHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHangHoa));
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu_HangHoa = new System.Windows.Forms.Button();
            this.btnBack_HangHoa = new System.Windows.Forms.Button();
            this.pnlThongTin_HangHoa = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.btnClearText_HangHoa = new System.Windows.Forms.Button();
            this.txtMaHangHoa = new System.Windows.Forms.TextBox();
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa_HangHoa = new System.Windows.Forms.Button();
            this.btnSua_HangHoa = new System.Windows.Forms.Button();
            this.btnThem_HangHoa = new System.Windows.Forms.Button();
            this.cbOption_HangHoa = new System.Windows.Forms.ComboBox();
            this.txtSearch_HangHoa = new System.Windows.Forms.TextBox();
            this.btnSearch_HangHoa = new System.Windows.Forms.Button();
            this.pnlThongTin_HangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDonVi
            // 
            this.txtDonVi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(117, 75);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(139, 23);
            this.txtDonVi.TabIndex = 45;
            this.txtDonVi.TextChanged += new System.EventHandler(this.txtSDTNhanVien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Đơn Vị";
            // 
            // btnLuu_HangHoa
            // 
            this.btnLuu_HangHoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu_HangHoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu_HangHoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu_HangHoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu_HangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu_HangHoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_HangHoa.Location = new System.Drawing.Point(952, 78);
            this.btnLuu_HangHoa.Name = "btnLuu_HangHoa";
            this.btnLuu_HangHoa.Size = new System.Drawing.Size(100, 32);
            this.btnLuu_HangHoa.TabIndex = 19;
            this.btnLuu_HangHoa.Text = "Lưu";
            this.btnLuu_HangHoa.UseVisualStyleBackColor = false;
            this.btnLuu_HangHoa.Click += new System.EventHandler(this.btnLuu_HangHoa_Click);
            // 
            // btnBack_HangHoa
            // 
            this.btnBack_HangHoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack_HangHoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack_HangHoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack_HangHoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack_HangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack_HangHoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_HangHoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack_HangHoa.Location = new System.Drawing.Point(700, 78);
            this.btnBack_HangHoa.Name = "btnBack_HangHoa";
            this.btnBack_HangHoa.Size = new System.Drawing.Size(100, 32);
            this.btnBack_HangHoa.TabIndex = 17;
            this.btnBack_HangHoa.Text = "Ẩn";
            this.btnBack_HangHoa.UseVisualStyleBackColor = false;
            this.btnBack_HangHoa.Click += new System.EventHandler(this.btnBack_HangHoa_Click);
            // 
            // pnlThongTin_HangHoa
            // 
            this.pnlThongTin_HangHoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlThongTin_HangHoa.Controls.Add(this.label3);
            this.pnlThongTin_HangHoa.Controls.Add(this.txtMaNCC);
            this.pnlThongTin_HangHoa.Controls.Add(this.txtDonVi);
            this.pnlThongTin_HangHoa.Controls.Add(this.label2);
            this.pnlThongTin_HangHoa.Controls.Add(this.btnLuu_HangHoa);
            this.pnlThongTin_HangHoa.Controls.Add(this.btnClearText_HangHoa);
            this.pnlThongTin_HangHoa.Controls.Add(this.btnBack_HangHoa);
            this.pnlThongTin_HangHoa.Controls.Add(this.txtMaHangHoa);
            this.pnlThongTin_HangHoa.Controls.Add(this.txtTenHangHoa);
            this.pnlThongTin_HangHoa.Controls.Add(this.label10);
            this.pnlThongTin_HangHoa.Controls.Add(this.label1);
            this.pnlThongTin_HangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThongTin_HangHoa.Location = new System.Drawing.Point(0, 429);
            this.pnlThongTin_HangHoa.Name = "pnlThongTin_HangHoa";
            this.pnlThongTin_HangHoa.Size = new System.Drawing.Size(1129, 122);
            this.pnlThongTin_HangHoa.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Mã Nhà Cung Cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(439, 78);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(171, 23);
            this.txtMaNCC.TabIndex = 47;
            // 
            // btnClearText_HangHoa
            // 
            this.btnClearText_HangHoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearText_HangHoa.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnClearText_HangHoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnClearText_HangHoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.btnClearText_HangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearText_HangHoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearText_HangHoa.Location = new System.Drawing.Point(826, 78);
            this.btnClearText_HangHoa.Name = "btnClearText_HangHoa";
            this.btnClearText_HangHoa.Size = new System.Drawing.Size(100, 32);
            this.btnClearText_HangHoa.TabIndex = 18;
            this.btnClearText_HangHoa.Text = "Clear";
            this.btnClearText_HangHoa.UseVisualStyleBackColor = false;
            this.btnClearText_HangHoa.Click += new System.EventHandler(this.btnClearText_HangHoa_Click);
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHangHoa.Location = new System.Drawing.Point(117, 13);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(226, 23);
            this.txtMaHangHoa.TabIndex = 16;
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHangHoa.Location = new System.Drawing.Point(531, 16);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(300, 23);
            this.txtTenHangHoa.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Mã Hàng Hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên Hàng Hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHH,
            this.DonVi,
            this.MaNCC});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangHoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangHoa.Location = new System.Drawing.Point(1, 69);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvHangHoa.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvHangHoa.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangHoa.RowTemplate.Height = 25;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(1129, 482);
            this.dgvHangHoa.TabIndex = 13;
            // 
            // MaHH
            // 
            this.MaHH.HeaderText = "Mã Hàng Hóa";
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            // 
            // TenHH
            // 
            this.TenHH.HeaderText = "Tên Hàng Hóa";
            this.TenHH.Name = "TenHH";
            this.TenHH.ReadOnly = true;
            // 
            // DonVi
            // 
            this.DonVi.HeaderText = "Đơn Vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // MaNCC
            // 
            this.MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa_HangHoa);
            this.panel1.Controls.Add(this.btnSua_HangHoa);
            this.panel1.Controls.Add(this.btnThem_HangHoa);
            this.panel1.Controls.Add(this.cbOption_HangHoa);
            this.panel1.Controls.Add(this.txtSearch_HangHoa);
            this.panel1.Controls.Add(this.btnSearch_HangHoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 69);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnXoa_HangHoa
            // 
            this.btnXoa_HangHoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa_HangHoa.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnXoa_HangHoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnXoa_HangHoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnXoa_HangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_HangHoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_HangHoa.Location = new System.Drawing.Point(952, 18);
            this.btnXoa_HangHoa.Name = "btnXoa_HangHoa";
            this.btnXoa_HangHoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa_HangHoa.TabIndex = 5;
            this.btnXoa_HangHoa.Text = "Xóa";
            this.btnXoa_HangHoa.UseVisualStyleBackColor = false;
            this.btnXoa_HangHoa.Click += new System.EventHandler(this.btnXoa_HangHoa_Click);
            // 
            // btnSua_HangHoa
            // 
            this.btnSua_HangHoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua_HangHoa.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnSua_HangHoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnSua_HangHoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnSua_HangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_HangHoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_HangHoa.Location = new System.Drawing.Point(826, 18);
            this.btnSua_HangHoa.Name = "btnSua_HangHoa";
            this.btnSua_HangHoa.Size = new System.Drawing.Size(100, 32);
            this.btnSua_HangHoa.TabIndex = 4;
            this.btnSua_HangHoa.Text = "Sửa";
            this.btnSua_HangHoa.UseVisualStyleBackColor = false;
            this.btnSua_HangHoa.Click += new System.EventHandler(this.btnSua_HangHoa_Click);
            // 
            // btnThem_HangHoa
            // 
            this.btnThem_HangHoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem_HangHoa.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem_HangHoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem_HangHoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem_HangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_HangHoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_HangHoa.Location = new System.Drawing.Point(700, 18);
            this.btnThem_HangHoa.Name = "btnThem_HangHoa";
            this.btnThem_HangHoa.Size = new System.Drawing.Size(100, 32);
            this.btnThem_HangHoa.TabIndex = 3;
            this.btnThem_HangHoa.Text = "Thêm";
            this.btnThem_HangHoa.UseVisualStyleBackColor = false;
            this.btnThem_HangHoa.Click += new System.EventHandler(this.btnThem_HangHoa_Click);
            // 
            // cbOption_HangHoa
            // 
            this.cbOption_HangHoa.BackColor = System.Drawing.SystemColors.Control;
            this.cbOption_HangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption_HangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOption_HangHoa.FormattingEnabled = true;
            this.cbOption_HangHoa.Items.AddRange(new object[] {
            "Mã Hàng Hóa",
            "Tên Hàng Hóa"});
            this.cbOption_HangHoa.Location = new System.Drawing.Point(293, 22);
            this.cbOption_HangHoa.Name = "cbOption_HangHoa";
            this.cbOption_HangHoa.Size = new System.Drawing.Size(149, 28);
            this.cbOption_HangHoa.TabIndex = 1;
            this.cbOption_HangHoa.Tag = "";
            // 
            // txtSearch_HangHoa
            // 
            this.txtSearch_HangHoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_HangHoa.Location = new System.Drawing.Point(12, 22);
            this.txtSearch_HangHoa.Name = "txtSearch_HangHoa";
            this.txtSearch_HangHoa.Size = new System.Drawing.Size(275, 27);
            this.txtSearch_HangHoa.TabIndex = 0;
            // 
            // btnSearch_HangHoa
            // 
            this.btnSearch_HangHoa.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_HangHoa.Image")));
            this.btnSearch_HangHoa.Location = new System.Drawing.Point(448, 20);
            this.btnSearch_HangHoa.Name = "btnSearch_HangHoa";
            this.btnSearch_HangHoa.Size = new System.Drawing.Size(38, 34);
            this.btnSearch_HangHoa.TabIndex = 2;
            this.btnSearch_HangHoa.UseVisualStyleBackColor = true;
            this.btnSearch_HangHoa.Click += new System.EventHandler(this.btnSearch_HangHoa_Click);
            // 
            // UCHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 551);
            this.Controls.Add(this.pnlThongTin_HangHoa);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UCHangHoa";
            this.Text = "HangHoa";
            this.pnlThongTin_HangHoa.ResumeLayout(false);
            this.pnlThongTin_HangHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu_HangHoa;
        private System.Windows.Forms.Button btnBack_HangHoa;
        private System.Windows.Forms.Panel pnlThongTin_HangHoa;
        private System.Windows.Forms.Button btnClearText_HangHoa;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa_HangHoa;
        private System.Windows.Forms.Button btnSua_HangHoa;
        private System.Windows.Forms.Button btnThem_HangHoa;
        private System.Windows.Forms.ComboBox cbOption_HangHoa;
        private System.Windows.Forms.TextBox txtSearch_HangHoa;
        private System.Windows.Forms.Button btnSearch_HangHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
    }
}