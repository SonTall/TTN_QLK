using QLKho.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DATA
{
    class NhanVien_Controller : SqlConn
    {
        public void editNhanVien(NhanVien nv)
        {
            openConn();
            string query = "update NhanVien set TenNV = @TenNV, SDT = @SDT where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
            cmd.Parameters.AddWithValue("@SDT", nv.SDT);
            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
            cmd.ExecuteNonQuery();
        }
        public void deleteNhanVien(NhanVien nv)
        {
            openConn();
            string query = "delete from NhanVien where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
            cmd.ExecuteNonQuery();
        }
    }
}
