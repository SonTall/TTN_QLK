namespace QLKho.GUI.UC.ThongKe
{
    partial class UCThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCThongKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.lbThongKe = new System.Windows.Forms.Label();
            this.cbOption_ThongKe = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.lbThongKe);
            this.panel1.Controls.Add(this.cbOption_ThongKe);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 69);
            this.panel1.TabIndex = 11;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.Control;
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(880, 22);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(146, 32);
            this.btn.TabIndex = 6;
            this.btn.Text = "In danh sách";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbThongKe
            // 
            this.lbThongKe.AutoSize = true;
            this.lbThongKe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKe.Location = new System.Drawing.Point(782, 25);
            this.lbThongKe.Name = "lbThongKe";
            this.lbThongKe.Size = new System.Drawing.Size(0, 21);
            this.lbThongKe.TabIndex = 3;
            // 
            // cbOption_ThongKe
            // 
            this.cbOption_ThongKe.BackColor = System.Drawing.SystemColors.Control;
            this.cbOption_ThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOption_ThongKe.FormattingEnabled = true;
            this.cbOption_ThongKe.Items.AddRange(new object[] {
            "Số lượng hàng hóa",
            "Số lượng nhân viên",
            "Số lượng phiếu nhập",
            "Số lượng phiếu xuất",
            "Số lượng nhà cung cấp",
            "Số lượng hàng hóa theo nhà cung cấp"});
            this.cbOption_ThongKe.Location = new System.Drawing.Point(12, 22);
            this.cbOption_ThongKe.Name = "cbOption_ThongKe";
            this.cbOption_ThongKe.Size = new System.Drawing.Size(339, 28);
            this.cbOption_ThongKe.TabIndex = 1;
            this.cbOption_ThongKe.Tag = "";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.Location = new System.Drawing.Point(357, 20);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(34, 34);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 0);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvThongKe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvThongKe.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.RowTemplate.Height = 25;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(1129, 551);
            this.dgvThongKe.TabIndex = 12;
            // 
            // UCThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UCThongKe";
            this.Text = "ThongKe";
            this.Click += new System.EventHandler(this.UCThongKe_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbThongKe;
        private System.Windows.Forms.ComboBox cbOption_ThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvThongKe;
    }
}