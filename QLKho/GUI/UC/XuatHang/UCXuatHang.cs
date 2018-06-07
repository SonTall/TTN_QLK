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
using QLKho.DATA;
namespace QLKho.GUI.UC.XuatHang
{
    public partial class UCXuatHang : Form
    {
        public UCXuatHang()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }
        private void LockControl()
        {
            txtPhieuXuat.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtMaHangHoa.Enabled = false;
            dtNgayXuat.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaXuat.Enabled = false;
         //   txtTongTien.Enabled = false;
            btnClearText_XuatHang.Enabled = false;
            btnLuu_XuatHang.Enabled = false;
        }

        private void OpenControl()
        {
            txtPhieuXuat.Enabled = true;
            txtMaNhanVien.Enabled = true;
            txtMaHangHoa.Enabled = true;
            dtNgayXuat.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiaXuat.Enabled = true;
          //  txtTongTien.Enabled = true;
            btnClearText_XuatHang.Enabled = true;
            btnLuu_XuatHang.Enabled = true;
        }

        private void ClearText()
        {

            txtPhieuXuat.Text = "";
            txtMaNhanVien.Text = "";
            txtMaHangHoa.Text = "";
            dtNgayXuat.Value = DateTime.Now;
            txtSoLuong.Text = "0";
            txtGiaXuat.Text = "0";
            //    txtTongTien.Text = "";
            label_TongTien.Text = "0 ĐỒNG";
        }

        private void DataGridViewColStyle()
        {
            dgvXuatHang.BorderStyle = BorderStyle.None;
            dgvXuatHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvXuatHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvXuatHang.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvXuatHang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvXuatHang.BackgroundColor = Color.White;

            dgvXuatHang.EnableHeadersVisualStyles = false;
            dgvXuatHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvXuatHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvXuatHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSearch_XuatHang_Click(object sender, EventArgs e)
        {
            if (cbOption_XuatHang.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cbOption_XuatHang.Text.Equals("Mã Phiếu xuất"))
            {

            }

            if (cbOption_XuatHang.Text.Equals("Mã Hàng hóa"))
            {

            }

            if (cbOption_XuatHang.Text.Equals("Mã Nhân viên"))
            {

            }

            if (cbOption_XuatHang.Text.Equals("Tổng tiền"))
            {

            }
            if (cbOption_XuatHang.Text.Equals("Giá Xuất"))
            {

            }

            if (cbOption_XuatHang.Text.Equals("Số lượng"))
            {

            }
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

        public int add(int a, int b)
        {
            int c = a * b;
            return (c);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtSoLuong.Text);
                int b = int.Parse(txtGiaXuat.Text);
                string c = add(a, b).ToString();

                label_TongTien.Text = " " + formatDecimal(c).ToString() + " ĐỒNG ";

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void txtGiaXuat_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int a = int.Parse(txtSoLuong.Text);
                int b = int.Parse(txtGiaXuat.Text);



                string c = add(a, b).ToString();

                label_TongTien.Text = " " + formatDecimal(c).ToString() + " ĐỒNG ";
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            //  dgvNhapHang.DataSource = sql.getDataTable("NhanVien");
            // Liên kết với 2 bảng Phiếu nhập và Chi tiết nhập
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_XuatHang_Click(object sender, EventArgs e)
        {
            pnlThongTin.Visible = true;
            dgvXuatHang.Height = this.Height;
            ClearText();
            OpenControl();
        }

        private void btnBack_XuatHang_Click(object sender, EventArgs e)
        {
            pnlThongTin.Visible = false;
            dgvXuatHang.Height = this.Height;
        }

        private void btnClearText_XuatHang_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnLuu_XuatHang_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_XuatHang_Click(object sender, EventArgs e)
        {
            OpenControl();
        }

        private void btnXoa_XuatHang_Click(object sender, EventArgs e)
        {

        }

        

        private void UCXuatHang_Load(object sender, EventArgs e)
        {
            pnlThongTin.Visible = false;
            dgvXuatHang.Height = this.Height;
            
        }
        string sql = "";
        private void btnSearch_XuatHang_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P8I38NF\\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
                conn.Open();
                if (cbOption_XuatHang.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (cbOption_XuatHang.Text.Equals("Mã Phiếu Xuất"))
                {
                    sql = "select px.MaPX,Manv,MaHH,NgayXuat,SoLuong,GiaXuat,TongTien from ChiTietPX ct, PhieuXuat px where px.MaPX=ct.MaPX  and px.MaPX='" + txtPhieuXuat.Text.Trim() + "'";
                }

                if (cbOption_XuatHang.Text.Equals("Mã Hàng hóa"))
                {
                    sql = "select px.MaPX,Manv,MaHH,NgayXuat,SoLuong,GiaXuat,TongTien from ChiTietPX ct, PhieuXuat px where px.MaPX=ct.MaPX  and MaHH='" + txtMaHangHoa.Text.Trim() + "'";
                }

                if (cbOption_XuatHang.Text.Equals("Mã Nhân viên"))
                {
                    sql = "select px.MaPX,Manv,MaHH,NgayXuat,SoLuong,GiaXuat,TongTien from ChiTietPX ct, PhieuXuat px where px.MaPX=ct.MaPX  and Manv='" + txtMaNhanVien.Text.Trim() + "'";
                }

               
                if (cbOption_XuatHang.Text.Equals("Giá Nhập"))
                {
                    sql = "select px.MaPX,Manv,MaHH,NgayXuat,SoLuong,GiaXuat,TongTien from ChiTietPX ct, PhieuXuat px where px.MaPX=ct.MaPX   and GiaXuat='" + txtGiaXuat.Text.Trim() + "'";
                }

                if (cbOption_XuatHang.Text.Equals("Số lượng"))
                {
                    sql = "select px.MaPX,Manv,MaHH,NgayXuat,SoLuong,GiaXuat,TongTien from ChiTietPX ct, PhieuXuat px where px.MaPX=ct.MaPX   and SoLuong='" + txtSoLuong.Text.Trim() + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvXuatHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
