using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class frmCapnhatnhanvien : DevExpress.XtraEditors.XtraForm
    {
        public string maNV = ""; 
        public frmCapnhatnhanvien(string ma)
        {
            InitializeComponent();
            maNV = ma;
            this.StartPosition=FormStartPosition.CenterScreen;
        }
        private void frmCapnhatnhanvien_Load(object sender, EventArgs e)
        {
            BUS.BUS bus= new BUS.BUS();
            DTO_NhanVien[] nv = bus.search_NhanVien(maNV);
            DTO_NhanVien nhanvien = nv[0];
            txtID.Text = nv[0].MaNV;
            txtID.ReadOnly = true;
            txtAddress.Text = nv[0].DiaChi;
            txtSDT.Text = nv[0].SDT;
            cbxSex.Text = nv[0].GT;
            dateNgSinh.Text = TransFormat.SubString(nv[0].NgSinh);
            cbxChucVu.Text = nv[0].ChucVu;
            txtName.Text = nv[0].HoTen;
        }
        public bool checkHoTen(string ht)//check họ tên phải là chữ
        {
            return Regex.IsMatch(ht, @"[a-zA-Z]");
        }
        public bool checkSDT(string sdt)
        {
            return Regex.IsMatch(sdt, @"0[0-9]");
        }
        private void btnCapnhatnhanvien_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien(txtID.Text,txtName.Text,txtAddress.Text,txtSDT.Text,cbxSex.Text,dateNgSinh.Text,cbxChucVu.Text);
            int kiemtrSo;
            BUS.BUS bus = new BUS.BUS();
            DTO_NhanVien ktr = new DTO_NhanVien();
            DTO_NhanVien[] NV = bus.search_NhanVien(ktr.MaNV);
            
            if (bus.suaData(nv) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Có lỗi xảy ra! Sửa không thành công!");
                noti.Width = this.Width;
                noti.Height = 30;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (checkHoTen(txtName.Text) == false)
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
            else if (txtSDT.Text.LongCount() < 10 || txtSDT.Text.LongCount() > 10)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Điện thoại di động có '10' số nha bạn!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if ((NV[0].HoTen).ToString() == null)
            {
                usctrlNoti noti = new usctrlNoti("Error", "mời nhập tên");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (!(int.TryParse(this.txtSDT.Text, out kiemtrSo)))
            {
                usctrlNoti noti = new usctrlNoti("Error", "Điện thoại di động không gồm kí tự!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if ((NV[0].SDT).ToString() == txtSDT.Text.ToString())
            {
                usctrlNoti noti = new usctrlNoti("Error", "Số Điện thoại bị trùng ?");
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
                noti1.Height = 30;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
        }

        
    }
}