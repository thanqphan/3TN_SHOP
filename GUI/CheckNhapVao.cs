using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class CheckNhapVao
    {
            static public string check_Nhap(DTO_NhanVien nv)
            {
                string error = "";
                BUS.BUS bus = new BUS.BUS();
                DTO_NhanVien[] nhanvien = bus.search_NhanVien(nv.MaNV);
                DataTable kh = bus.getDataTable("KHACHHANG");
                if (nhanvien[0].MaNV == nv.MaNV)
                    error += "Mã nhân viên này đã tồn tại";
            
                return error;
            }

        static public string check_Nhap(DTO_KhachHang kh)
        {
            string error = "";
            BUS.BUS bus = new BUS.BUS();
            DTO_KhachHang[] khachhang = bus.search_KhachHang(kh.MaKH);
            DataTable nv = bus.getDataTable("NHANVIEN");
            if (khachhang[0].MaKH == kh.MaKH)
                error += "Mã khách hàng này đã tồn tại";
            if (kh.GioiTinh != "Nữ" && kh.GioiTinh != "Nam" && kh.GioiTinh != "Khác")
                error += " " + "Giới tính chỉ được {Nam, Nữ, Khác}";
            try
            {
                int test = int.Parse(kh.DiemTichLuy);
                if (test < 0)
                {
                    error += " Điểm tích luỹ không thể âm.";
                }
            }
            catch (Exception e)
            {
                error += " Điểm tích luỹ phải là số!";
            }
            return error;
        }

        static public string check_Nhap(DTO_SanPham sp)
        {
            string error = "";
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] sanpham = bus.search_SANPHAM(sp.MaSP);
            if (sanpham[0].MaSP == sp.MaSP)
                error += "Mã sản phẩm này đã tồn tại";
            if (Double.Parse(sanpham[0].DonGia) < 0)
                error += " " + "Giá sản phẩm phải > 0 ";
            if (Double.Parse(sanpham[0].SoLuongKho) < 0)
                error += " " + "Số lượng phải > 0 ";
            return error;
        }

        static public string check_Nhap(DTO_PhieuNhap pn)
        {
            string error = "";
            BUS.BUS bus = new BUS.BUS();
            DTO_PhieuNhap[] phieunhap = bus.timkiem_PhieuNhap_MaPN(pn.MaPN);
            if (phieunhap[0].MaPN == pn.MaPN)
                error += "Phiếu nhập này đã tồn tại";
            return error;
        }

        static public string check_Nhap(DTO_NhaCungCap ncc)
        {
            string error = "";
            BUS.BUS bus = new BUS.BUS();
            DTO_NhaCungCap[] nhacc = bus.search_NhaCungCap(ncc.MaNCC);
            if (nhacc[0].MaNCC == ncc.MaNCC)
                error += "Mã nhà cung cấp này đã tồn tại";
            return error;
        }

        static public string check_Nhap(DTO_HoaDon hd)
        {
            string error = "";
            BUS.BUS bus = new BUS.BUS();
            DataTable hoadon = bus.searchHoaDon(hd.MaHD, "", "", "");
            if (hoadon.Rows.Count == 1)
                error += "Mã hóa đơn này đã tồn tại";
            return error;
        }
    }
}
