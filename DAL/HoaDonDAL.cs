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
    public class HoaDonDAL : ConnectDAL
    {
        public DataTable getHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADON", connect);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }


        public bool themHoaDon(DTO_HoaDon hd)
        {
            try
            {
                // Ket noi
                connect.Open();
                string SQL = string.Format("INSERT INTO HOADON(MaHD,NgLap,MaKH,MaNV,TongSL,TongThanhTien,TienGiamGia,TongTien) " +
                                           "VALUES ( '{0}', '{1}', '{2}' , '{3}' , {4} , {5} , {6} ,{7}) ",
                                           hd.MaHD, hd.NgLap, hd.MaKH, hd.MaNV, hd.TongSL, hd.TongThanhTien, hd.TienGiamGia, hd.TongTien);// DỮ LIỆU NHẬP VÀO

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


        public bool suaHoaDon(DTO_HoaDon hd)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string
                string SQL = string.Format("UPDATE HOADON " +
                                           "SET NgLap='{1}',MaKH='{2}',MaNV='{3}',TongSL={4},TongThanhTien={5},TienGiamGia={6},TongTien={7} " +
                                           "WHERE MaHD='{0}' ",
                                           hd.MaHD, hd.NgLap, hd.MaKH, hd.MaNV,  hd.TongSL, hd.TongThanhTien, hd.TienGiamGia, hd.TongTien);

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


        public bool xoaHoaDon(string maHD)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM HOADON WHERE MaHD = '{0}'", maHD);

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
        public DataTable timkiemHoaDon(string mhd, string makh, string manv, string ngaylap)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADON " +
                                                   "WHERE MaHD LIKE '%" + mhd + "%' AND MaNV LIKE '%" + manv + "%' AND MaKH LIKE '%"
                                                   + makh + "%' AND NgLap = '" + ngaylap + "'", connect);
            if (ngaylap == "") da = new SqlDataAdapter("SELECT * FROM HOADON " +
                                                   "WHERE MaHD LIKE '%" + mhd + "%' AND MaNV LIKE '%" + manv + "%' AND MaKH LIKE '%"
                                                   + makh + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable timkiemHoaDontheothang(string th, string nm)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADON " +
                                                   "WHERE MONTH(NgLap) = '" + th + "' AND YEAR(NgLap) = '" + nm + "' "
                                                   , connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable timkiemHoaDontheonam(string nm)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADON " +
                                                   "WHERE YEAR(NgLap) = '" + nm + "' "
                                                   , connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable doanhThuTheoNgay(string ngay)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(TongTien) FROM HOADON " +
                                                   "WHERE NgLap = '" + ngay + "' " +
                                                   "GROUP BY NgLap", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable doanhThuTheoThang(string th, string nm)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(TongTien) FROM HOADON " +
                                                   "WHERE MONTH(NgLap) = '" + th + "' AND YEAR(NgLap) = '" + nm + "' " +
                                                   "GROUP BY MONTH(NgLap)", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable doanhThuTheoNam(string nm)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(TongTien) FROM HOADON " +
                                                   "WHERE YEAR(NgLap) = '" + nm + "' " +
                                                   "GROUP BY YEAR(NgLap)", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable soLuongTheoNam(string nm)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(TongTien) FROM HOADON " +
                                                   "WHERE YEAR(NgLap) = '" + nm + "' " +
                                                   "GROUP BY YEAR(NgLap)", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable soLuongTheoThang(string th, string nm)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(TongTien) FROM HOADON " +
                                                   "WHERE MONTH(NgLap) = '" + th + "' AND YEAR(NgLap) = '" + nm + "' " +
                                                   "GROUP BY MONTH(NgLap)", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable soLuongTheoNgay(string ngay)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(TongTien)  FROM HOADON " +
                                                   "WHERE NgLap = '" + ngay + "' " +
                                                   "GROUP BY NgLap", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
    }
}
