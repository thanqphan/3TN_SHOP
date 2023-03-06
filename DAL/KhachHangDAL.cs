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
    public class KhachHangDAL : ConnectDAL
    {
        public DataTable getKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG", connect);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            return dtKhachHang;
        }


        public bool themKhachHang(DTO_KhachHang kh)
        {
            try
            {
                // Ket noi
                connect.Open();


                string SQL = string.Format("INSERT INTO KHACHHANG(MaKH,HoTen,DiemTichLuy,SDT,GioiTinh) " +
                                           "VALUES ('{0}', N'{1}',  {2}, '{3}',N'{4}' ) ",
                                           kh.MaKH, kh.HoTen,  kh.DiemTichLuy, kh.SDT,kh.GioiTinh); // DỮ LIỆU NHẬP VÀO
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


        public bool suaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string
                string SQL = $"UPDATE KHACHHANG SET HoTen=N'{kh.HoTen}',GioiTinh=N'{kh.GioiTinh}',SDT='{kh.SDT}',DiemTichLuy={kh.DiemTichLuy} WHERE MaKH = '{kh.MaKH}'";
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

        public bool xoaKhachHang(string maKH)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM KHACHHANG WHERE MaKH = '{0}'", maKH);

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
        public DataTable timKiemNhanhKhachHang(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaKH, Hoten, LoaiKH FROM KHACHHANG " +
                                                   " WHERE MaKH LIKE '%" + name + "%' OR Hoten LIKE N'%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable timKiemKhachHang(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG " +
                                                   " WHERE MaKH LIKE '%" + name + "%' OR HoTen LIKE N'%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

    }
}
