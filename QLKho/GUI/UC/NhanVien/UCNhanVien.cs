﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKho.DATA;




namespace QLKho.GUI.UC.NhanVien
{
    public partial class UCNhanVien : Form
    {
        public UCNhanVien()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }
        private void LockControl()
        {
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtSDTNhanVien.Enabled = false;
            btnClearText_NhanVien.Enabled = false;
            btnLuu_NhanVien.Enabled = false;
        }

        private void OpenControl()
        {
            txtMaNhanVien.Enabled = true;
            txtTenNhanVien.Enabled = true;
            txtSDTNhanVien.Enabled = true;
            btnClearText_NhanVien.Enabled = true;
            btnClearText_NhanVien.Enabled = true;
        }

        private void ClearText()
        {
            
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtSDTNhanVien.Text = "";
        }
        string sql = "";
        private void btnSearch_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P8I38NF\\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
                conn.Open();
                if (cbOption_NhanVien.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (cbOption_NhanVien.Text.Equals("Mã Nhân Viên"))
                {
                    sql = "select * from NhanVien nv where nv.MaNV='" + txtSearch_NhanVien.Text.Trim() + "'";
                }

                if (cbOption_NhanVien.Text.Equals("Họ và Tên"))
                {
                    sql = "select * from NhanVien nv where  nv.TenNV='" + txtSearch_NhanVien.Text.Trim() + "'";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNhanVien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            pnlThongTin_NhanVien.Visible = false;
            dgvNhanVien.Height = this.Height;
        }

        private void DataGridViewColStyle()
        {
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvNhanVien.BackgroundColor = Color.White;

            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            dgvNhanVien.DataSource = sql.getDataTable("NhanVien");
        }

        private void pnlThongTin_NhanVien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_NhanVien_Click(object sender, EventArgs e)
        {
            pnlThongTin_NhanVien.Visible = true;
            dgvNhanVien.Height = this.Height;
            ClearText();
            OpenControl();
        }

        private void dgvNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            LockControl();
            pnlThongTin_NhanVien.Visible = true;
            dgvNhanVien.Height = 481;

            if(dgvNhanVien.Rows.Count > 0)
            {
                txtMaNhanVien.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
                txtSDTNhanVien.Text = dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
        
        private void btnSua_NhanVien_Click(object sender, EventArgs e)
        {
            OpenControl();
        }

        private void btnBack_NhanVien_Click(object sender, EventArgs e)
        {
            pnlThongTin_NhanVien.Visible = false;
            dgvNhanVien.Height = this.Height;
        }

        private void btnLuu_NhanVien_Click(object sender, EventArgs e)
        {
            ENTITY.NhanVien bd = new ENTITY.NhanVien(txtMaNhanVien.Text.Trim(), txtTenNhanVien.Text.Trim(), txtSDTNhanVien.Text.Trim());
            DATA.AddNhanVien b = new DATA.AddNhanVien();
            b.addNhanVien(bd);
            loadDataGirdView();
            LockControl();
        }

        private void btnClearText_NhanVien_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnXoa_NhanVien_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbOption_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_NhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSDTNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



