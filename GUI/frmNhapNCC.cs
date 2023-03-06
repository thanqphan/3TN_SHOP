using DevExpress.XtraEditors;
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

namespace GUI
{
    public partial class frmNhapNCC : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapNCC()
        {
            InitializeComponent();
        }
        public bool checkHoTen(string ht)//check họ tên phải là chữ
        {
            return Regex.IsMatch(ht, @"[a-zA-Z]");
        }
        public bool checkSDT(string sdt)
        {
            return Regex.IsMatch(sdt, @"0[0-9]");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ktrSo = 0;
            BUS.BUS bus = new BUS.BUS();
            DTO_NhaCungCap ncc = new DTO_NhaCungCap();
            DTO_NhaCungCap[] nhacc = bus.search_NhaCungCap(ncc.MaNCC);
            ncc.MaNCC = txtID.Text;
            ncc.TenNCC = txtName.Text;
            ncc.DiaChi = txtAddress.Text;
            ncc.SDT = txtSDT.Text;
            ncc.TrangThai=cbxTrangThai.SelectedText.ToString();
            if (txtID.Text == "" || txtName.Text == "" || txtSDT.Text == "" || txtAddress.Text == "")
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Không được để trống!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            else if (nhacc[0].MaNCC == ncc.MaNCC)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Mã Nhà Cung Cấp đã tồn tại!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (checkHoTen(txtName.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Tên nhà cung cấp phải là chữ");
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
            else if (txtSDT.Text.LongCount() < 10 || txtSDT.Text.LongCount() > 10 )
            {
                usctrlNoti noti = new usctrlNoti("Error", "Điện thoại di động có 10 số nha bạn!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (!(int.TryParse(this.txtSDT.Text, out ktrSo)))
            {
                usctrlNoti noti = new usctrlNoti("Error", "Điện thoại di động không gồm kí tự!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (nhacc[0].SDT == ncc.SDT)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Số Điện thoại bị trùng ?");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (bus.themData(ncc) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Có lỗi xảy ra! Thêm không thành công!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else
            {
                usctrlNoti noti1 = new usctrlNoti("Success", "Thêm nhà cung cấp thành công!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }

            
            
        }
    }
}