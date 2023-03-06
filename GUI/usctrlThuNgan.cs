using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usctrlThuNgan : DevExpress.XtraEditors.XtraUserControl
    {
        private int Dongia = 0;
        private int SoLuong = 0;
        private string MaSP = "SP001";
        public static long TongTienHang = 0;
        public static long ThanhTien = 0;
        public static TextBox txtTemp = new TextBox();
        public static long GiamGia = 0;
        public usctrlThuNgan()
        {
            InitializeComponent();
            txtTemp.TextChanged += txtTemp_TextChanged;
            TongTienHang = 0;
            ThanhTien = 0;
            lblTongtienhang.TextChanged += lblTongtienhang_TextChanged;
            lblTiendu.TextChanged += lblTiendu_TextChanged;
            lblTiengiamgia.TextChanged += lblTiengiamgia_TextChanged;
            lblThanhtien.TextChanged += lblThanhtien_TextChanged;
        }

        private void usctrlThuNgan_Load(object sender, EventArgs e)
        {
            dataNgLapHD.DateTime = DateTime.Today;
            txtTimkiem.Text = "a";
            txtTimkiem.Text = "";

            DTO_NhanVien[] nv = new BUS.BUS().search_NhanVien(ThongTinDangNhap.UserName);
            if (ThongTinDangNhap.UserName == "admin")
            {
                lblNameNV.Text = "admin";
                return;
            }
            lblNameNV.Text = nv[0].HoTen;
        }
        private void txtTemp_TextChanged(object sender, EventArgs e)
        {
            lblTongtienhang.Text = TongTienHang + "";
            lblTiengiamgia.Text = GiamGia + "";
            lblThanhtien.Text = ThanhTien + "";
            string st = txtTimkiem.Text;
            txtTimkiem.Text = "a";
            txtTimkiem.Text = st;
        }
        private void lblTongtienhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTiendu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] SP = bus.search_SANPHAM(txtTimkiem.Text);

            string ma = SP[0].MaSP;
            if (System.IO.File.Exists(Application.StartupPath + "/HinhSanPham/" + ma + ".jpg"))
                picSP.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + ma + ".jpg");
            else
                picSP.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + ma + ".png");

            lblSL.Text = "x" + SP[0].SoLuongKho;
            lblTenSP.Text = SP[0].TenSP;
            Dongia = int.Parse(TransFormat.SubString(SP[0].DonGia));
            SoLuong = int.Parse(TransFormat.SubString(SP[0].SoLuongKho));
            MaSP = SP[0].MaSP;
            txtSLSP.Text = "";
            lblTongtien.Text = "0";
        }

        private void picBoxSP_Click(object sender, EventArgs e)
        {
            frmThuNganSP sp = new frmThuNganSP();
            sp.ShowDialog();
            txtTimkiem.Text = sp.MASP;
        }

        private void picSP_Click(object sender, EventArgs e)
        {

        }

        private void txtSLSP_TextChanged(object sender, EventArgs e)
        {
            if (txtSLSP.Text == "" || txtSLSP.Text == "-")
            {
                lblTongtien.Text = "0";
                return;
            }
            try
            {
                lblTongtien.Text = Dongia * long.Parse(txtSLSP.Text) + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng phải bắt đầu bằng số");
                txtSLSP.Text = "0";
                return;
            }
            if (int.Parse(txtSLSP.Text) <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                txtSLSP.Text = "0";
            }
            if (int.Parse(txtSLSP.Text) > SoLuong)
            {
                MessageBox.Show("Số lượng chỉ tối đa là " + SoLuong + " sản phẩm");
                txtSLSP.Text = SoLuong + "";
            }

        }
        void TangGiamSoLuongSP(DTO_SanPham SP, int soluong)
        {
            SP.SoLuongKho = (int.Parse(SP.SoLuongKho) + soluong) + "";
            BUS.BUS bus = new BUS.BUS();
            bus.suaData(SP);
        }

        private void btnAddGioHang_Click(object sender, EventArgs e)
        {
            if (txtSLSP.Text == "")
            {
                MessageBox.Show("Bạn cần phải nhập số lượng");
                return;
            }
            usctrlPanelSanPham ussp = null;
            foreach (usctrlPanelSanPham sanPham in flowGioHang.Controls)
            {
                if(sanPham.MaSP == MaSP)
                {
                    ussp = sanPham;
                }
            }
            if(ussp != null)
            {
                ussp.SoLuong += int.Parse(txtSLSP.Text);
                ussp.DonGia += long.Parse(lblTongtien.Text);
            }
            else
            {
                ussp = new usctrlPanelSanPham(MaSP, lblTenSP.Text, txtSLSP.Text, long.Parse(lblTongtien.Text), lblTrietkhau.Text);
                flowGioHang.Controls.Add(ussp);
            }
            TinhTongTienHang();

            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] sp = bus.search_SANPHAM(MaSP);

            TangGiamSoLuongSP(sp[0], -int.Parse(txtSLSP.Text));
            string st = txtTimkiem.Text;
            txtTimkiem.Text = "a";
            txtTimkiem.Text = st;
            txtTimkiem.Text = "";

            frmMain.check = 1;
        }

        private void TinhTongTienHang()
        {
            TongTienHang = 0;
            foreach (usctrlPanelSanPham sanpham in flowGioHang.Controls)
            {
                TongTienHang += sanpham.DonGia;
            }
            lblTongtienhang.Text = TongTienHang.ToString();

            if (lblTrietkhau.Text == "5%")
            {
                GiamGia = TongTienHang * 5 / 100;
                lblTiengiamgia.Text = GiamGia.ToString();
            }
            else if (lblTrietkhau.Text == "10%")
            {
                GiamGia = TongTienHang * 1 / 10;
                lblTiengiamgia.Text = GiamGia.ToString();
            }
            else if (lblTrietkhau.Text == "20%")
            {
                GiamGia = TongTienHang * 2 / 10;
                lblTiengiamgia.Text = GiamGia.ToString();
            }
            else
            {
                lblTiengiamgia.Text = "0";
            }

            ThanhTien = TongTienHang - long.Parse(lblTiengiamgia.Text);
            lblThanhtien.Text = ThanhTien.ToString();
        }

        private void txtTienkhachdua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblTiendu.Text = (long.Parse(txtTienkhachdua.Text) - long.Parse(lblThanhtien.Text)) + "";
            }
            catch (Exception ex1)
            {
                //MessageBox.Show("Vui lòng nhập đúng số (không bao gồm chữ cái và kí tự đặc biệt)");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (usctrlPanelSanPham sp in flowGioHang.Controls)
            {
                sp.Xoa();
            }
            flowGioHang.Controls.Clear();
            TinhTongTienHang();
        }

        private void flowGioHang_ControlRemoved(object sender, ControlEventArgs e)
        {
            int dem = 0;
            foreach (usctrlPanelSanPham sp in flowGioHang.Controls)
            {
                dem++;
            }
            if (dem == 0)
                frmMain.check = 0;
            TinhTongTienHang();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void picAddKH_Click(object sender, EventArgs e)
        {
            frmThemKhachHang themkh = new frmThemKhachHang();
            themkh.ShowDialog();
            if (themkh.DialogResult == DialogResult.OK)
            {
                usctrlNoti noti = new usctrlNoti("Success", "Thêm khách hàng thành công!");
                noti.Width = this.Width;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                txtIDKH.Text = themkh.MaKH;
            }
        }

        private void picBoxKH_Click(object sender, EventArgs e)
        {
            frmThuNganKH dskh = new frmThuNganKH();
            dskh.ShowDialog();
            txtIDKH.Text = dskh.MaKH;
            try
            {
                if (int.Parse(dskh.DiemTichLuy) > 0 && int.Parse(dskh.DiemTichLuy) <= 30)
                {
                    lblTrietkhau.Text = "5%";
                }
                else if (int.Parse(dskh.DiemTichLuy) > 30 && int.Parse(dskh.DiemTichLuy) <= 75)
                {
                    lblTrietkhau.Text = "10%";
                }
                else if (int.Parse(dskh.DiemTichLuy) > 75)
                {
                    lblTrietkhau.Text = "20%";
                }
                else
                {
                    lblTrietkhau.Text = "0%";
                }

            }
            catch (Exception ex)
            {

            }
        }
        private void ResetAfterPrint()
        {
            Dongia = 0;
            SoLuong = 0;
            TongTienHang = 0;
            ThanhTien = 0;
            lblTiendu.Text = "0";
            txtTienkhachdua.Text = "0";
            lblTiengiamgia.Text = "0";
            flowGioHang.Controls.Clear();
            TinhTongTienHang();
            txtIDKH.Text = "";
            dataNgLapHD.DateTime = DateTime.Today;
            txtSLSP.Text = "";
            txtTimkiem.Text = "";
            lblTongtien.Text = "";
            lblTongtienhang.Text = "";
            frmMain.check = 0;
        }
        private void txtIDKH_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblTrietkhau_Click(object sender, EventArgs e)
        {

        }

        private void lblTiengiamgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblThanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddHD_Click(object sender, EventArgs e)
        {
            if (flowGioHang.Controls.Count < 1)
            {
                usctrlNoti noti = new usctrlNoti("Warning", "Thêm hàng hoá vào giỏ hàng trước khi in hoá đơn!");
                noti.Width = this.Width;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            BUS.BUS bus = new BUS.BUS();
            string mahd = "";
            if (bus.getDataTable("HOADON") == null)
            {
                mahd = "HD01";
                return;
            }
            string str = bus.getThongTinHD(0, bus.getDataTable("HOADON").Rows.Count - 1);
            str = str.Remove(0, 2);
            int temp = str.Length;
            str = (Convert.ToInt32(str) + 1).ToString();
            while (str.Length < temp)
            {
                str = "0" + str;
            }
            mahd = "HD";
            mahd += str;
            int count = 0;
            foreach (usctrlPanelSanPham sanpham in flowGioHang.Controls)
            {
                count += sanpham.SoLuong;
            }
            DTO_HoaDon hd = new DTO_HoaDon(
                mahd,
                DateChange.ToString(dataNgLapHD.DateTime),
                txtIDKH.Text,
                ThongTinDangNhap.MaNV,
                count.ToString(),
                lblTongtienhang.Text,
                lblTiengiamgia.Text,
                lblThanhtien.Text) ;
            bus.themData(hd);
            foreach (usctrlPanelSanPham sp in flowGioHang.Controls)
            {
                sp.ThemData(mahd);
            }
            int.TryParse(txtTienkhachdua.Text, out int tienKhachDua);
            frmInHoaDon bill = new frmInHoaDon(mahd, tienKhachDua);
            bill.ShowDialog();
            if (txtIDKH.Text != "")
            {
                DTO_KhachHang[] kh = new BUS.BUS().search_KhachHang(txtIDKH.Text);
                foreach (DTO_KhachHang k in kh)
                {
                    if (k.MaKH == txtIDKH.Text)
                    {
                        double.TryParse(kh[0].DiemTichLuy, out double diemTichLuy);
                        k.DiemTichLuy = (diemTichLuy + Convert.ToDouble(ThanhTien / 100)).ToString();
                        bus.suaData(k);
                    }
                }
            }
            if (ThongTinDangNhap.UserName == "admin")
            {
                ResetAfterPrint();
                return;
            }
            DTO_NhanVien[] nv = new BUS.BUS().search_NhanVien(ThongTinDangNhap.UserName);
            bus.suaData(nv[0]);
            ResetAfterPrint();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
