using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.ENTITY
{
    class PhieuXuat
    {
        public string MaPX;
        public string MaNV;
        public DateTime NgayXuat;



        public PhieuXuat(string mapx, string manv, DateTime ngayxuat)
        {
            this.MaPX = mapx;
            this.MaNV = manv;
            this.NgayXuat = ngayxuat;

        }
    }
}
