using DTO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanLiTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLiTaiKhoan()
        {
            InitializeComponent();
        }
        private void ShowSelectedRow()
        {
            try
            {
                DataGridViewRow currow = dgvTaiKhoan.SelectedCells[0].OwningRow;
                lblName.Text = currow.Cells[0].Value.ToString();
                txtPass.Text = currow.Cells[3].Value.ToString();
                lblMaNV.Text = currow.Cells[2].Value.ToString();
            }
            catch (Exception e)
            {
                lblName.Text = "Lỗi Truy xuất";
                txtPass.Text = "";
            }
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
        public bool checkAccount2(string pa)//check dộ dài tk và mk
        {
            return Regex.IsMatch(pa, "^[a-zA-Z0-9!@#~$%^&*_]{6,10}$");
        }
        public void Display_dgvTaiKhoan()
        {
            BUS.BUS bus = new BUS.BUS();
            dgvTaiKhoan.DataSource = bus.timKiem_TaiKhoan_NhanVien();
            foreach (DataGridViewTextBoxColumn col1 in this.dgvTaiKhoan.Columns)
            {
                switch (col1.HeaderText)
                {
                    case "TenTK":
                        col1.HeaderText = "Tên đăng nhập";
                        break;
                    case "HoTen":
                        col1.HeaderText = "Tên chủ tài khoản";
                        break;
                    case "MatKhau":
                        col1.HeaderText = "Mật Khẩu";
                        break;
                    case "LoaiTK":
                        col1.HeaderText = "Loại tài khoản";
                        break;
                    case "MaNV":
                        col1.HeaderText = "Mã Nhân Viên";
                        break;
                }
            }
        }

        private void frmQuanLiTaiKhoan_Load(object sender, EventArgs e)
        {
            Display_dgvTaiKhoan();
            ShowSelectedRow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DTO_TaiKhoan tk = new DTO_TaiKhoan();
            tk.TenTK = lblName.Text;
            tk.MatKhau=txtPass.Text;
            tk.MaNV=lblMaNV.Text;
            BUS.BUS bus = new BUS.BUS();
            if (checkAccount2(txtPass.Text) == false)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Mật khẩu phải dài từ 6 đến 10 kí tự!");
                noti1.Width = this.Width;
                this.pnlHead.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            else if (CheckPass(txtPass.Text)==false)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Mật khẩu phải có 1 chữ In - 1 chữ số - 1 kí tự đặc biệt!!");
                noti1.Width = this.Width;
                this.pnlHead.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            else if (bus.suaData(tk) == false)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Đổi mật khẩu không thành công!");
                noti1.Width = this.Width;
                this.pnlHead.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            else
            {
                
                usctrlNoti noti1 = new usctrlNoti("Success", "Đổi mật khẩu thành công!");
                noti1.Width = this.Width;
                this.pnlHead.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            //Display_dgvTaiKhoan();
            //ShowSelectedRow();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frm = new frmThemTaiKhoan();
            frm.ShowDialog();
            Display_dgvTaiKhoan();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lblName.Text == "admin")
            {
                usctrlNoti noti1 = new usctrlNoti("Warning", "Không thể xoá tài khoản admin!");
                noti1.Width = this.Width;
                this.pnlHead.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            DialogResult kq = MessageBox.Show("Bạn có chắc xóa tài khoản " + lblName.Text + "?", "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No) return;
            BUS.BUS bus = new BUS.BUS();
            if (bus.xoaTaiKhoan(lblName.Text) == false)
                MessageBox.Show("Việc xóa xảy ra một số vấn đề! Không thành công");
            else 
                MessageBox.Show("Đã xóa tài khoản " + lblName.Text + " ra khỏi hệ thống!");
            Display_dgvTaiKhoan();
            ShowSelectedRow();
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            ShowSelectedRow();
        }
    }
}