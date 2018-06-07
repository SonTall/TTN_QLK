using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.ENTITY
{
    class PhieuNhap
    {
        public string MaPN { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayNhap { get; set; }



        public PhieuNhap(string mapn, string manv, DateTime ngaynhap)
        {
            this.MaPN = mapn;
            this.MaNV = manv;
            this.NgayNhap = ngaynhap;

        }
    }
}
