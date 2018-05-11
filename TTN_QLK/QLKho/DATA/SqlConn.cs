using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKho.DATA
{
    class SqlConn
    {
        //  string connString = @"Data Source=HIEP\SQLEXPRESS;Initial Catalog=ThucTapNhom_QuanLyTruongTHPT;Integrated Security=True";
        string connString = @"Data Source = .; Initial Catalog = QLKHO; Integrated Security = True ";

        SqlConnection conn = null;

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public SqlConn()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connString);
            }
        }

        public void openConn()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connString);
            }
            conn.Open();
        }
        public void closeConn()
        {
            conn.Close();
        }

        public DataTable getDataTable(string table)
        {
            openConn();
            string query = "select * from " + table;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            cmd.Dispose();
            return dt;
        }

        public DataTable searchQuery(string table, string x)
        {
            openConn();
            string query = "select * from " + table + "where" + x;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter db = new SqlDataAdapter(cmd);
            DataTable dc = new DataTable();
            db.Fill(dc);
            db.Dispose();
            cmd.Dispose();
            return dc;
        }


    }
}




