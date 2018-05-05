using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.GUI.UC.HangHoa;
using QLKho.GUI.UC.HoTro;
using QLKho.GUI.UC.NhanVien;
using QLKho.GUI.UC.NhapHang;
using QLKho.GUI.UC.ThongKe;

using QLKho.GUI.UC.NhaCungCap;
using QLKho.GUI.UC.XuatHang;
using QLKho.GUI.UC.HangHoa;
using QLKho.GUI.UC.HoTro;
using QLKho.GUI.UC.NhanVien;
using QLKho.GUI.UC.NhapHang;
using QLKho.GUI.UC.ThongKe;

using QLKho.GUI.UC.NhaCungCap;
using QLKho.GUI.UC.XuatHang;


namespace QLKho
{
    public partial class Form1 : Form
    {
        private void ClearRenderbody()
        {
            // while (pnlBody.Controls.Count > 0) pnlBody.Controls[pnlBody.Controls.Count - 1].Dispose();
            //foreach (Control ctrl in RenderBody.Controls) ctrl.Dispose();
            while (pnlFill.Controls.Count > 0) pnlFill.Controls[pnlFill.Controls.Count - 1].Dispose();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCNhanVien uCNhanVien = new UCNhanVien();
            uCNhanVien.TopLevel = false;
            uCNhanVien.Width = pnlFill.Width;
            uCNhanVien.Height = pnlFill.Height;
            uCNhanVien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlFill.Controls.Add(uCNhanVien);
            uCNhanVien.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCNhaCungCap uCNhaCungCap = new UCNhaCungCap();
            uCNhaCungCap.TopLevel = false;
            uCNhaCungCap.Width = pnlFill.Width;
            uCNhaCungCap.Height = pnlFill.Height;
            uCNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlFill.Controls.Add(uCNhaCungCap);
            uCNhaCungCap.Show();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCHangHoa uCHangHoa = new UCHangHoa();
            uCHangHoa.TopLevel = false;
            uCHangHoa.Width = pnlFill.Width;
            uCHangHoa.Height = pnlFill.Height;
            uCHangHoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlFill.Controls.Add(uCHangHoa);
            uCHangHoa.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCNhapHang uCNhapHang = new UCNhapHang();
            uCNhapHang.TopLevel = false;
            uCNhapHang.Width = pnlFill.Width;
            uCNhapHang.Height = pnlFill.Height;
            uCNhapHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlFill.Controls.Add(uCNhapHang);
            uCNhapHang.Show();
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCXuatHang uCXuatHang = new UCXuatHang();
            uCXuatHang.TopLevel = false;
            uCXuatHang.Width = pnlFill.Width;
            uCXuatHang.Height = pnlFill.Height;
            uCXuatHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlFill.Controls.Add(uCXuatHang);
            uCXuatHang.Show();
        }

      

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCThongKe uCThongKe = new UCThongKe();
            uCThongKe.TopLevel = false;
            uCThongKe.Width = pnlFill.Width;
            uCThongKe.Height = pnlFill.Height;
            uCThongKe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlFill.Controls.Add(uCThongKe);
            uCThongKe.Show();
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCHoTro uCHotro = new UCHoTro();
            uCHotro.TopLevel = false;
            uCHotro.Width = pnlFill.Width;
            uCHotro.Height = pnlFill.Height;
            uCHotro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlFill.Controls.Add(uCHotro);
            uCHotro.Show();
        }

        private void ptBHome_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            pnlFill.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
