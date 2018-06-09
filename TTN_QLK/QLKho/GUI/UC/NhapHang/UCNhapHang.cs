using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho.GUI.UC.NhapHang
{
    public partial class UCNhapHang : Form
    {
        public UCNhapHang()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }
        private void LockControl()
        {
            txtPhieuNhap.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtMaHangHoa.Enabled = false;
            dtNgayNhap.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaNhap.Enabled = false;
           // txtTongTien.Enabled = false;
            btnClearText_NhapHang.Enabled = false;
            btnLuu_NhapHang.Enabled = false;
        }

        private void OpenControl()
        {
            txtPhieuNhap.Enabled = true;
            txtMaNhanVien.Enabled = true;
            txtMaHangHoa.Enabled = true;
            dtNgayNhap.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiaNhap.Enabled = true;
        //    txtTongTien.Enabled = true;
            btnClearText_NhapHang.Enabled = true;
            btnLuu_NhapHang.Enabled = true;
        }

        private void ClearText()
        {

            txtPhieuNhap.Text = "";
            txtMaNhanVien.Text = "";
            txtMaHangHoa.Text = "";
            dtNgayNhap.Value = DateTime.Now;
            txtSoLuong.Text = "0";
            txtGiaNhap.Text = "0";
            //    txtTongTien.Text = "";
            label_TongTien.Text = "0 ĐỒNG";
        }


        private void btnThem_NhapHang_Click(object sender, EventArgs e)
        {
            pnlThongTin.Visible = true;
            dgvNhapHang.Height = this.Height;
        }
        private void DataGridViewColStyle()
        {
            dgvNhapHang.BorderStyle = BorderStyle.None;
            dgvNhapHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvNhapHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhapHang.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvNhapHang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvNhapHang.BackgroundColor = Color.White;

            dgvNhapHang.EnableHeadersVisualStyles = false;
            dgvNhapHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhapHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvNhapHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dgvNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_NhapHang_Click(object sender, EventArgs e)
        {

        }

        private void btnClearText_NhapHang_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnBack_NhapHang_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        public string formatDecimal(string s)
        {
            string stmp = s;
            int amount;
            amount = (int)(s.Length / 3);
            if (s.Length % 3 == 0)
                amount--;
            for (int i = 1; i <= amount; i++)
            {
                stmp = stmp.Insert(stmp.Length - 4 * i + 1, ",");
            }
            return stmp;
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a= int.Parse(txtSoLuong.Text);
                int b = int.Parse(txtGiaNhap.Text);
                string c = add(a, b).ToString();

                label_TongTien.Text = " " + formatDecimal(c).ToString() + " ĐỒNG ";

            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

      /*  int a = int.Parse(txtSoLuong.Text);
        int b = int.Parse(txtGiaNhap.Text);

        label4.Text = " " + add(a, b).ToString() + " ĐỒNG ";
        */
      public int add(int a, int b)
        {
            int c = a * b;
            return (c);
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {

            try
            {
                
                int a = int.Parse(txtSoLuong.Text);
                int b = int.Parse(txtGiaNhap.Text);

                
                
                string c = add(a, b).ToString();

                label_TongTien.Text = " " + formatDecimal(c).ToString() + " ĐỒNG ";
             //   string s = txtGiaNhap.Text;
             //   txtGiaNhap.Text = formatDecimal(s).ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void txtMaHangHoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_NhapHang_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLKho;Integrated Security=True");
                conn.Open();
                if (cbOption_NhapHang.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (cbOption_NhapHang.Text.Equals("Mã Phiếu nhập"))
                {
                    sql = "select pn.MaPN,Manv,MaHH,NgayNhap,SoLuong,GiaNhap,TongTien from ChiTietPN ct, PhieuNhap pn where pn.MaPN=ct.MaPN  and pn.MaPN='" + txtSearch_NhapHang.Text.Trim() + "'";
                }

                if (cbOption_NhapHang.Text.Equals("Mã Hàng hóa"))
                {
                    sql = "select pn.MaPN,Manv,MaHH,NgayNhap,SoLuong,GiaNhap,TongTien from ChiTietPN ct, PhieuNhap pn where pn.MaPN=ct.MaPN  and MaHH='" + txtSearch_NhapHang.Text.Trim() + "'";
                }

                if (cbOption_NhapHang.Text.Equals("Mã Nhân viên"))
                {
                    sql = "select pn.MaPN,Manv,MaHH,NgayNhap,SoLuong,GiaNhap,TongTien from ChiTietPN ct, PhieuNhap pn where pn.MaPN=ct.MaPN  and MaNV='" + txtSearch_NhapHang.Text.Trim() + "'";
                }

                if (cbOption_NhapHang.Text.Equals("Tổng tiền"))
                {
                    sql = "select pn.MaPN,Manv,MaHH,NgayNhap,SoLuong,GiaNhap,TongTien from ChiTietPN ct, PhieuNhap pn where pn.MaPN=ct.MaPN  and TonGien='" +txtSearch_NhapHang.Text.Trim() + "'";
                }
                if (cbOption_NhapHang.Text.Equals("Giá Nhập"))
                {
                    sql = "select pn.MaPN,Manv,MaHH,NgayNhap,SoLuong,GiaNhap,TongTien from ChiTietPN ct, PhieuNhap pn where pn.MaPN=ct.MaPN  and GiaNhap='" + txtSearch_NhapHang.Text.Trim() + "'";
                }

                if (cbOption_NhapHang.Text.Equals("Số lượng"))
                {
                    sql = "select pn.MaPN,Manv,MaHH,NgayNhap,SoLuong,GiaNhap,TongTien from ChiTietPN ct, PhieuNhap pn where pn.MaPN=ct.MaPN  and SoLuong='" + txtSearch_NhapHang.Text.Trim() + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNhapHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_NhapHang_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_NhapHang_Click(object sender, EventArgs e)
        {

        }

        private void cbOption_NhapHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_NhapHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlBody_NhapHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhieuNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMaPN_Click(object sender, EventArgs e)
        {

        }

        private void UCNhapHang_Load(object sender, EventArgs e)
        {
            //  loadDataGirdView();
            pnlThongTin.Visible = false;
            dgvNhapHang.Height = this.Height;
        }
        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
          //  dgvNhapHang.DataSource = sql.getDataTable("NhanVien");
          // Liên kết với 2 bảng Phiếu nhập và Chi tiết nhập
        }
    }
}
