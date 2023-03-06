using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {

        public string MaKH;
        public frmThemKhachHang()
        {
            MaKH = null;
            InitializeComponent();
            BUS.BUS bus = new BUS.BUS();
            if (bus.getDataTable("KHACHHANG") == null)
            {
                txtMaKH.Text = "KH01";
                return;
            }
            try
            {
                string str = bus.getThongTinKH(0, bus.getDataTable("KHACHHANG").Rows.Count - 1);
                str = str.Remove(0, 2);
                int temp = str.Length;
                str = (Convert.ToInt32(str) + 1).ToString();
                while (str.Length < temp)
                {
                    str = "0" + str;
                }
                string makh = "KH";
                makh += str;
                txtMaKH.Text = makh;
            }
            catch (Exception ex) { }
        }

        public bool checkHoTen(string ht)//check họ tên phải là chữ
        {
            return Regex.IsMatch(ht, @"[a-zA-Z]");
        }
        public bool checkSDT(string sdt)
        {
            return Regex.IsMatch(sdt, @"0[0-9]");
        }
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            DTO_KhachHang kh = new DTO_KhachHang();
            DTO_NhaCungCap[] KH = bus.search_NhaCungCap(kh.MaKH);
            kh.HoTen = txtName.Text;
            kh.MaKH = txtMaKH.Text;
            kh.GioiTinh = cbxGT.Text;
            kh.SDT = txtSDT.Text;
            kh.DiemTichLuy = txtDiemTL.Text;
            string error = CheckNhapVao.check_Nhap(kh);
            int temp = 0;
            if (txtMaKH.Text == "" || txtName.Text == "" || txtSDT.Text == "" || txtSDT.Text == "" )
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Không được để trống!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            if (error != "")
            {
                usctrlNoti noti1 = new usctrlNoti("Error", error);
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            else if (checkHoTen(txtName.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Tên khách hàng phải là chữ");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (checkSDT(txtSDT.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Số điện thoại sai định dạng");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (KH[0].SDT == kh.SDT)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Số Điện thoại bị trùng ?");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (bus.themData(kh) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Có lỗi xảy ra, thêm khách hàng không thành công!");
                noti.Width = 800;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else
            {
                usctrlNoti noti1 = new usctrlNoti("Success", "Thêm khách hàng thành công!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            Close();
        }
    }

}