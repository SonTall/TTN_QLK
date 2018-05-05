using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLKho.ENTITY;


namespace QLKho.DATA
{
    class AddHangHoa : SqlConn
    {
        public void addHangHoa(HangHoa hh)
        {
            openConn();
            string query = "insert into HangHoa(MaHH, TenHH, DonVi, MaNCC) values (@mahh, @tenhh, @donvi, @mancc)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("MaHH", hh.MaHH);
            cmd.Parameters.AddWithValue("TenHH", hh.TenHH);
            cmd.Parameters.AddWithValue("DonVi", hh.DonVi);
            cmd.Parameters.AddWithValue("MaNCC", hh.MaNCC);

            cmd.ExecuteNonQuery();
        }
    }
}
