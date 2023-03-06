using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
        public class DTO_NhanVien
        {
            public string MaNV, HoTen, DiaChi, SDT, GT, NgSinh, ChucVu;
            public DTO_NhanVien()
            {

            }
            public DTO_NhanVien(string maNV, string hoTen, string diaChi, string sDT, string gT, string ngSinh, string chucVu)
            {
                this.MaNV = maNV;
                this.HoTen = hoTen;
                this.DiaChi = diaChi;
                this.SDT = sDT;
                this.GT = gT;
                this.NgSinh = ngSinh;
                this.ChucVu = chucVu;
            }
        }
    public class DTO_KhachHang
    {
        public string MaKH, HoTen, DiemTichLuy, SDT, GioiTinh;
        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(string maKH, string hoTen, string diemTichLuy, string SDT, string gioiTinh)
        {
            this.MaKH = maKH;
            this.HoTen = hoTen;
            this.DiemTichLuy = diemTichLuy;
            this.SDT = SDT;
            this.GioiTinh = gioiTinh;
        }
    }
    public class DTO_NhaCungCap
        {
            public string MaNCC, TenNCC, DiaChi, SDT, TrangThai;
            public DTO_NhaCungCap()
            {

            }
            public DTO_NhaCungCap(string maNCC, string tenNCC, string diaChi, string sDT, string trangThai)
            {
                this.MaNCC = maNCC;
                this.TenNCC = tenNCC;
                this.DiaChi = diaChi;
                this.SDT = sDT;
            this.TrangThai = trangThai;
            }
        }
        public class DTO_LoaiSP
        {
            public string MaLoaiSP, TenLoaiSP;
            public DTO_LoaiSP()
            {

            }
            public DTO_LoaiSP(string maLoaiSP, string tenLoaiSP)
            {
                this.MaLoaiSP = maLoaiSP;
                this.TenLoaiSP = tenLoaiSP;
            }
        }
        public class DTO_SanPham
        {
            public string MaSP, TenSP, MauSP, SizeSP, DonGia, MaLoaiSP, SoLuongKho, TrangThai;
            public DTO_SanPham()
            {

            }
            public DTO_SanPham(string maSP, string tenSP, string mauSP, string sizeSP, string donGia, string maLoaiSP, string soLuongKho, string trangThai)
            {
                this.MaSP = maSP;
                this.TenSP = tenSP;
                this.MauSP = mauSP;
                this.SizeSP = sizeSP;
                this.DonGia = donGia;
                this.MaLoaiSP = maLoaiSP;
                this.SoLuongKho = soLuongKho;
                this.TrangThai = trangThai;
            }
        }
        public class DTO_HoaDon
        {
            public string MaHD, NgLap, MaKH, MaNV, TongSL, TongThanhTien, TienGiamGia, TongTien;
            public DTO_HoaDon()
            {

            }
            public DTO_HoaDon(string maHD, string ngLap, string maKH, string maNV, string tongSL, string tongThanhTien, string tienGiamGia, string tongTien)
            {
                this.MaHD = maHD;
                this.NgLap = ngLap;
                this.MaKH = maKH;
                this.MaNV = maNV;
                this.TongSL = tongSL;
                this.TongThanhTien = tongThanhTien;
                this.TienGiamGia = tienGiamGia;
                this.TongTien = tongTien;
            }
        }
        public class DTO_CT_HoaDon
        {
            public string MaHD, MaSP, DonGia, SoLuongBan;
            public DTO_CT_HoaDon()
            {

            }
            public DTO_CT_HoaDon(string maHD, string maSP, string donGia, string soLuongBan)
            {
                this.MaHD = maHD;
                this.MaSP = maSP;
                this.SoLuongBan = soLuongBan;
                this.DonGia = donGia;
            }
        }
        public class DTO_PhieuNhap
        {
            public string MaPN, NgLap, MaNCC, MaNV, TongSL, TongThanhTien, GiaTrietKhau, TongTienNhap, Note;
            public DTO_PhieuNhap()
            {

            }
            public DTO_PhieuNhap(string maPN, string ngLap, string maNCC, string maNV, string tongSL, string tongThanhTien, string giaTrietKhau, string tongTienNhap, string note)
            {
                this.MaPN = maPN;
                this.NgLap = ngLap;
                this.MaNCC = maNCC;
                this.MaNV = maNV;
                this.TongSL = tongSL;
                this.TongThanhTien = tongThanhTien;
                this.GiaTrietKhau = giaTrietKhau;
                this.TongTienNhap = tongTienNhap;
                this.Note = note;
            }
        }
        public class DTO_CT_PhieuNhap
        {
            public string MaPN, MaSP, SoLuongNhap, TongTien;
            public DTO_CT_PhieuNhap()
            {

            }
            public DTO_CT_PhieuNhap(string maPN, string maSP, string soLuongNhap, string tongTien)
            {
                this.MaPN = maPN;
                this.MaSP = maSP;
                this.SoLuongNhap = soLuongNhap;
                this.TongTien = tongTien;
            }
        }
        public class DTO_TaiKhoan
        {
            public string TenTK, MatKhau, MaNV;
            public DTO_TaiKhoan()
            {

            }
            public DTO_TaiKhoan(string tenTK, string matKhau,string maNV)
            {
                this.TenTK = tenTK;
                this.MatKhau = matKhau;
                this.MaNV = maNV;
            }
        }
}
