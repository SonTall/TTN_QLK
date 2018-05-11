using QLKho.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DATA
{
    class NhaCungCap_Controller : SqlConn
    {
        public void editNhaCungCap(NhaCungCap ncc)
        {
            openConn();
            string query = "update NhaCungCap set TenNCC = @TenNCC, SDT = @SDT where MaNCC = @MaNCC";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNhaCungCap);
            cmd.Parameters.AddWithValue("@SDT", ncc.SDT);
            cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNhaCungCap);
            cmd.ExecuteNonQuery();
        }
        public void deleteNhaCungCap(NhaCungCap ncc)
        {
            openConn();
            string query = "delete from NhaCungCap where MaNCC = @MaNCC";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNhaCungCap);
            cmd.ExecuteNonQuery();
        }
    }
}
