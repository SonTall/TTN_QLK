using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.ENTITY
{
    class NhaCungCap
    {
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string SDT { get; set; }
       

        public NhaCungCap(string manhacungcap, string tennhacungcap, string sdt)
        {
            this.MaNhaCungCap = manhacungcap;
            this.TenNhaCungCap = tennhacungcap;
            this.SDT = sdt;
        }





    }
}
