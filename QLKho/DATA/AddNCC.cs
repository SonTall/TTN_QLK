using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLKho.ENTITY;

namespace QLKho.DATA
{
    class AddNCC : SqlConn
    {
        public void addNCC(NhaCungCap ncc)
        {
            openConn();
            string query = "insert into NhaCungCap(MaNCC, TenNCC, SDT) values (@mancc, @tenncc, @sdt)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("MaNCC", ncc.MaNhaCungCap);
            cmd.Parameters.AddWithValue("TenNCC", ncc.TenNhaCungCap);
            cmd.Parameters.AddWithValue("SDT", ncc.SDT);

            cmd.ExecuteNonQuery();
        }
    }
}
