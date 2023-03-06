using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Filtering.Templates;
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
    public partial class frmCapnhatnhacungcap : DevExpress.XtraEditors.XtraForm
    {
        public frmCapnhatnhacungcap(string maNCC)
        {
            InitializeComponent();
            BUS.BUS bus = new BUS.BUS(); 
            DTO_NhaCungCap[] ncc = bus.search_NhaCungCap(maNCC);
            DTO_NhaCungCap nc = ncc[0];
            lblMaNCC.Text = maNCC;
            txtDiachi.Text = nc.DiaChi;
            txtSodienthoaiNCC.Text = nc.SDT;
            txtTenNCC.Text = nc.TenNCC; 
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public bool checkHoTen(string ht)//check họ tên phải là chữ
        {
            return Regex.IsMatch(ht, @"[a-zA-Z]");
        }
        public bool checkSDT(string sdt)
        {
            return Regex.IsMatch(sdt, @"0[0-9]");
        }
        private void btnCapnhatNCC_Click(object sender, EventArgs e)
        {
            int ktrSo = 0;
            DTO_NhaCungCap NCC = new DTO_NhaCungCap(lblMaNCC.Text, txtTenNCC.Text, txtDiachi.Text, txtSodienthoaiNCC.Text, cbxTrangThai.Text);
            BUS.BUS bus = new BUS.BUS();
            DTO_NhaCungCap ncc = new DTO_NhaCungCap();
            DTO_NhaCungCap[] nhacc = bus.search_NhaCungCap(ncc.MaNCC);
            if (txtDiachi.Text == "" || txtSodienthoaiNCC.Text == "" || txtTenNCC.Text == "")
            {
                usctrlNoti noti = new usctrlNoti("Error", "Không được để trống!!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (checkHoTen(txtTenNCC.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Tên nhà cung cấp phải là chữ");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (checkSDT(txtSodienthoaiNCC.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Số điện thoại sai định dạng");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (txtSodienthoaiNCC.Text.LongCount() < 10 || txtSodienthoaiNCC.Text.LongCount() > 10)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Điện thoại di động có '10' số nha bạn!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (!(int.TryParse(this.txtSodienthoaiNCC.Text, out ktrSo)))
            {
                usctrlNoti noti = new usctrlNoti("Error", "Điện thoại di động không gồm kí tự!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            //else if ((nhacc[0].SDT).ToString() == txtSodienthoaiNCC.Text.ToString())
            //{
            //    usctrlNoti noti = new usctrlNoti("Error", "Số Điện thoại bị trùng ?");
            //    noti.Width = this.Width;
            //    noti.Height = 25;
            //    this.Controls.Add(noti);
            //    noti.Show();
            //    noti.ShowNoti();
            //    return;
            //}
            else if (bus.suaData(NCC) == false)
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
            }
        }

        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}