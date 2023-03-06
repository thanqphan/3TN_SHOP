using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class TaiKhoanDAL : ConnectDAL
    {
        public DataTable getTaiKhoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAIKHOAN", connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public bool themTaiKhoan(DTO_TaiKhoan tk)
        {
            try
            {
                connect.Open();
                string sql = string.Format("Insert into TAIKHOAN(TenTK,MatKhau,MaNV)" + "values ('{0}','{1}','{2}')", tk.TenTK, tk.MatKhau,tk.MaNV);
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
        public bool suaTaiKhoan(DTO_TaiKhoan tk)
        {
            try
            {
                connect.Open();
                string sql = $"update TAIKHOAN set MatKhau='{tk.MatKhau}' where TenTK='{tk.TenTK}' and MaNV='{tk.MaNV}'";
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
        public bool xoaTaiKhoan(string tenTK)
        {
            try
            {
                connect.Open();
                string sql = string.Format("delete from TAIKHOAN where TenTK='{0}'", tenTK);
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
        public DataTable timKiemTaiKhoan_MaNV(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAIKHOAN " +
                                                   "WHERE MaNV LIKE '%" + name + "%' ", connect);

            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable timKiemTaiKhoan(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TenTK, MatKhau FROM TAIKHOAN " +
                                                   "WHERE TenTK LIKE '%" + name + "%' ", connect);

            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        public DataTable getThongTin_TaiKhoan_NhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select tk.TenTK,nv.HoTen,tk.MaNV, tk.MatKhau,nv.ChucVu as 'LoaiTK' from NHANVIEN nv,TAIKHOAN tk where nv.MaNV=tk.MaNV ", connect); /*and tk.TenTK like N'%" + name + "%'*/
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

    }
}
