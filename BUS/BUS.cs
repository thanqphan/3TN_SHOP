using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  DTO;

namespace BUS
{
    public class BUS
    {
        CT_HoaDonDAL cthd = new CT_HoaDonDAL();
        CT_PhieuNhapDAL ctpn = new CT_PhieuNhapDAL();
        HoaDonDAL hd = new HoaDonDAL();
        KhachHangDAL kh = new KhachHangDAL();
        Loai_SPDAL lsp = new Loai_SPDAL();
        NhaCungCapDAL ncc = new NhaCungCapDAL();
        NhanVienDAL nv = new NhanVienDAL();
        PhieuNhapDAL pn = new PhieuNhapDAL();
        SanPhamDAL sp = new SanPhamDAL();
        TaiKhoanDAL tk = new TaiKhoanDAL();

        #region getData lấy toàn bộ dữ liệu trong các bảng cần truy xuất. lệnh lấy từ DAL
        public string getThongTinNV(int column, int row)
        {
            DataTable infotable = nv.getNhanVien();
            if (column >= infotable.Columns.Count || row >= infotable.Rows.Count)
                return "";
            return infotable.Rows[row].ItemArray[column].ToString();
        }

        public string getThongTinKH(int column, int row)
        {
            DataTable infotable = kh.getKhachHang();
            if (column >= infotable.Columns.Count || row >= infotable.Rows.Count)
                return "";
            return infotable.Rows[row].ItemArray[column].ToString();
        }

        public string getThongTinNCC(int column, int row)
        {
            DataTable infotable = ncc.getNhaCungCap();
            if (column >= infotable.Columns.Count || row >= infotable.Rows.Count)
                return "";
            return infotable.Rows[row].ItemArray[column].ToString();
        }
        public string getThongTinSP(int column, int row)
        {
            DataTable infotable = sp.getSanPham();
            if (column >= infotable.Columns.Count || row >= infotable.Rows.Count)
                return "";
            return infotable.Rows[row].ItemArray[column].ToString();
        }
        public string getThongTinHD(int column, int row)
        {
            DataTable infotable = hd.getHoaDon();
            if (column >= infotable.Columns.Count || row >= infotable.Rows.Count)
                return "";
            return infotable.Rows[row].ItemArray[column].ToString();
        }
        public string getThongTinCTHD(int column, int row)
        {
            DataTable infotable = cthd.getCTHD();
            if (column >= infotable.Columns.Count || row >= infotable.Rows.Count)
                return "";
            return infotable.Rows[row].ItemArray[column].ToString();
        }
        public string getThongTinPN(int column, int row)
        {
            DataTable infotable = pn.getPhieuNhap();
            if (column >= infotable.Columns.Count || row >= infotable.Rows.Count)
                return "";
            return infotable.Rows[row].ItemArray[column].ToString();
        }
        public string getThongTinCTPN(int column, int row)
        {
            DataTable infotable = ctpn.getCTPN();
            if (column >= infotable.Columns.Count || row >= infotable.Rows.Count)
                return "";
            return infotable.Rows[row].ItemArray[column].ToString();
        }
        public string getThongTinTaiKhoan(int column, int row)
        {
            DataTable infotable = tk.getTaiKhoan();
            if (column >= infotable.Columns.Count || row >= infotable.Rows.Count)
                return "";
            return infotable.Rows[row].ItemArray[column].ToString();
        }

