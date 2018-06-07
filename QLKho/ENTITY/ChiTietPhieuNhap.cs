using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.ENTITY
{
    class ChiTietPhieuNhap
    {
        public string MaPN;
        public string MaHH;
        public string SoLuong;
        public string GiaNhap;
        public string TongTien;

        public ChiTietPhieuNhap(string mapn, string mahh, string soluong, string gianhap, string tongtien)
        {
            this.MaPN = mapn;
            this.MaHH = mahh;
            this.SoLuong = soluong;
            this.GiaNhap = gianhap;
            this.TongTien = tongtien;
        }
    }
}
