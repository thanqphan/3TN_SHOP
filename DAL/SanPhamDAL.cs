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
    public class SanPhamDAL : ConnectDAL
    {
        public DataTable getSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SANPHAM", connect);
            DataTable dtSanPham = new DataTable();
            da.Fill(dtSanPham);
            return dtSanPham;
        }
        public bool themSanPham(DTO_SanPham sp)
        {
            try
            {
                connect.Open();
                string sql = string.Format("insert into SANPHAM (MaSP,TenSP,MauSP,SizeSP,DonGia,MaLoaiSP,SoLuongKho,TrangThai)" +
                                            "values ('{0}',N'{1}',N'{2}','{3}','{4}','{5}','{6}',N'{7}')",
                                            sp.MaSP, sp.TenSP, sp.MauSP, sp.SizeSP, sp.DonGia, sp.MaLoaiSP, sp.SoLuongKho, sp.TrangThai);
                SqlCommand cmd = new SqlCommand(sql, connect);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connect.Close();
            }

            return false;
        }
        public bool suaSanPham(DTO_SanPham sp)
        {
            try
            {
                connect.Open();
                string sql = string.Format("update SANPHAM " +
                                          "set TenSP= N'{1}', MauSP=N'{2}',SizeSP= '{3}' , DonGia={4} , MaLoaiSP='{5}',SoLuongKho={6},TrangThai=N'{7}' " +
                                          "where MaSP='{0}' ",
                                           sp.MaSP, sp.TenSP, sp.MauSP, sp.SizeSP, sp.DonGia, sp.MaLoaiSP, sp.SoLuongKho, sp.TrangThai);
                SqlCommand cmd = new SqlCommand(sql, connect);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connect.Close();
            }

            return false;
        }
        public bool xoaSanPham(string maSP)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string sql = string.Format("delete from SanPham where MaSP = '{0}' ", maSP);

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
        public DataTable TopTonKho()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(10) TenSP " +
                                                   "FROM SANPHAM  " +
                                                   "ORDER BY SoLuongKho DESC", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable timKiemSanPhamTonKho(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MASP, TENSP, MAUSP, SIZESP,  DONGIA, SOLUONGKHO FROM SANPHAM " +
                                                   "WHERE MASP LIKE '%" + name + "%' OR TENSP LIKE N'%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable timKiemSanPham(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SANPHAM " +
                                                   "where MaSP LIKE '%" + name + "%' OR TenSP LIKE N'%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable timKiemNhanhSanPham(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MASP, TENSP, DONGIA FROM SANPHAM " +
                                                   "WHERE MASP LIKE '%" + name + "%' OR TENSP LIKE N'%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable getSanPham_LoaiSP(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SANPHAM " +
                                                   "where MaLoaiSP like '" + name + "'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable getSanPham_MauSP(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SANPHAM " +
                                                   "where MauSP like '" + name + "'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable getSanPham_SizeSP(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SANPHAM " +
                                                   "where SizeSP like '" + name + "'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable getTop9SanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(9) sp.TenSP " +
                                                   "FROM SANPHAM sp JOIN CT_PHIEUNHAN ct ON sp.MaSP = ct.MaSP JOIN PHIEUNHAP pn ON ct.MaPN = pn.MaPN " +
                                                   "ORDER BY pn.NgLap DESC", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable getSanPham_NCC(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("select distinct sp.MaSP,sp.TenSP,sp.DonGia from SANPHAM sp ,PHIEUNHAP pn,CT_PHIEUNHAP ct where sp.MaSP=ct.MaSP and ct.MaPN=pn.MaPN and pn.MaNCC like '" + name + "'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable getSanPham_NCC(string name, string ncc)
        {
            SqlDataAdapter da = new SqlDataAdapter("select distinct sp.MaSP,sp.TenSP,sp.DonGia from SANPHAM sp ,PHIEUNHAP pn,CT_PHIEUNHAP ct where sp.MaSP=ct.MaSP and ct.MaPN=pn.MaPN and pn.MaNCC like '" + ncc + "' AND pn.MaSP LIKE '%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
    }
}
