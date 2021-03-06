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

namespace QLKho.GUI.UC.NhaCungCap
{
    public partial class UCNhaCungCap : Form
    {
        public UCNhaCungCap()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }
        private void LockControl()
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtSDTNCC.Enabled = false;
            btnClearText_NCC.Enabled = false;
            btnLuu_NCC.Enabled = false;
        }

        private void OpenControl()
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtSDTNCC.Enabled = true;
            btnClearText_NCC.Enabled = true;
            btnLuu_NCC.Enabled = true;
        }

        private void ClearText()
        {

            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDTNCC.Text = "";
        }
        private void btnSearch_NhanVien_Click(object sender, EventArgs e)
        {
            if (cbOption_NCC.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cbOption_NCC.Text.Equals("Mã Nhà Cung Cấp"))
            {

            }

            if (cbOption_NCC.Text.Equals("Họ và Tên"))
            {

            }
        }

        private void DataGridViewColStyle()
        {
            dgvNhaCungCap.BorderStyle = BorderStyle.None;
            dgvNhaCungCap.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvNhaCungCap.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhaCungCap.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvNhaCungCap.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvNhaCungCap.BackgroundColor = Color.White;

            dgvNhaCungCap.EnableHeadersVisualStyles = false;
            dgvNhaCungCap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhaCungCap.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvNhaCungCap.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            dgvNhaCungCap.DataSource = sql.getDataTable("NhaCungCap");

        }

        private void btnThem_NCC_Click(object sender, EventArgs e)
        {
            pnlThongTin_NCC.Visible = true;
            dgvNhaCungCap.Height = this.Height;
            ClearText();
            OpenControl();
        }

        private void btnSua_NCC_Click(object sender, EventArgs e)
        {
            OpenControl();
        }

        private void btnXoa_NCC_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_NCC_Click(object sender, EventArgs e)
        {
            pnlThongTin_NCC.Visible = false;
            dgvNhaCungCap.Height = this.Height;
        }

        private void btnClearText_NCC_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnLuu_NCC_Click(object sender, EventArgs e)
        {
            ENTITY.NhaCungCap ncc = new ENTITY.NhaCungCap(txtMaNCC.Text.Trim(), txtTenNCC.Text.Trim(), txtSDTNCC.Text.Trim());
            DATA.AddNCC c = new DATA.AddNCC();
            c.addNCC(ncc);
            loadDataGirdView();
            LockControl();
        }

        private void dgvNhaCungCap_MouseClick(object sender, MouseEventArgs e)
        {
            LockControl();
            pnlThongTin_NCC.Visible = true;
            dgvNhaCungCap.Height = 481;

            if (dgvNhaCungCap.Rows.Count > 0)
            {
                txtMaNCC.Text = dgvNhaCungCap.SelectedRows[0].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNhaCungCap.SelectedRows[0].Cells[1].Value.ToString();
                txtSDTNCC.Text = dgvNhaCungCap.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void UCNhaCungCap_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            pnlThongTin_NCC.Visible = false;
            dgvNhaCungCap.Height = this.Height;
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string sql = "";
       

        private void btnSearch_NCC_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P8I38NF\\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
                conn.Open();
                if (cbOption_NCC.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (cbOption_NCC.Text.Equals("Mã Nhà Cung Cấp"))
                {
                    sql = "select * from NhaCungCap ncc where MaNCC='" + txtSearch_NCC.Text.Trim() + "'";
                }

                if (cbOption_NCC.Text.Equals("Họ Tên"))
                {
                    sql = "select ncc.MaNCC, TenNCC,SDT from NhaCungCap ncc,HangHoa hh where ncc.MaNCC=hh.MaNCC and ncc.TenNCC='" + txtSearch_NCC.Text.Trim() + "'";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNhaCungCap.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
