using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKho.GUI.UC.HangHoa
{
    public partial class UCHangHoa : Form
    {
        public UCHangHoa()
        {
            InitializeComponent();
        }

        private void LockControl()
        {
            txtMaHangHoa.Enabled = false;
            txtTenHangHoa.Enabled = false;
            txtDonVi.Enabled = false;
            txtMaNCC.Enabled = false;
            btnClearText_HangHoa.Enabled = false;
            btnLuu_HangHoa.Enabled = false;
        }

        private void OpenControl()
        {
            txtMaHangHoa.Enabled = true;
            txtTenHangHoa.Enabled = true;
            txtDonVi.Enabled = true;
            txtMaNCC.Enabled = true;
            btnClearText_HangHoa.Enabled = true;
            btnClearText_HangHoa.Enabled = true;
        }

        private void ClearText()
        {

            txtMaHangHoa.Text = "";
            txtTenHangHoa.Text = "";
            txtDonVi.Text = "";
            txtMaNCC.Text = "";
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            pnlThongTin_HangHoa.Visible = false;
            dgvHangHoa.Height = this.Height;
        }

        private void DataGridViewColStyle()
        {
            dgvHangHoa.BorderStyle = BorderStyle.None;
            dgvHangHoa.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvHangHoa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHangHoa.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvHangHoa.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvHangHoa.BackgroundColor = Color.White;

            dgvHangHoa.EnableHeadersVisualStyles = false;
            dgvHangHoa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHangHoa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvHangHoa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            dgvHangHoa.DataSource = sql.getDataTable("HangHoa");
          //  DATA.SqlConn sql = new DATA.SqlConn();
         //   dgvHangHoa.DataSource = sql.getDataTable("HangHoa");

        }
        
       
        private void txtSDTNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_HangHoa_Click(object sender, EventArgs e)
        {
            
                if (cbOption_HangHoa.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (cbOption_HangHoa.Text.Equals("Mã Hàng Hóa"))
                {

                }

                if (cbOption_HangHoa.Text.Equals("Tên Hàng Hóa"))
                {

                }
            
        }
        // Xem them tai cac View code cua UCNhanVien,...

        private void btnThem_HangHoa_Click(object sender, EventArgs e)
        {
            pnlThongTin_HangHoa.Visible = true;
            dgvHangHoa.Height = this.Height;
            ClearText();
            OpenControl();
        }

        private void btnSua_HangHoa_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_HangHoa_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_HangHoa_Click(object sender, EventArgs e)
        {
            pnlThongTin_HangHoa.Visible = false;
            dgvHangHoa.Height = this.Height;
        }

        private void btnClearText_HangHoa_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnLuu_HangHoa_Click(object sender, EventArgs e)
        {
            ENTITY.HangHoa hh = new ENTITY.HangHoa(txtMaHangHoa.Text.Trim(), txtTenHangHoa.Text.Trim(), txtDonVi.Text.Trim(), txtMaNCC.Text.Trim());

            DATA.AddHangHoa b = new DATA.AddHangHoa();
            b.addHangHoa(hh);
            loadDataGirdView();
            LockControl();
        }
    }
}
