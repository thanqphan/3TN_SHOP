using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemSanPham : DevExpress.XtraEditors.XtraForm
    {
        private string fileAnh = "";
        public frmThemSanPham()
        {
            InitializeComponent();
            BUS.BUS bus = new BUS.BUS();
            if (bus.getDataTable("SANPHAM") == null)
            {
                txtID.Text = "SP001";
                return;
            }
            try
            {
                string str = bus.getThongTinSP(0, bus.getDataTable("SANPHAM").Rows.Count - 1);
                str = str.Remove(0, 2);
                int temp = str.Length;
                str = (Convert.ToInt32(str) + 1).ToString();
                while (str.Length < temp)
                {
                    str = "0" + str;
                }
                string masp = "SP";
                masp += str;
                txtID.Text = masp;
            }
            catch (Exception ex) { }
        }
        public bool checkHoTen(string ht)//check họ tên phải là chữ
        {
            return Regex.IsMatch(ht, @"[a-zA-Z]");
        }
        public bool checknumber(string dg)
        {
            return Regex.IsMatch(dg, @"[0-9]");
        }
        private void frmThemSanPham_Load(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] sp = bus.search_SANPHAM("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham sp = new DTO_SanPham();
            sp.MaSP = txtID.Text;
            sp.TenSP = txtName.Text;
            sp.MauSP = txtColor.Text;
            sp.SizeSP = cbxSize.Text;
            sp.DonGia = txtDongia.Text;
            sp.MaLoaiSP = txtSL.Text;
            sp.SoLuongKho = txtSL.Text;
            sp.TrangThai = cbxTrangThai.Text;
            string error = CheckNhapVao.check_Nhap(sp);
            if (error != "")
            {
                usctrlNoti noti1 = new usctrlNoti("Error", error);
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            if (checkHoTen(txtName.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Tên sản phẩm phải là chữ");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (checkHoTen(txtColor.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Màu sản phẩm phải là chữ");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (checknumber(txtDongia.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Đơn giá phải là số");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (checknumber(txtSL.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "số lượng phải là số");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (bus.themData(sp) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Có lỗi xảy ra, thêm không thành công!");
                noti.Width = this.Width;
                noti.Height = 30;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else
            {

            }
            string desAnh = Application.StartupPath + "/HinhSanPham/" + sp.MaSP + ".jpg";
            if (fileAnh != "")
            {
                if (File.Exists(desAnh))
                    File.Delete(desAnh);
                File.Copy(fileAnh, desAnh);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void picChonPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileAnh = dlg.FileName;
            }
            else return;
            picPic.Image = Image.FromFile(fileAnh);
        }

        private void picPic_Click(object sender, EventArgs e)
        {

        }
    }
}