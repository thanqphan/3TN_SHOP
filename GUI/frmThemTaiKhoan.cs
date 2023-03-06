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
    public partial class frmThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }
        private static bool CheckPass(string password)
        {
            bool Kitu_dacbiet = false;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 32 && password[i] <= 47)
                   || (password[i] >= 58 && password[i] <= 64)
                   || (password[i] >= 91 && password[i] <= 96)
                   || (password[i] >= 123 && password[i] <= 126))
                    Kitu_dacbiet = true;
            }
            return Regex.IsMatch(password, @"[A-Z]")
                   && Regex.IsMatch(password, @"[0-9]")
                   && Kitu_dacbiet;
        }
        public bool checkAccount(string ac)//check dộ dài tk và mk
        {
            return Regex.IsMatch(ac, "[a-zA-Z0-9]{6,10}$");
        }
        public bool checkAccount2(string pa)//check dộ dài tk và mk
        {
            return Regex.IsMatch(pa, "^[a-zA-Z0-9!@#~$%^&*_]{6,10}$");
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            DTO_TaiKhoan tk = new DTO_TaiKhoan();

            tk.TenTK = txtName.Text;
            tk.MatKhau = txtPass.Text;
            tk.MaNV = txtIDNV.Text;
            DTO_TaiKhoan[] TK = bus.search_TAIKHOAN(txtIDNV.Text);
            if (txtName.Text == "" || txtIDNV.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Không được để trống!");
                return;
            }
            else if (TK[0].MaNV == txtIDNV.Text)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Tài khoản của Nhân viên đã tồn tại!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            else if (checkAccount(txtName.Text) == false)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Tài khoản phải dài từ 6 đến 10 kí tự");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            else if (checkAccount2(txtPass.Text) == false)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Mật khẩu phải dài từ 6 đến 10 kí tự");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            else if (CheckPass(txtPass.Text) == false)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Mật khẩu phải có 1 chữ In - 1 chữ số - 1 kí tự đặc biệt!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }

            else if (bus.themData(tk) == false)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Thêm tài khoản không thành công!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void picBoxNV_Click(object sender, EventArgs e)
        {
            frmDanhsachNV ds = new frmDanhsachNV();
            ds.ShowDialog();
            txtIDNV.Text = ds.MaNV;
        }
    }
}