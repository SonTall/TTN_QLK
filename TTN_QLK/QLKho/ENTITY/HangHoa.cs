using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.ENTITY
{
    class HangHoa
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string DonVi { get; set; }
        public string MaNCC { get; set; }


        public HangHoa(string maHH, string tenHH, string donvi, string manccc)
        {
            this.MaHH = maHH;
            this.TenHH = tenHH;
            this.DonVi = donvi;
            this.MaNCC = manccc;
        }
    }



}
