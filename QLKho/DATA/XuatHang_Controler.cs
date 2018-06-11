using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLKho.ENTITY;

namespace QLKho.DATA
{
    class XuatHang_Controler : SqlConn
    {
        public void addPhieuXuat(PhieuXuat px)
        {
            openConn();
            string query = "insert into PhieuXuat(MaPX, MaNV, NgayXuat) values (@MaPX, @MaNV, @NgayXuat)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("MaPX", px.MaPX);
            cmd.Parameters.AddWithValue("MaNV", px.MaNV);
            cmd.Parameters.AddWithValue("NgayXuat", px.NgayXuat);

            cmd.ExecuteNonQuery();
            closeConn();
        }
        public void addChiTietPX(ChiTietPhieuXuat ctpx)
        {
            openConn();
            string query = "insert into ChiTietPX(MaPX, MaHH, SoLuong, GiaXuat, TongTien) values (@MaPX, @MaHH, @SoLuong, @GiaXuat, @TongTien)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("MaPX", ctpx.MaPX);
            cmd.Parameters.AddWithValue("MaHH", ctpx.MaHH);
            cmd.Parameters.AddWithValue("SoLuong", ctpx.SoLuong);
            cmd.Parameters.AddWithValue("GiaXuat", ctpx.GiaXuat);
            cmd.Parameters.AddWithValue("TongTien", ctpx.TongTien);
            cmd.ExecuteNonQuery();
        }
        public void editPhieuXuat(PhieuXuat px)
        {
            openConn();
            string query = "update PhieuXuat set MaPX = @MaPX, MaNV = @MaNV, NgayXuat = @NgayXuat where MaPX = @MaPX";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("MaPX", px.MaPX);
            cmd.Parameters.AddWithValue("MaNV", px.MaNV);
            cmd.Parameters.AddWithValue("NgayXuat", px.NgayXuat);
            cmd.ExecuteNonQuery();
            closeConn();
        }

        public void editChiTietPhieuXuat(ChiTietPhieuXuat ctpx)
        {
            openConn();
            string query = "update ChiTietPX set MaPX = @MaPX, MaHH = @MaHH, SoLuong = @SoLuong, GiaXuat = @GiaXuat, TongTien = @TongTien where MaPX = @MaPX";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("MaPX", ctpx.MaPX);
            cmd.Parameters.AddWithValue("MaHH", ctpx.MaHH);
            cmd.Parameters.AddWithValue("SoLuong", ctpx.SoLuong);
            cmd.Parameters.AddWithValue("GiaXuat", ctpx.GiaXuat);
            cmd.Parameters.AddWithValue("TongTien", ctpx.TongTien);
            cmd.ExecuteNonQuery();
        }
        public void deletePhieuXuat(PhieuXuat px)
        {
            openConn();
            string query = "delete from PhieuXuat where MaPX = @MaPX";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaPX", px.MaPX);
            cmd.ExecuteNonQuery();
        }
        public void deleteChiTietPhieuXuat(ChiTietPhieuXuat ctpx)
        {
            openConn();
            string query = "delete from ChiTietPX where MaPX = '@MaPX'";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaPX", ctpx.MaPX);
            cmd.ExecuteNonQuery();
        }
    }
}
