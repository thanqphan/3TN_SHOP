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
    public class CT_PhieuNhapDAL : ConnectDAL
    {
        public DataTable getCTPN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CT_PHIEUNHAP", connect);
            DataTable dtCTPN = new DataTable();
            da.Fill(dtCTPN);
            return dtCTPN;
        }


        public bool themCTPN(DTO_CT_PhieuNhap ct)
        {
            try
            {
                // Ket noi
                connect.Open();


                string SQL = string.Format("INSERT INTO CT_PHIEUNHAP(MaPN,MaSP,SoLuongNhap,TongTien) " +
                                           "VALUES ('{0}', '{1}', {2} , {3} )",
                                            ct.MaPN, ct.MaSP, ct.SoLuongNhap, ct.TongTien);// DỮ LIỆU NHẬP VÀO

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


        public bool suaCTPN(DTO_CT_PhieuNhap ct)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string
                string SQL = string.Format("UPDATE CT_PHIEUNHAP " +
                                           "SET MaSP = '{1}', SoLuongNhap = {2}, TongTien = {3} " +
                                           "WHERE  MaPN= '{0}' ",
                                           ct.MaPN, ct.MaSP, ct.SoLuongNhap, ct.TongTien);

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


        public bool xoaCTPN(string maPN, string maSP)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM CT_PHIEUNHAP WHERE MaPN = '{0}' AND MaSP = '{1}' ", maPN, maSP);

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
        public DataTable inPhieuNhap(string mapn)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT pn.*, ncc.TenNCC, sp.TenSP, ct.MaSP, ct.SoLuongNhap, ct.TongTien " +
                                                   "FROM ((PHIEUNHAP pn JOIN CT_PHIEUNHAP ct ON pn.MaPN = ct.MaPN) JOIN NHACUNGCAP ncc ON pn.MaNCC = ncc.MaNCC) JOIN SANPHAM sp ON ct.MaSP = sp.MaSP " +
                                                   "WHERE pn.MaPN LIKE '" + mapn + "' ", connect);
            DataTable dtPhieuNhap = new DataTable();
            da.Fill(dtPhieuNhap);
            return dtPhieuNhap;
        }
    }
}
