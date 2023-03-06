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
    public class PhieuNhapDAL : ConnectDAL
    {
        public DataTable getPhieuNhap()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUNHAP", connect);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);
            return dtPhieuNhap;
        }


        public bool themPhieuNhap(DTO_PhieuNhap pn)
        {
            try
            {
                // Ket noi
                connect.Open();


                string sql = string.Format("insert into PHIEUNHAP (MaPN, NgLap, MaNCC, MaNV,TongSL, TongThanhTien,GiaTrietKhau,TongTienNhap,Note) " +
                                           "values ('{0}', '{1}', '{2}', '{3}' , {4}, {5},'{6}',{7},N'{8}')",
                                           pn.MaPN, pn.NgLap, pn.MaNCC, pn.MaNV, pn.TongSL, pn.TongThanhTien, pn.GiaTrietKhau, pn.TongTienNhap, pn.Note); // DỮ LIỆU NHẬP VÀO
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(sql, connect);

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


        public bool suaPhieuNhap(DTO_PhieuNhap pn)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string
                string sql = string.Format("update PHIEUNHAP " +
                                           "set NgLap='{1}', MaNCC='{2}', MaNV='{3}',TongSL={4}, TongThanhTien={5},GiaTrietKhau='{6}',TongTienNhap={7},Note=N'{8}' " +
                                           "WHERE MaPN='{0}'",
                                            pn.MaPN, pn.NgLap, pn.MaNCC, pn.MaNV, pn.TongSL, pn.TongThanhTien, pn.GiaTrietKhau, pn.TongTienNhap, pn.Note);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(sql, connect);

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


        public bool xoaPhieuNhap(string maPN)
        {
            try
            {
                // Ket noi
                connect.Open();

                string sql = string.Format("delete from PHIEUNHAP where MaPN = '{0}' ", maPN);


                SqlCommand cmd = new SqlCommand(sql, connect);

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
        public DataTable timKiemPhieuNhap_theoNgLap(DateTime ngpn, int type)
        {
            string query = null;
            if (type == 0)
            {
                query = $"SELECT * FROM PHIEUNHAP WHERE [NgLap] = '{ngpn.ToString("yyyy-MM-dd")}'";
            }
            else if (type == 1)
            {
                query = $"SELECT * FROM PHIEUNHAP WHERE YEAR([NgLap]) = {ngpn.Year} AND MONTH([NgLap]) = {ngpn.Month}";
            }
            else
            {
                query = $"SELECT * FROM PHIEUNHAP WHERE YEAR([NgLap]) = {ngpn.Year}";
            }
            SqlDataAdapter da = new SqlDataAdapter(query, connect);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);
            return dtPhieuNhap;
        }
        public DataTable timKiemPhieuNhap_theoMa(string mapn)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUNHAP " +
                                                   "WHERE MaPN LIKE '%" + mapn + "%' ", connect);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);
            return dtPhieuNhap;
        }
        public DataTable timKiemChiTiet(string mapn, string mancc)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUNHAP " +
                                                   "WHERE MaPN LIKE '%" + mapn + "%' AND MaNCC LIKE '%" + mancc + "%'", connect);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);
            return dtPhieuNhap;
        }
        public DataTable timKiemPhieuNhap_theoMas(string pn, string ncc, string nv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUNHAP " +
                                                   "WHERE MaPN='" + pn + "' or (MaNV='" + nv + "' and MaNCC='" + ncc + "') or (MaNV='" + nv + "' and MaNCC='" + ncc + "' and MaPN='" + pn + "') or MaNV='" + nv + "' or MaNCC='" + ncc + "'", connect);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);
            return dtPhieuNhap;
        }
    }
}
