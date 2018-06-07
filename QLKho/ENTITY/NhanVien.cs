using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.ENTITY
{
    class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }


        public NhanVien(string manv, string tennv, string sdt)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.SDT = sdt;
        }
    }
}
