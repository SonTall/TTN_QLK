using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho.GUI.UC.NhaCungCap
{
    public partial class UCNhaCungCap : Form
    {
        bool kt;
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
            kt = true;
            pnlThongTin_NCC.Visible = true;
            dgvNhaCungCap.Height = this.Height;
            ClearText();
            OpenControl();
        }

        private void btnSua_NCC_Click(object sender, EventArgs e)
        {
            kt = false;
            OpenControl();
        }

        private void btnXoa_NCC_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (check == DialogResult.Yes)
            {
                ENTITY.NhaCungCap ncc = new ENTITY.NhaCungCap(txtMaNCC.Text.Trim(), txtTenNCC.Text.Trim(), txtSDTNCC.Text.Trim());
                DATA.NhaCungCap_Controller n = new DATA.NhaCungCap_Controller();
                n.deleteNhaCungCap(ncc);
            }
            loadDataGirdView();
            LockControl();
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
            if (kt == true)
            {
                DATA.AddNCC c = new DATA.AddNCC();
                c.addNCC(ncc);
            }
            else
            {
                DATA.NhaCungCap_Controller n = new DATA.NhaCungCap_Controller();
                n.editNhaCungCap(ncc);
            }
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

        private void dgvNhaCungCap_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhaCungCap_MouseClick_1(object sender, MouseEventArgs e)
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
    }
}
