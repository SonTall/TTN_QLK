using QLKho.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DATA
{
    class HangHoa_Controller : SqlConn
    {
        public void editHangHoa(HangHoa hh)
        {
            openConn();
            string query = "update HangHoa set TenHH = @TenHH, DonVi = @DonVi, MaNCC = @MaNCC where MaHH = @MaHH";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@TenHH", hh.TenHH);
            cmd.Parameters.AddWithValue("@DonVi", hh.DonVi);
            cmd.Parameters.AddWithValue("@MaNCC", hh.MaNCC);
            cmd.Parameters.AddWithValue("@MaHH", hh.MaHH);
            cmd.ExecuteNonQuery();
        }
        public void deleteHangHoa(HangHoa hh)
        {
            openConn();
            string query = "delete from HangHoa where MaHH = @MaHH";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaHH", hh.MaHH);
            cmd.ExecuteNonQuery();
        }
    }
}