        public DataTable getDataTable(string tablename)
        {
            switch (tablename)
            {
                case "NHANVIEN":
                    return nv.getNhanVien();
                case "KHACHHANG":
                    return kh.getKhachHang();
                case "NHACUNGCAP":
                    return ncc.getNhaCungCap();
                case "SANPHAM":
                    return sp.getSanPham();
                case "HOADON":
                    return hd.getHoaDon();
                case "CTHD":
                    return cthd.getCTHD();
                case "PHIEUNHAP":
                    return pn.getPhieuNhap();
                case "CTPN":
                    return ctpn.getCTPN();
                case "TAIKHOAN":
                    return tk.getTaiKhoan();
                default:
                    return null;
            }
        }
        #endregion
        #region themData chứa các lệnh <thêm> dữ liệu tương ứng các table. lệnh thêm từ DAL
        public bool themData(DTO_NhanVien dt)
        {
            return nv.themNhanVien(dt);
        }
        public bool themData(DTO_KhachHang dt)
        {
            return kh.themKhachHang(dt);
        }
        public bool themData(DTO_NhaCungCap dt)
        {
            return ncc.themNhaCungCap(dt);
        }
        public bool themData(DTO_SanPham dt)
        {
            return sp.themSanPham(dt);
        }
        public bool themData(DTO_HoaDon dt)
        {
            return hd.themHoaDon(dt);
        }
        public bool themData(DTO_CT_HoaDon dt)
        {
            return cthd.themCTHD(dt);
        }
        public bool themData(DTO_PhieuNhap dt)
        {
            return pn.themPhieuNhap(dt);
        }
        public bool themData(DTO_CT_PhieuNhap dt)
        {
            return ctpn.themCTPN(dt);
        }
        public bool themData(DTO_TaiKhoan dt)
        {
            return tk.themTaiKhoan(dt);
        }
        #endregion
        #region suaData chứa các lệnh <sửa> dữ liệu tương ứng các table. lệnh thêm từ DAL
        public bool suaData(DTO_NhanVien dt)
        {
            return nv.suaNhanVien(dt);
        }
        public bool suaData(DTO_KhachHang dt)
        {
            return kh.suaKhachHang(dt);
        }
        public bool suaData(DTO_NhaCungCap dt)
        {
            return ncc.suaNhaCungCap(dt);
        }
        public bool suaData(DTO_SanPham dt)
        {
            return sp.suaSanPham(dt);
        }
        public bool suaData(DTO_HoaDon dt)
        {
            return hd.suaHoaDon(dt);
        }
        public bool suaData(DTO_CT_HoaDon dt)
        {
            return cthd.suaCTHD(dt);
        }
        public bool suaData(DTO_PhieuNhap dt)
        {
            return pn.suaPhieuNhap(dt);
        }
        public bool suaData(DTO_CT_PhieuNhap dt)
        {
            return ctpn.suaCTPN(dt);
        }
        public bool suaData(DTO_TaiKhoan dt)
        {
            return tk.suaTaiKhoan(dt);
        }
        #endregion
        #region xoaData chứa các lệnh <xóa> dữ liệu tương ứng các table. lệnh thêm từ DAL
        public bool xoaNhanVien(string manv)
        {
            return nv.xoaNhanVien(manv);
        }
        public bool xoaKhachHang(string makh)
        {
            return kh.xoaKhachHang(makh);
        }
        public bool xoaNhaCungCap(string mancc)
        {
            return ncc.xoaNhaCungCap(mancc);
        }
        public bool xoaSanPham(string masp)
        {
            return sp.xoaSanPham(masp);
        }
        public bool xoaHoaDon(string mahd)
        {
            return hd.xoaHoaDon(mahd);
        }
        public bool xoaCTHD(string mahd, string masp)
        {
            return cthd.xoaCTHD(mahd, masp);
        }
        public bool xoaPhieuNhap(string mapn)
        {
            return pn.xoaPhieuNhap(mapn);
        }
        public bool xoaCTPN(string mapn, string masp)
        {
            return ctpn.xoaCTPN(mapn, masp);
        }
        public bool xoaTaiKhoan(string username)
        {
            return tk.xoaTaiKhoan(username);
        }
        #endregion
        #region Truy xuất tài khoản
        public DTO_TaiKhoan[] search_TAIKHOAN(string st)
        {
            int i = 0;
            DataTable infotable = tk.timKiemTaiKhoan_MaNV(st);
            if (infotable.Rows.Count == 0)
            {
                DTO_TaiKhoan[] temp = new DTO_TaiKhoan[1];
                temp[0] = new DTO_TaiKhoan(getThongTinSP(0, 0), getThongTinSP(1, 0), getThongTinSP(2, 0));
                return temp;
            }
            DTO_TaiKhoan[] dtotk = new DTO_TaiKhoan[infotable.Rows.Count];
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                string[] str = new string[4];
                for (int j = 0; j <= 2; j++)
                {
                    str[j] = row[j].ToString();
                }
                dtotk[i] = new DTO_TaiKhoan(str[0], str[1], str[2]);
                i++;
            }
            return dtotk;
        }
        public DataTable timKiem_TaiKhoan(string dt)
        {
            return tk.timKiemTaiKhoan(dt);
        }
        public DataTable timKiem_TaiKhoan_NhanVien()
        {
            return tk.getThongTin_TaiKhoan_NhanVien();
        }
        #endregion

