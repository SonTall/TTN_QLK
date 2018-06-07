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


namespace QLKho.GUI.UC.ThongKe
{
    public partial class UCThongKe : Form
    {

        public UCThongKe()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }

        //tùy chọn thống kê để hiển thị ra nhé

        private void UCThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }
        private void UCThongKe_Load(object sender, EventArgs e)
        {
            dgvThongKe.AutoResizeColumns();
            dgvThongKe.AutoResizeRows();
        }

        #region func
        
        private void DataGridViewColStyle()
        {
            dgvThongKe.BorderStyle = BorderStyle.None;
            dgvThongKe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvThongKe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvThongKe.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvThongKe.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvThongKe.BackgroundColor = Color.White;

            dgvThongKe.EnableHeadersVisualStyles = false;
            dgvThongKe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvThongKe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvThongKe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        #endregion
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbOption_ThongKe.Text.Equals("Số lượng hàng hóa"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.Statistic("select sum(a.soluong) as 'Số lượng hàng hóa' from (select count(MaHH) soluong from HangHoa group by MaHH) a");
            }

            if (cbOption_ThongKe.Text.Equals("Số lượng nhân viên"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.Statistic("select sum(a.soluong) as 'Số lượng phiếu xuất' from (select count(MaPX) soluong from PhieuXuat group by MaPX) a");
            }

            if (cbOption_ThongKe.Text.Equals("Số lượng phiếu nhập"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.Statistic("select sum(a.soluong) as 'Số lượng phiếu nhập' from (select count(MaPN) soluong from PhieuNhap group by MaPN) a");
            }

            if (cbOption_ThongKe.Text.Equals("Số lượng phiếu xuất"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.Statistic("select sum(a.soluong) as 'Số lượng phiếu xuất' from (select count(MaPX) soluong from PhieuXuat group by MaPX) a");
            }

            if (cbOption_ThongKe.Text.Equals("Số lượng hàng hóa theo nhà cung cấp"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.Statistic("select d.TenNCC, c.soluong from NhaCungCap d, (select a.MaNCC, (a.MaNCC) as soluong from HangHoa a, NhaCungCap b where a.MaNCC = b.MaNCC group by a.MaNCC) c where d.MaNCC = c.MaNCC");
            }

            if (cbOption_ThongKe.Text.Equals("Số lượng nhà cung cấp"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.Statistic("select sum(a.soluong) as 'Số lượng nhà cung cấp' from(select count(MaNCC) soluong from NhaCungCap group by MaNCC) a");
            }
            
        }
    }
}
