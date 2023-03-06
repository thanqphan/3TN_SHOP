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
    public class NhaCungCapDAL : ConnectDAL
    {
        public DataTable getNhaCungCap()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHACUNGCAP", connect);
            DataTable dtNhaCungCap = new DataTable();
            da.Fill(dtNhaCungCap);
            return dtNhaCungCap;
        }


        public bool themNhaCungCap(DTO_NhaCungCap ncc)
        {
            try
            {
                // Ket noi
                connect.Open();


                string SQL = string.Format("INSERT INTO NHACUNGCAP (MaNCC, TenNCC, DiaChi, SDT, TrangThai) " +
                                           "VALUES ('{0}', N'{1}', N'{2}', '{3}',N'{4}') ",
                                           ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT, ncc.TrangThai); // DỮ LIỆU NHẬP VÀO

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


        public bool suaNhaCungCap(DTO_NhaCungCap ncc)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string
                string SQL = string.Format("UPDATE NHACUNGCAP " +
                                           "SET TenNCC= N'{1}', DiaChi=N'{2}', SDT='{3}', TrangThai=N'{4}' " +
                                           "WHERE MaNCC='{0}'",
                                           ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT, ncc.TrangThai);

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


        public bool xoaNhaCungCap(string maNCC)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM NHACUNGCAP WHERE MaNCC = '{0}'", maNCC);

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
        public DataTable timKiemNhaCungCap(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHACUNGCAP " +
                                                   "WHERE MaNCC LIKE '%" + name + "%' OR TenNCC LIKE N'%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable getTenNCC(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHACUNGCAP " +
                                                   "WHERE MaNCC = '" + name + "'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

    }
}
