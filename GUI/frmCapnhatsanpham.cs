using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask.Design;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmCapnhatsanpham : DevExpress.XtraEditors.XtraForm
    {
        public frmCapnhatsanpham(string MaSP)
        {
            InitializeComponent();
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] SP = bus.search_SANPHAM(MaSP);
            lblID.Text = SP[0].MaSP;
            txtTenSP.Text = SP[0].TenSP;
            lblIDLoai.Text = SP[0].MaLoaiSP;
            txtMauSP.Text = SP[0].MauSP;
            txtSize.Text = SP[0].SizeSP;
            txtGia.Text = SP[0].DonGia;
            txtSoluong.Text = SP[0].SoLuongKho;
            cbbTrangthai.Text = SP[0].TrangThai;
            string ma = lblID.Text;
            if (System.IO.File.Exists(Application.StartupPath + "/HinhSanPham/" + ma + ".jpg"))
                picCapnhatsanpham.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + ma + ".jpg");
            else
                picCapnhatsanpham.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + ma + ".png");
        }
        public bool checkHoTen(string ht)//check họ tên phải là chữ
        {
            return Regex.IsMatch(ht, @"[a-zA-Z]");
        }
        private void frmCapnhatsanpham_Load(object sender, EventArgs e)
        {

        }

        private void btnCapnhatsanpham_Click(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham SP = new DTO_SanPham();
            SP.MaSP = lblID.Text;
            SP.TenSP = txtTenSP.Text;
            SP.MauSP = txtMauSP.Text;
            SP.SizeSP = txtSize.Text;
            SP.DonGia = txtGia.Text;
            SP.MaLoaiSP = lblIDLoai.Text;
            SP.SoLuongKho = txtSoluong.Text;
            SP.TrangThai = cbbTrangthai.Text;
            if (bus.suaData(SP))
            {
                usctrlNoti noti1 = new usctrlNoti("Success", "Cập nhật thông tin thành công!");
                noti1.Width = this.Width;
                noti1.Height = 30;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            else if (checkHoTen(txtTenSP.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Tên sản phẩm phải là chữ");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else
            {
                usctrlNoti noti = new usctrlNoti("Error", "Có lỗi xảy ra! Sửa không thành công!");
                noti.Width = this.Width;
                noti.Height = 30;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
        }
    }
}