using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLKho.ENTITY;

namespace QLKho.DATA
{
    class AddNhanVien : SqlConn
    {
        public void addNhanVien(NhanVien nv)
        {
            openConn();
            string query = "insert into NhanVien(MaNV, TenNV, SDT) values(@manv, @tennv, @sdt)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("TenNV", nv.TenNV);
            cmd.Parameters.AddWithValue("SDT", nv.SDT);
            
            cmd.ExecuteNonQuery();
        }
    }
}
