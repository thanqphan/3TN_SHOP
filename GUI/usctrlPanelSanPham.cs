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
    public partial class usctrlPanelSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private long _dongia = 0;

        public long DonGia
        {
            get
            {
                return _dongia;
            }
            set
            {
                _dongia = value;
                lblGiaTien.Text = _dongia.ToString("0,000");
            }
        }

        private string _ma = "";
        
        public string MaSP
        {
            get
            {
                return _ma;
            }
        }
        private int _soLuong = 0;
        public int SoLuong
        {
            get
            {
                return _soLuong;
            }
            set
            {
                _soLuong = value;
                lblSL.Text = "x" + _soLuong;
            }
        }
        public string trkhau = "";
        public usctrlPanelSanPham(string ma, string TenSP, string soLuong, long donGia, string trietKhau)
        {
            InitializeComponent();
            _ma = ma;
            this._soLuong = int.Parse(soLuong);
            lblSL.Text = "x" + soLuong;
            lblTenSP.Text = TenSP;
            lblGiaTien.Text = donGia.ToString("0,000");
            trkhau = trietKhau;
            if (System.IO.File.Exists(Application.StartupPath + "/HinhSanPham/" + ma + ".jpg"))
                picSP.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + ma + ".jpg");
            else
                picSP.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + ma + ".png");
            this._dongia = donGia;
        }
        void TangGiamSoLuongSP(DTO_SanPham SP, int soluong)
        {
            SP.SoLuongKho = (int.Parse(SP.SoLuongKho) + soluong) + "";
            BUS.BUS bus = new BUS.BUS();
            bus.suaData(SP);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] sp = bus.search_SANPHAM(_ma);
            TangGiamSoLuongSP(sp[0], _soLuong);
            this.Dispose();
            usctrlThuNgan.TongTienHang -= _dongia;
            if (trkhau == "5%")
            {
                usctrlThuNgan.GiamGia = usctrlThuNgan.TongTienHang * 5 / 100;
                usctrlThuNgan.ThanhTien = usctrlThuNgan.TongTienHang - (usctrlThuNgan.GiamGia);
            }
            else if (trkhau == "10%")
            {
                usctrlThuNgan.GiamGia = (usctrlThuNgan.TongTienHang * 1 / 10);
                usctrlThuNgan.ThanhTien = usctrlThuNgan.TongTienHang - (usctrlThuNgan.GiamGia);
            }
            else if (trkhau == "20%")
            {
                usctrlThuNgan.GiamGia = (usctrlThuNgan.TongTienHang * 2 / 10);
                usctrlThuNgan.ThanhTien = usctrlThuNgan.TongTienHang - (usctrlThuNgan.GiamGia);
            }
            else
            {
                usctrlThuNgan.GiamGia = 0;
                usctrlThuNgan.ThanhTien = usctrlThuNgan.TongTienHang - (usctrlThuNgan.GiamGia);
            }
            usctrlThuNgan.txtTemp.Text = "a";
            usctrlThuNgan.txtTemp.Text = "b";
        }
        public void Xoa()
        {
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] sp = bus.search_SANPHAM(_ma);
            TangGiamSoLuongSP(sp[0], _soLuong);
            usctrlThuNgan.TongTienHang -= _dongia;
            if (trkhau == "5%")
            {
                usctrlThuNgan.GiamGia = usctrlThuNgan.TongTienHang * 5 / 100;
                usctrlThuNgan.ThanhTien = usctrlThuNgan.TongTienHang - (usctrlThuNgan.GiamGia);
            }
            else if (trkhau == "10%")
            {
                usctrlThuNgan.GiamGia = (usctrlThuNgan.TongTienHang * 1 / 10);
                usctrlThuNgan.ThanhTien = usctrlThuNgan.TongTienHang - (usctrlThuNgan.GiamGia);
            }
            else if (trkhau == "20%")
            {
                usctrlThuNgan.GiamGia = (usctrlThuNgan.TongTienHang * 2 / 10);
                usctrlThuNgan.ThanhTien = usctrlThuNgan.TongTienHang - (usctrlThuNgan.GiamGia);
            }
            else
            {
                usctrlThuNgan.GiamGia = 0;
                usctrlThuNgan.ThanhTien = usctrlThuNgan.TongTienHang - (usctrlThuNgan.GiamGia);
            }

            usctrlThuNgan.txtTemp.Text = "a";
            usctrlThuNgan.txtTemp.Text = "b";
        }
        public void ThemData(string mahd)
        {
            DTO_CT_HoaDon cthd = new DTO_CT_HoaDon(mahd, _ma, (_dongia / _soLuong).ToString(), _soLuong.ToString());
            BUS.BUS bus = new BUS.BUS();
            bus.themData(cthd);
        }
    }
}
