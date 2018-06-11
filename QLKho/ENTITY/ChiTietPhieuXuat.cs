using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.ENTITY
{
    class ChiTietPhieuXuat
    {
        public string MaPX;
        public string MaHH;
        public string SoLuong;
        public string GiaNhap;
        public string TongTien;

        public ChiTietPhieuXuat(string mapx, string mahh, string soluong, string gianhap, string tongtien)
        {
            this.MaPX = mapx;
            this.MaHH = mahh;
            this.SoLuong = soluong;
            this.GiaNhap = gianhap;
            this.TongTien = tongtien;
        }

        public object GiaXuat { get; set; }
    }
}
