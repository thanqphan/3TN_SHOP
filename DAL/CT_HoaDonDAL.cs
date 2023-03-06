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
    public class CT_HoaDonDAL : ConnectDAL
    {
        public DataTable getCTHD()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CT_HOADON", connect);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            return dtCTHD;
        }


        public bool themCTHD(DTO_CT_HoaDon ct)
        {
            try
            {
                // Ket noi
                connect.Open();


                string SQL = string.Format("INSERT INTO CT_HOADON(MaHD,MaSP,DonGia,SoLuongBan) " +
                                           "VALUES ('{0}', '{1}', {2} , {3} )",
                                            ct.MaHD, ct.MaSP, ct.DonGia, ct.SoLuongBan);// DỮ LIỆU NHẬP VÀO

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


        public bool suaCTHD(DTO_CT_HoaDon ct)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string
                string SQL = string.Format("UPDATE CT_HOADON " +
                                           "SET MaSP = '{1}', DonGia = {2}, SoLuongBan = {3} " +
                                           "WHERE MaHD ='{0}' ",
                                          ct.MaHD, ct.MaSP, ct.DonGia, ct.SoLuongBan);

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


        public bool xoaCTHD(string maHD, string maSP)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM CT_HOADON WHERE MaHD = '{0}' AND MaSP = '{1}' ", maHD, maSP);

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
        public DataTable getTop5SPTrongNgay(string dt)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(5) sp.MaSP, sp.TenSP, SUM(ct.DonGia) AS DoanhThu " +
                                                   "FROM(HOADON hd JOIN CT_HOADON ct ON hd.MaHD = ct.MaHD) JOIN SANPHAM sp ON ct.MaSP = sp.MaSP " +
                                                   "WHERE hd.NgLap = '" + dt + "' " +
                                                   "GROUP BY sp.MaSP, sp.TenSP " +
                                                   "ORDER BY DoanhThu DESC ", connect);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            return dtCTHD;
        }
        public DataTable getTop10SPTheoNgay()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(10) sp.MaSP, sp.TenSP, SUM(ct.DonGia) AS DoanhThu " +
                                                   "FROM(HOADON hd JOIN CT_HOADON ct ON hd.MaHD = ct.MaHD) JOIN SANPHAM sp ON ct.MaSP = sp.MaSP " +
                                                   "WHERE hd.NgLap = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' " +
                                                   "GROUP BY sp.MaSP, sp.TenSP " +
                                                   "ORDER BY DoanhThu DESC ", connect);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            return dtCTHD;
        }
        public DataTable getTop10SPTheoTuan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(10) sp.MaSP, sp.TenSP, SUM(ct.DonGia) AS DoanhThu " +
                                                   "FROM(HOADON hd JOIN CT_HOADON ct ON hd.MaHD = ct.MaHD) JOIN SANPHAM sp ON ct.MaSP = sp.MaSP " +
                                                   "WHERE hd.NgLap BETWEEN '" + DateTime.Today.AddDays(-7).ToString("yyyy-MM-dd") + "' AND '" + DateTime.Today.ToString("yyyy-MM-dd") + "'" +
                                                   "GROUP BY sp.MaSP, sp.TenSP " +
                                                   "ORDER BY DoanhThu DESC ", connect);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            return dtCTHD;
        }
        public DataTable getTop10SPTheoThang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(10) sp.MaSP, sp.TenSP, SUM(ct.DonGia) AS DoanhThu " +
                                                   "FROM(HOADON hd JOIN CT_HOADON ct ON hd.MaHD = ct.MaHD) JOIN SANPHAM sp ON ct.MaSP = sp.MaSP " +
                                                   "WHERE MONTH(hd.NgLap) = MONTH('" + DateTime.Today.ToString("yyyy-MM-dd") + "') " +
                                                   "AND   YEAR(hd.NgLap) = YEAR('" + DateTime.Today.ToString("yyyy-MM-dd") + "') " +
                                                   "GROUP BY sp.MaSP, sp.TenSP " +
                                                   "ORDER BY DoanhThu DESC ", connect);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            return dtCTHD;
        }
        public DataTable getTop10SPTheoNgay_SL()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(10) sp.MaSP, sp.TenSP, SUM(ct.SoLuongBan) AS SL " +
                                                   "FROM(HOADON hd JOIN CT_HOADON ct ON hd.MaHD = ct.MaHD) JOIN SANPHAM sp ON ct.MaSP = sp.MaSP " +
                                                   "WHERE hd.NgLap = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' " +
                                                   "GROUP BY sp.MaSP, sp.TenSP " +
                                                   "ORDER BY SL DESC ", connect);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            return dtCTHD;
        }
        public DataTable getTop10SPTheoTuan_SL()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(10) sp.MaSP, sp.TenSP,SUM(ct.SoLuongBan) AS SL " +
                                                   "FROM(HOADON hd JOIN CT_HOADON ct ON hd.MaHD = ct.MaHD) JOIN SANPHAM sp ON ct.MaSP = sp.MaSP " +
                                                   "WHERE hd.NgLap BETWEEN '" + DateTime.Today.AddDays(-7).ToString("yyyy-MM-dd") + "' AND '" + DateTime.Today.ToString("yyyy-MM-dd") + "'" +
                                                   "GROUP BY sp.MaSP, sp.TenSP " +
                                                   "ORDER BY SL DESC ", connect);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            return dtCTHD;
        }
        public DataTable getTop10SPTheoThang_SL()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(10) sp.MaSP, sp.TenSP, SUM(ct.SoLuongBan) AS SL " +
                                                   "FROM(HOADON hd JOIN CT_HOADON ct ON hd.MaHD = ct.MaHD) JOIN SANPHAM sp ON ct.MaSP = sp.MaSP " +
                                                   "WHERE MONTH(hd.NgLap) = MONTH('" + DateTime.Today.ToString("yyyy-MM-dd") + "') " +
                                                   "AND   YEAR(hd.NgLap) = YEAR('" + DateTime.Today.ToString("yyyy-MM-dd") + "') " +
                                                   "GROUP BY sp.MaSP, sp.TenSP " +
                                                   "ORDER BY SL DESC ", connect);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            return dtCTHD;
        }
        public DataTable inHoaDon(string mahd)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT sp.TenSP, ct.SoLuongBan AS SOLUONG, ct.DonGia AS GIATIEN, ct.SoLuongBan * ct.DonGia AS TONGTIENHANG, kh.HoTen AS TENKH, nv.HoTen AS TENNV " +
                                                               "FROM (((HOADON hd JOIN CT_HOADON ct ON hd.MaHD = ct.MaHD) JOIN SANPHAM sp ON ct.MaSP = sp.MaSP) LEFT JOIN NHANVIEN nv ON nv.MaNV = HD.MaNV) LEFT JOIN KHACHHANG kh ON kh.MaKH = hd.MaKH " +
                                                               "WHERE hd.MaHD LIKE '" + mahd + "'", connect);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            return dtCTHD;
        }
    }
}
