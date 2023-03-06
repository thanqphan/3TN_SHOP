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
    public class NhanVienDAL : ConnectDAL
    {
        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN", connect);
            DataTable dtNhanvien = new DataTable();
            da.Fill(dtNhanvien);
            return dtNhanvien;
        }


        public bool themNhanVien(DTO_NhanVien nv)// THẮNG
        {
            try
            {
                // Ket noi
                connect.Open();


                string SQL = string.Format("INSERT INTO NHANVIEN(MaNV, HoTen, DiaChi, SDT, GT, NgSinh, ChucVu) " +
                                           "VALUES ('{0}', N'{1}', N'{2}','{3}', N'{4}', '{5}', N'{6}' )",
                                           nv.MaNV, nv.HoTen, nv.DiaChi, nv.SDT, nv.GT, nv.NgSinh, nv.ChucVu);// DỮ LIỆU NHẬP VÀO

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


        public bool suaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string
                string SQL = string.Format("UPDATE NHANVIEN " +
                                           "SET HoTen=N'{1}', DiaChi=N'{2}', SDT='{3}', GT=N'{4}', NgSinh='{5}', ChucVu=N'{6}' " +
                                           "WHERE MaNV = '{0}'",
                                           nv.MaNV, nv.HoTen, nv.DiaChi, nv.SDT, nv.GT, nv.NgSinh, nv.ChucVu);

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


        public bool xoaNhanVien(string maNV)
        {
            try
            {
                // Ket noi
                connect.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM NHANVIEN WHERE MaNV = '{0}' ", maNV);

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
        public DataTable timKiemNhanhNhanVien(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaNV, HoTen, ChucVu FROM NHANVIEN " +
                                                   "WHERE MaNV LIKE '%" + name + "%' OR HoTen LIKE N'%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable timKiemNhanVien(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN " +
                                                   "WHERE MaNV LIKE '%" + name + "%' OR HoTen LIKE N'%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable timKiemNhanVien_theoTenTK(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("select nv.* from NHANVIEN nv,TAIKHOAN tk where nv.MaNV=tk.MaNV and tk.TenTK like N'%" + name + "%'", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
       
    }
}