        #region User Control Tổng Quan
        public string doanhThuTheoNam(string nm)
        {
            DataTable infotable = hd.doanhThuTheoNam(nm);
            if (infotable.Rows.Count == 0)
            {
                return "0";
            }
            return ((long)double.Parse(infotable.Rows[0].ItemArray[0].ToString())).ToString("0,000");
        }
        public string soLuongTheoNam(string nm)
        {
            DataTable infotable = hd.soLuongTheoNam(nm);
            if (infotable.Rows.Count == 0)
            {
                return "0";
            }
            return ((long)double.Parse(infotable.Rows[0].ItemArray[0].ToString())).ToString();
        }
        public string doanhThuTheoThang(string th, string nm)
        {
            DataTable infotable = hd.doanhThuTheoThang(th, nm);
            if (infotable.Rows.Count == 0)
            {
                return "0";
            }
            return ((long)double.Parse(infotable.Rows[0].ItemArray[0].ToString())).ToString("0,000");
        }
        public string soLuongTheoThang(string th, string nm)
        {
            DataTable infotable = hd.soLuongTheoThang(th, nm);
            if (infotable.Rows.Count == 0)
            {
                return "0";
            }
            return ((long)double.Parse(infotable.Rows[0].ItemArray[0].ToString())).ToString();
        }
        public string doanhThuTheoNgay(string ngay)
        {
            DataTable infotable = hd.doanhThuTheoNgay(ngay);
            if (infotable.Rows.Count == 0)
            {
                return "0";
            }
            return ((long)double.Parse(infotable.Rows[0].ItemArray[0].ToString())).ToString("0,000");
        }
        public string soLuongTheoNgay(string ngay)
        {
            DataTable infotable = hd.soLuongTheoNgay(ngay);
            if (infotable.Rows.Count == 0)
            {
                return "0";
            }
            return ((long)double.Parse(infotable.Rows[0].ItemArray[0].ToString())).ToString();
        }
        public DataTable top5_maSP_BanChayTheoDoanhThu(string date)
        {
            return cthd.getTop5SPTrongNgay(date);
        }
        public string[] top10_maSP_BanChayTheoDoanhThu_TheoThang()
        {
            DataTable infotable = cthd.getTop10SPTheoThang();
            string[] rep = new string[infotable.Rows.Count];
            int i = 0;

            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                if (i < 10)
                {
                    rep[i] = row[0].ToString();
                    i++;
                }
            }
            return rep;
        }
        public string[] top10_maSP_BanChayTheoSoLuong_TheoNgay()
        {
            DataTable infotable = cthd.getTop10SPTheoNgay_SL();

            string[] rep = new string[infotable.Rows.Count];
            int i = 0;
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                if (i < infotable.Rows.Count)
                {
                    rep[i] = row[0].ToString();
                    i++;
                }
            }
            return rep;
        }
        public string[] top10_maSP_BanChayTheoSoLuong_TheoTuan()
        {
            DataTable infotable = cthd.getTop10SPTheoTuan_SL();
            string[] rep = new string[infotable.Rows.Count];
            int i = 0;

            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                if (i < 10)
                {
                    rep[i] = row[0].ToString();
                    i++;
                }
            }
            return rep;
        }
        public string[] top10_maSP_BanChayTheoSoLuong_TheoThang()
        {
            DataTable infotable = cthd.getTop10SPTheoThang_SL();
            string[] rep = new string[infotable.Rows.Count];
            int i = 0;

            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                if (i < 10)
                {
                    rep[i] = row[0].ToString();
                    i++;
                }
            }
            return rep;
        }
        #endregion
        #region User Control Khách Hàng 
        public DataTable timKiemNhanh_KhachHang(string st)
        {
            return kh.timKiemNhanhKhachHang(st);
        }
        public DataTable timKiem_KhachHang(string st)
        {
            return kh.timKiemKhachHang(st);
        }
        public DTO_KhachHang[] search_KhachHang(string st)
        {
            int i = 0;
            DataTable infotable = kh.timKiemKhachHang(st);
            if (infotable.Rows.Count == 0)
            {
                DTO_KhachHang[] temp = new DTO_KhachHang[1];
                temp[0] = new DTO_KhachHang(getThongTinKH(0, 0), getThongTinKH(1, 0), getThongTinKH(2, 0), getThongTinKH(3, 0), getThongTinKH(4, 0));
                return temp;
            }
            DTO_KhachHang[] dtokh = new DTO_KhachHang[infotable.Rows.Count];
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                string[] str = new string[8];
                for (int j = 0; j <= 4; j++)
                {
                    str[j] = row[j].ToString();
                }
                dtokh[i] = new DTO_KhachHang(str[0], str[1], str[2], str[3], str[4]);
                i++;
            }
            return dtokh;
        }
        #endregion
        #region User Control Nhân Viên
        public DataTable timKiemNhanh_NhanVien(string st)
        {
            return nv.timKiemNhanhNhanVien(st);
        }
        public DataTable timKiem_NhanVien_theoTenTK(string st)
        {
            return nv.timKiemNhanVien_theoTenTK(st);
        }
        public DTO_NhanVien[] search_NhanVien_theoTenTK(string st)
        {
            int i = 0;
            DataTable infotable = nv.timKiemNhanVien_theoTenTK(st);
            if (infotable.Rows.Count == 0)
            {
                DTO_NhanVien[] temp = new DTO_NhanVien[1];
                temp[0] = new DTO_NhanVien(getThongTinNV(0, 0), getThongTinNV(1, 0), getThongTinNV(2, 0), getThongTinNV(3, 0), getThongTinNV(4, 0), getThongTinNV(5, 0), getThongTinNV(6, 0));
                return temp;
            }
            DTO_NhanVien[] dtonv = new DTO_NhanVien[infotable.Rows.Count];
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                string[] str = new string[9];
                for (int j = 0; j <= 6; j++)
                {
                    str[j] = row[j].ToString();
                }
                dtonv[i] = new DTO_NhanVien(str[0], str[1], str[2], str[3], str[4], str[5], str[6]);
                i++;
            }
            return dtonv;
        }
        public DTO_NhanVien[] search_NhanVien(string st)
        {
            int i = 0;
            DataTable infotable = nv.timKiemNhanVien(st);
            if (infotable.Rows.Count == 0)
            {
                DTO_NhanVien[] temp = new DTO_NhanVien[1];
                temp[0] = new DTO_NhanVien(getThongTinNV(0, 0), getThongTinNV(1, 0), getThongTinNV(2, 0), getThongTinNV(3, 0), getThongTinNV(4, 0), getThongTinNV(5, 0), getThongTinNV(6, 0));
                return temp;
            }
            DTO_NhanVien[] dtonv = new DTO_NhanVien[infotable.Rows.Count];
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                string[] str = new string[9];
                for (int j = 0; j <= 6; j++)
                {
                    str[j] = row[j].ToString();
                }
                dtonv[i] = new DTO_NhanVien(str[0], str[1], str[2], str[3], str[4], str[5], str[6]);
                i++;
            }
            return dtonv;
        }
        #endregion
        #region User Control Sản Phẩm
        public DataTable search_sanpham_ncc(string name, string mancc)
        {
            DataTable infotable = sp.getSanPham_NCC(name, mancc);
            return infotable;
        }
        public DataTable search_sanpham_NCC(string mancc)
        {
            DataTable infotable = sp.getSanPham_NCC(mancc);
            return infotable;
        }
        public string[] TopTonKho()
        {
            string[] rep = new string[10];
            int i = 0;
            DataTable infotable = sp.TopTonKho();
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                if (i < 10)
                {
                    rep[i] = row[0].ToString();
                    i++;
                }
            }
            return rep;
        }
        public DataTable timkiemSanPhamTonKho(string str)
        {
            return sp.timKiemSanPhamTonKho(str);
        }
        public DataTable timkiemSanPham(string str)
        {
            return sp.timKiemNhanhSanPham(str);
        }
        public DTO_SanPham[] search_SANPHAM(string st)
        {
            int i = 0;
            DataTable infotable = sp.timKiemSanPham(st);
            if (infotable.Rows.Count == 0)
            {
                DTO_SanPham[] temp = new DTO_SanPham[1];
                temp[0] = new DTO_SanPham(getThongTinSP(0, 0), getThongTinSP(1, 0), getThongTinSP(2, 0), getThongTinSP(3, 0), getThongTinSP(4, 0), getThongTinSP(5, 0), getThongTinSP(6, 0), getThongTinSP(7, 0));
                return temp;
            }
            DTO_SanPham[] dtosp = new DTO_SanPham[infotable.Rows.Count];
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                string[] str = new string[9];
                for (int j = 0; j <= 7; j++)
                {
                    str[j] = row[j].ToString();
                }
                dtosp[i] = new DTO_SanPham(str[0], str[1], str[2], str[3], str[4], str[5], str[6], str[7]);
                i++;
            }
            return dtosp;
        }
        public string[] Top9_SanPham_VuaNhap()
        {
            string[] rep = new string[9];
            int i = 0;
            DataTable infotable = sp.getTop9SanPham();
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                if (i < 9)
                {
                    rep[i] = row[0].ToString();
                    i++;
                }
            }
            return rep;
        }
        #endregion
        #region User Control Nhà Cung Cấp
        public DataTable list_SanPham_NCC(string mancc)
        {
            DataTable infotable = sp.getSanPham_NCC(mancc);
            return infotable;
        }
        public string getTenNCC(string name)
        {

            DataTable infotable = ncc.getTenNCC(name);
            int count = infotable.Rows.Count;
            return infotable.Rows[0][1].ToString();
        }
        public string getMaNCC(string name)
        {

            DataTable infotable = ncc.getTenNCC(name);
            int count = infotable.Rows.Count;
            return infotable.Rows[0][0].ToString();
        }
        public DTO_NhaCungCap[] search_NhaCungCap(string st)
        {
            int i = 0;
            DataTable infotable = ncc.timKiemNhaCungCap(st);
            if (infotable.Rows.Count == 0)
            {
                DTO_NhaCungCap[] temp = new DTO_NhaCungCap[1];
                temp[0] = new DTO_NhaCungCap(getThongTinNCC(0, 0), getThongTinNCC(1, 0), getThongTinNCC(2, 0), getThongTinNCC(3, 0), getThongTinNCC(4,0));
                return temp;
            }
            DTO_NhaCungCap[] dtoncc = new DTO_NhaCungCap[infotable.Rows.Count];
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                string[] str = new string[9];
                for (int j = 0; j <= 4; j++)
                {
                    str[j] = row[j].ToString();
                }
                dtoncc[i] = new DTO_NhaCungCap(str[0], str[1], str[2], str[3], str[4]);
                i++;
            }
            return dtoncc;
        }
        public DataTable timkiem_NhaCungCap(string st)
        {
            return ncc.timKiemNhaCungCap(st);
        }
        #endregion
        #region User Control Phiếu Nhập
        public DTO_PhieuNhap[] timkiem_PhieuNhap_NgLap(DateTime NgLap, int type)
        {
            int i = 0;
            DataTable infotable = pn.timKiemPhieuNhap_theoNgLap(NgLap, type);
            if (infotable.Rows.Count == 0)
            {
                DTO_PhieuNhap[] temp = new DTO_PhieuNhap[1];
                temp[0] = new DTO_PhieuNhap(getThongTinPN(0, 0), getThongTinPN(1, 0), getThongTinPN(2, 0), getThongTinPN(3, 0), getThongTinPN(4, 0), getThongTinPN(5, 0),getThongTinPN(6, 0),getThongTinPN(7, 0), getThongTinPN(8, 0));
                return temp;
            }
            DTO_PhieuNhap[] dtopn = new DTO_PhieuNhap[infotable.Rows.Count];
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                string[] str = new string[9];
                for (int j = 0; j <= 8; j++)
                {
                    str[j] = row[j].ToString();
                }
                dtopn[i] = new DTO_PhieuNhap(str[0], str[1], str[2], str[3], str[4], str[5], str[6], str[7], str[8]);
                i++;
            }
            return dtopn;
        }
        public DTO_PhieuNhap[] timkiem_PhieuNhap_MaPN(string mapn)
        {
            int i = 0;
            DataTable infotable = pn.timKiemPhieuNhap_theoMa(mapn);
            if (infotable.Rows.Count == 0)
            {
                DTO_PhieuNhap[] temp = new DTO_PhieuNhap[1];
                temp[0] = new DTO_PhieuNhap(getThongTinPN(0, 0), getThongTinPN(1, 0), getThongTinPN(2, 0), getThongTinPN(3, 0), getThongTinPN(4, 0), getThongTinPN(5, 0), getThongTinPN(6, 0), getThongTinPN(7, 0), getThongTinPN(8, 0));
                return temp;
            }
            DTO_PhieuNhap[] dtopn = new DTO_PhieuNhap[infotable.Rows.Count];
            DataRowCollection result = infotable.Rows;
            foreach (DataRow row in result)
            {
                string[] str = new string[9];
                for (int j = 0; j <= 8; j++)
                {
                    str[j] = row[j].ToString();
                }
                dtopn[i] = new DTO_PhieuNhap(str[0], str[1], str[2], str[3], str[4], str[5], str[6], str[7], str[8]);
                i++;
            }
            return dtopn;
        }
        public DataTable timkiemnhanh_PhieuNhap(string mapn, string mancc)
        {
            return pn.timKiemChiTiet(mapn, mancc);
        }
        public DataTable timkiemTheoNgay_PhieuNhap(DateTime ngpn, int type)
        {
            return pn.timKiemPhieuNhap_theoNgLap(ngpn, type);
        }
        public DataTable timKiem_PhieuNhap_Ma(string mapn, string ncc, string nv)
        {
            return pn.timKiemPhieuNhap_theoMas(mapn, ncc, nv);
        }
        #endregion
        #region User Control Hóa Đơn
        public DataTable searchHoaDon(string mahd, string makh, string manv, string nglap)
        {
            int i = 0;
            DataTable infotable = hd.timkiemHoaDon(mahd, makh, manv, nglap);
            return infotable;
        }
        public DataTable searchHoaDonTheoThang(string th, string nm)
        {
            int i = 0;
            DataTable infotable = hd.timkiemHoaDontheothang(th, nm);
            return infotable;
        }
        public DataTable searchHoaDonTheoNam(string nm)
        {
            int i = 0;
            DataTable infotable = hd.timkiemHoaDontheonam(nm);
            return infotable;
        }
        #endregion
        #region Chức năng In Hóa đơn + Phiếu Nhặp
        public DataTable InHoaDon(string mahd)
        {
            return cthd.inHoaDon(mahd);
        }
        public DataTable InPhieuNhap(string mapn)
        {
            return ctpn.inPhieuNhap(mapn);
        }
        #endregion
        
    }
}
