using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Loai_SPDAL : ConnectDAL
    {
        public DataTable getLoaiSP()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAI_SP", connect);
            DataTable dtLoaiSP = new DataTable();
            da.Fill(dtLoaiSP);
            return dtLoaiSP;
        }


        public bool themLoaiSP(DTO_LoaiSP lsp)
        {
            try
            {
                // Ket noi
                connect.Open();


                string SQL = string.Format("INSERT INTO LOAISP (MaLoaiSP, TenLoaiSP) " +
                                           "VALUES ('{0}', N'{1}') ",
                                           lsp.MaLoaiSP, lsp.TenLoaiSP); // DỮ LIỆU NHẬP VÀO

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, connect);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                connect.Close();
            }

            return false;
        }


        public bool suaLoaiSP(DTO_LoaiSP lsp)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string
                string SQL = string.Format("UPDATE LOAI_SP " +
                                           "SET TenLoaiSP= N'{1}' " +
                                           "WHERE MaLoaiSP='{0}'",
                                           lsp.MaLoaiSP, lsp.TenLoaiSP);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, connect);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                connect.Close();
            }

            return false;
        }


        public bool xoaLoaiSP(string maLoai)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM LOAI_SP WHERE MaLoaiSP = {0}", maLoai);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, connect);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                connect.Close();
            }

            return false;
        }
        public DataTable timKiemLoaiSP(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAI_SP " +
                                                   "WHERE MaLoaiSP LIKE '%" + name + "%' OR TenLoaiSP LIKE N'%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
    }
}
