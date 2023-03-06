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
    public partial class frmNhapNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapNhanVien()
        {
            
            InitializeComponent();
            cbxChucVu.Text="Phục Vụ";
            cbxSex.Text = "Khác";
            BUS.BUS bus= new BUS.BUS();
            if (bus.getDataTable("NHANVIEN") == null)
            {
                txtID.Text = "NV001";
                return;
            }
            try
            {
                string str = bus.getThongTinNV(0, bus.getDataTable("NHANVIEN").Rows.Count - 1);
                str = str.Remove(0, 2);
                int temp = str.Length;
                str = (Convert.ToInt32(str) + 1).ToString();
                while (str.Length < temp)
                {
                    str = "0" + str;
                }
                string manv = "NV";
                manv += str;
                txtID.Text = manv;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var s = DateTime.Today;
            var x = s.Year - dateNgSinh.DateTime.Year;
            if (cbxChucVu.Text == "Quản lí" && ThongTinDangNhap.UserChucVu == "Quản lí")
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Bạn không có quyền tạo nhân viên với chức vụ này. Vui lòng sử dụng tài khoản - Quản lí");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }

            DTO_NhanVien nv = new DTO_NhanVien(txtID.Text, txtName.Text, txtAddress.Text, txtSDT.Text, cbxSex.Text, dateNgSinh.Text, cbxChucVu.Text);

            string error = CheckNhapVao.check_Nhap(nv);
            if (error != "")
            {
                usctrlNoti noti1 = new usctrlNoti("Error", error);
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            int kiemtrSo;
            BUS.BUS bus = new BUS.BUS();
            DTO_NhanVien ktr = new DTO_NhanVien();
            DTO_NhanVien[] NV = bus.search_NhanVien(ktr.MaNV);

            if (txtSDT.Text.LongCount() < 10 || txtSDT.Text.LongCount() > 10)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Điện thoại di động có '10' số nha bạn!");
                noti.Width = this.Width;
                noti.Height = 25;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            else if (checkHoTen(txtName.Text) == false)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Tên nhân viên phải là chữ");
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
            else if (x < 16)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Tuổi nhân viên phải trên 16 tuổi");
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
            else if (bus.themData(nv) == false)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Thêm nhân viên 'không' thành công!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            else
            {

            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtAddress.Text = txtSDT.Text = "";
            cbxChucVu.Text = "Phục Vụ";
            cbxSex.Text = "Khác";
            dateNgSinh.Text = "";
        }

        private void dateNgSinh_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}