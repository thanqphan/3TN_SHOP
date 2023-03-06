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
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frmCapnhatkhachhang : DevExpress.XtraEditors.XtraForm
    {
        //static private string MaKH = "";
        public frmCapnhatkhachhang()
        {
            InitializeComponent();

        }
        public void SetValue(string hoTen, string gioiTinh, string SDT, string maKH, string diemTichLuy)
        {
            txtHoten.Text = hoTen;
            cbxGT.Text = gioiTinh;
            txtSDT.Text = SDT;
            lblMaKH.Text = maKH;
            txtDiemtichluy.Text = diemTichLuy;
            
        }

        public bool checkHoTen(string ht)//check họ tên phải là chữ
        {
            return Regex.IsMatch(ht, @"[a-zA-Z]");
        }
        public bool checkSDT(string sdt)
        {
            return Regex.IsMatch(sdt, @"0[0-9]");
        }

        private void btnCapnhatkhachhang_Click_1(object sender, EventArgs e)
        {
            int temp = 0;
            DTO_KhachHang KH = new DTO_KhachHang();
            BUS.BUS bus = new BUS.BUS();
            DTO_KhachHang kh = new DTO_KhachHang();
            DTO_KhachHang[] khachhang = bus.search_KhachHang(kh.MaKH);
            KH.MaKH = lblMaKH.Text;
            KH.HoTen = txtHoten.Text;
            KH.GioiTinh = cbxGT.Text;
            KH.SDT = txtSDT.Text;
            KH.DiemTichLuy = txtDiemtichluy.Text;
            if (txtHoten.Text == "" || txtSDT.Text == "" || txtDiemtichluy.Text == "" || lblMaKH.Text == "")
            {
                usctrlNoti noti = new usctrlNoti("Error", "Không được để trống!!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            /*else if (bus.suaData(KH))
            {
                usctrlNoti noti = new usctrlNoti("Success", "Bạn đã cập nhật thành công");
                noti.Width = 800;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }*/
            else if (txtSDT.Text.LongCount() < 0 || txtSDT.Text.LongCount() > 10)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Hãy nhập lại số điện thoại của bạn!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (checkHoTen(txtHoten.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Họ tên phải là chữ");
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
            else if (txtSDT.Text.LongCount() < 10)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Số điện thoại phải 10 số");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (!(int.TryParse(this.txtSDT.Text, out temp)))
            {
                usctrlNoti noti = new usctrlNoti("Error", "Điện thoại di động không gồm kí tự!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }

            else if (bus.suaData(KH) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Có lỗi xảy ra! Sửa không thành công!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else
            {
                usctrlNoti noti1 = new usctrlNoti("Success", "Cập nhật thông tin thành công!");
                noti1.Width = this.Width;
                noti1.Height = 25;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
        }
    }
}