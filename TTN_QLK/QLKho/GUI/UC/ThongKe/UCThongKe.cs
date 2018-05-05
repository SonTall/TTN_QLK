using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            DataGridViewColStyle();
        }

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
    }
}
