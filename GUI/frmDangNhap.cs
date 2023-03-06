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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public string username;

        public frmDangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            picShow.BringToFront();
        }
        private void DangNhap()
        {
            if (CheckDN(txtName.Text.Trim(), txtPass.Text.Trim()))
            {
                username = txtName.Text;
                BUS.BUS bus = new BUS.BUS();
                if (bus.timKiem_TaiKhoan(username).Rows.Count != 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else if (txtName.Text.ToString() == "" || txtPass.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ Thông tin Đăng nhập!");
            }
            else MessageBox.Show("Vui lòng kiểm tra Mật khẩu!");
            txtPass.Text = "";
        }
        private bool CheckDN(string user, string password)
        {
            BUS.BUS bus = new BUS.BUS();
            DataTable infotable = bus.getDataTable("TAIKHOAN");
            foreach (DataRow row in infotable.Rows)
            {
                if (user == row["TenTK"].ToString())
                {
                    if (password == row["MatKhau"].ToString())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                picHide.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            
            if (txtPass.PasswordChar == '\0')
            {
                picShow.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            DangNhap();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                DangNhap();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                DangNhap();
            }
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                DangNhap();
            }
        }
    }
}