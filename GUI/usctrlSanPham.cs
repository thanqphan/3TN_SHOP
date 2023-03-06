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
    public partial class usctrlSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private int number_Page = 1;
        private int current_Page = 1;
        private DTO_SanPham[] list_SP;
        public usctrlSanPham()
        {
            InitializeComponent();
        }
        void XuatDuLieuSP(PictureBox pic, Label name, DTO_SanPham sp)
        {
            if (sp == null)
            {
                pic.Image = null;
                name.Text = "";
                return;
            }
            if (System.IO.File.Exists(Application.StartupPath + "/HinhSanPham/" + sp.MaSP + ".jpg"))
                pic.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + sp.MaSP + ".jpg");
            else
                if (System.IO.File.Exists(Application.StartupPath + "/HinhSanPham/" + sp.MaSP + ".png"))
                pic.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + sp.MaSP + ".png");
            else
                pic.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/None" + ".png");
            name.Text = sp.TenSP;
            //MessageBox.Show(Application.StartupPath + "/HinhSanPham/" + sp.MASP + ".jpg");
        }
        void HienThiTrang(int number_Page)
        {
            int Pos_Start = 9 * (number_Page - 1);
            int Pos_End = list_SP.Length - Pos_Start;
            DTO_SanPham SP = list_SP[Pos_Start];
            if (Pos_End <= 0) SP = null;
            XuatDuLieuSP(pic1, lblSP1, SP);
            if (Pos_End <= 1) SP = null;
            else SP = list_SP[Pos_Start + 1];
            XuatDuLieuSP(pic2, lblSP2, SP);

            if (Pos_End <= 2) SP = null;
            else SP = list_SP[Pos_Start + 2];
            XuatDuLieuSP(pic3, lblSP3, SP);

            if (Pos_End <= 3) SP = null;
            else SP = list_SP[Pos_Start + 3];
            XuatDuLieuSP(pic4, lblSP4, SP);

            if (Pos_End <= 4) SP = null;
            else SP = list_SP[Pos_Start + 4];
            XuatDuLieuSP(pic5, lblSP5, SP);

            if (Pos_End <= 5) SP = null;
            else SP = list_SP[Pos_Start + 5];
            XuatDuLieuSP(pic6, lblSP6, SP);

            if (Pos_End <= 6) SP = null;
            else SP = list_SP[Pos_Start + 6];
            XuatDuLieuSP(pic7, lblSP7, SP);

            if (Pos_End <= 7) SP = null;
            else SP = list_SP[Pos_Start + 7];
            XuatDuLieuSP(pic8, lblSP8, SP);

            if (Pos_End <= 8) SP = null;
            else SP = list_SP[Pos_Start + 8];
            XuatDuLieuSP(pic9, lblSP9, SP);
        }
        void XuatThongTinSP(DTO_SanPham SP)
        {
            lblID.Text = SP.MaSP;
            lblName.Text = SP.TenSP;
            lblColor.Text = SP.MauSP;
            lblSize.Text = SP.SizeSP;
            lblIDLoai.Text = SP.MaLoaiSP;
            lblSL.Text = SP.SoLuongKho;
            lblStatus.Text = SP.TrangThai;
            lblDonGia.Text = SP.DonGia;
            BUS.BUS bus = new BUS.BUS();
            //lblNCC.Text = bus.getTenNCC(SP.MANCC);
            string ma = lblID.Text;
            if (System.IO.File.Exists(Application.StartupPath + "/HinhSanPham/" + ma + ".jpg"))
                picSP.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + ma + ".jpg");
            else
                if (System.IO.File.Exists(Application.StartupPath + "/HinhSanPham/" + ma + ".png"))
                picSP.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + ma + ".png");
            else
                picSP.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/None" + ".png");
        }
    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCapnhatsanpham frmCapNhat = new frmCapnhatsanpham(lblID.Text);
            frmCapNhat.ShowDialog();
            string temp = txtTimKiem.Text;
            txtTimKiem.Text = " ";
            txtTimKiem.Text = temp;
            HienThiTrang(current_Page);
            lblPage.Text = current_Page + "/" + number_Page;
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] SP = bus.search_SANPHAM(lblID.Text);
            XuatThongTinSP(SP[0]);
        }

        private void usctrlSanPham_Load(object sender, EventArgs e)
        {
            txtTimKiem.Text = " ";
            txtTimKiem.Text = "";
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] SP = bus.search_SANPHAM("a");
            XuatThongTinSP(SP[0]);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            list_SP = bus.search_SANPHAM(txtTimKiem.Text);
            HienThiTrang(1);
            current_Page = 1;
            number_Page = list_SP.Length / 9 + 1;
            lblPage.Text = "1/" + number_Page;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (current_Page == 1) return;
            current_Page--;
            lblPage.Text = current_Page + "/" + number_Page;
            HienThiTrang(current_Page);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (current_Page == number_Page) return;
            current_Page++;
            lblPage.Text = current_Page + "/" + number_Page;
            HienThiTrang(current_Page);
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = " ";
            txtTimKiem.Text = "";
        }
        void Click_Cell_SP(int index)
        {
            DTO_SanPham SP = list_SP[(current_Page - 1) * 9 + index - 1];
            XuatThongTinSP(SP);
        }
        #region
        private void pic1_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image == null) return;
            Click_Cell_SP(1);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image == null) return;
            Click_Cell_SP(2);
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image == null) return;
            Click_Cell_SP(3);
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image == null) return;
            Click_Cell_SP(4);
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image == null) return;
            Click_Cell_SP(5);
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image == null) return;
            Click_Cell_SP(6);
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image == null) return;
            Click_Cell_SP(7);
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image == null) return;
            Click_Cell_SP(8);
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image == null) return;
            Click_Cell_SP(9);
        }

        #endregion pic

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmThemSanPham frm = new frmThemSanPham();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                usctrlNoti noti1 = new usctrlNoti("Success", "Thêm hàng hoá mới thành công!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            string temp = txtTimKiem.Text;
            txtTimKiem.Text = " ";
            txtTimKiem.Text = temp;
            HienThiTrang(current_Page);
            lblPage.Text = current_Page + "/" + number_Page;

            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] SP = bus.search_SANPHAM(lblID.Text);
            XuatThongTinSP(SP[0]);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            DialogResult res = MessageBox.Show("Bạn có chắc xóa sản phẩm " + lblName.Text + " không",
                "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            if (bus.xoaSanPham(lblID.Text))
                MessageBox.Show("Bạn đã xóa " + lblName.Text + " thành công");
            else
            {
                MessageBox.Show("Có vấn đề xảy ra! Không thành công");
                return;
            }
            string temp = txtTimKiem.Text;
            txtTimKiem.Text = " ";
            txtTimKiem.Text = temp;
            HienThiTrang(current_Page);
            lblPage.Text = current_Page + "/" + number_Page;

            DTO_SanPham[] SP = bus.search_SANPHAM(bus.getThongTinSP(0, 0));
            XuatThongTinSP(SP[0]);
        }
    }
}
