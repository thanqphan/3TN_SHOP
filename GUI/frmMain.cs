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

namespace GUI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        #region Khởi tạo
        private usctrlDoanhThu usDoanhThu = new usctrlDoanhThu();
        private usctrlHoaDon usHoaDon = new usctrlHoaDon();
        private usctrlKhachHang usKhachHang = new usctrlKhachHang();
        private usctrlNhaCungCap usNhaCungCap = new usctrlNhaCungCap(); 
        private usctrlNhanVien usNhanVien = new usctrlNhanVien();
        private usctrlNhapHang usNhapHang = new usctrlNhapHang(username);   
 //       private usctrlPanelSanPham usPanelSanPham = new usctrlPanelSanPham();
        private usctrlSanPham usSanPham = new usctrlSanPham();
        private usctrlThuNgan usThuNgan = new usctrlThuNgan();
        private usctrlTongQuan usTongQuan = new usctrlTongQuan();
        private usctrlPhieuNhap usPhieuNhap = new usctrlPhieuNhap();
        private usctrlTonKho usTonKho = new usctrlTonKho();
        #endregion
        public static string username;
        public static int check = 0;
        public frmMain()
        {
            InitializeComponent();
            pnlUserControl.Controls.Add(usTongQuan);
        }
        //Ẩn các list của button chức năng chính
        private void Status_Label_List()
        {
            pnlThuNgan.Visible = false;
            pnlKhoHang.Visible = false;
            pnlQuanLi.Visible = false;
            pnlThongKe.Visible = false;
            pnlHeThong.Visible = false;
        }
        private void Status_Button_QLKho()
        {
            btnThuNgan.Enabled = false;
            btnHeThong.Enabled = false;
            btnNV.Enabled = false;
            btnKhachHang.Enabled = false;
            btnTKPN.Enabled = false;
            btnTKDT.Enabled = false;
        }
        private void Status_Button_ThuNgan()
        {
            btnKho.Enabled= false;
            btnHeThong.Enabled = false;
            btnNV.Enabled = false;
            btnNCC.Enabled = false;
            btnTKKho.Enabled = false;
            btnTKPN.Enabled = false;

        }
        public bool CheckChuyenTab()
        {
            if (check == 1)
            {
                MessageBox.Show("Bạn đang nhập Hóa Đơn mới. Vui lòng xóa toàn bộ Giỏ Hàng hiện tại!", "Bạn muốn Hủy Đơn?", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        //remove panel đang hiển thị
        public void ClearPanelUser()
        {
            foreach(var x in pnlUserControl.Controls)
            {
                if (!(x is Panel))
                    pnlUserControl.Controls.Remove(x as UserControl);
            }
        }
        public void Init_AllPanelList()
        {
            int i = 140;
            pnlThuNgan.Location = new Point(i, 0);
            i = i + 138;
            pnlKhoHang.Location = new Point(i, 0);
            i = i + 137;
            pnlQuanLi.Location = new Point(i, 0);
            i = i + 136;
            pnlThongKe.Location = new Point(i, 0);
            i = i + 135;
            pnlHeThong.Location = new Point(i, 0);
            i = i + 135;
        }
        public frmMain(string userName)
        {
            InitializeComponent();
            pnlHeThong.Visible = false;
            BUS.BUS bus = new BUS.BUS();
            DTO_NhanVien[] nv=bus.search_NhanVien_theoTenTK(userName);
            ThongTinDangNhap.UserName = userName;
            ThongTinDangNhap.UserChucVu= nv[0].ChucVu;
            ThongTinDangNhap.MaNV = nv[0].MaNV;
            btnNameUser.Text = nv[0].HoTen;
            if(ThongTinDangNhap.UserChucVu=="Quản lí ")
            {

                pnlHeThong.Visible=true;
            }
            if(ThongTinDangNhap.UserChucVu=="Quản lí Kho")
            {
                Status_Button_QLKho();
            }
            if(ThongTinDangNhap.UserChucVu=="Thu Ngân")
            {
                Status_Button_ThuNgan();
            }
            pnlUserControl.Controls.Add(usTongQuan);
            usTongQuan.Dispose();
            usTongQuan= new usctrlTongQuan();
            pnlUserControl.Controls.Add(usTongQuan);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Status_Label_List();
            Init_AllPanelList();
        }
        private void btnMain_Click(object sender, EventArgs e)
        {
            if (CheckChuyenTab())
                return;
            ClearPanelUser();
            usTongQuan.Dispose();
            usTongQuan = new usctrlTongQuan();
            pnlUserControl.Controls.Add(usTongQuan);
            Status_Label_List();
        }

        private void btnThuNgan_Click(object sender, EventArgs e)
        {
            if (CheckChuyenTab())
                return;
            bool temp = pnlThuNgan.Visible;
            Status_Label_List();
            pnlThuNgan.Visible = !temp;
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            if (CheckChuyenTab())
                return;
            bool temp = pnlKhoHang.Visible;
            Status_Label_List();
            pnlKhoHang.Visible = !temp;

        }

        private void btnQuanLi_Click(object sender, EventArgs e)
        {
            if (CheckChuyenTab())
                return;
            bool temp = pnlQuanLi.Visible;
            Status_Label_List();
            pnlQuanLi.Visible = !temp;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (CheckChuyenTab())
                return;
            bool temp = pnlThongKe.Visible;
            Status_Label_List();
            pnlThongKe.Visible = !temp;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if (CheckChuyenTab())
                return;
            bool temp = pnlHeThong.Visible;
            Status_Label_List();
            pnlHeThong.Visible = !temp;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ClearPanelUser();
            usThuNgan.Dispose();
            usThuNgan= new usctrlThuNgan();
            pnlUserControl.Controls.Add(usThuNgan);
            Status_Label_List();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ClearPanelUser();
            usHoaDon.Dispose();
            usHoaDon = new usctrlHoaDon();
            pnlUserControl.Controls.Add(usHoaDon);
            Status_Label_List();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ClearPanelUser();
            usNhapHang.Dispose();
            usNhapHang = new usctrlNhapHang(username);
            pnlUserControl.Controls.Add(usNhapHang);
            Status_Label_List();
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ClearPanelUser();
            usSanPham.Dispose();
            usSanPham = new usctrlSanPham();
            pnlUserControl.Controls.Add(usSanPham);
            Status_Label_List();
        }


        private void btnNV_Click(object sender, EventArgs e)
        {
            ClearPanelUser();
            usNhanVien.Dispose();
            usNhanVien = new usctrlNhanVien();
            pnlUserControl.Controls.Add(usNhanVien);
            Status_Label_List();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            ClearPanelUser();
            usNhaCungCap.Dispose();
            usNhaCungCap = new usctrlNhaCungCap();
            pnlUserControl.Controls.Add(usNhaCungCap);
            Status_Label_List();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ClearPanelUser();
            usKhachHang.Dispose();
            usKhachHang = new usctrlKhachHang();
            pnlUserControl.Controls.Add(usKhachHang);
            Status_Label_List();
        }

        private void btnTKKho_Click(object sender, EventArgs e)
        {
            ClearPanelUser();
            usTonKho.Dispose();
            usTonKho = new usctrlTonKho();
            pnlUserControl.Controls.Add(usTonKho);
            Status_Label_List();
        }

        private void btnTKPN_Click(object sender, EventArgs e)
        {
            ClearPanelUser();
            usPhieuNhap.Dispose();
            usPhieuNhap = new usctrlPhieuNhap();
            pnlUserControl.Controls.Add(usPhieuNhap);
            Status_Label_List();
        }

        private void btnTKDT_Click(object sender, EventArgs e)
        {
            ClearPanelUser();
            usDoanhThu.Dispose();
            usDoanhThu = new usctrlDoanhThu();
            pnlUserControl.Controls.Add(usDoanhThu);
            Status_Label_List();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLiTaiKhoan tk = new frmQuanLiTaiKhoan();
            tk.ShowDialog();
            //khi gọi phương thức này chương trình sẽ ngưng thực hiện các đoạn lệnh tiếp theo cho đến khi form đóng lại.
        }

        private void pnlMain_Leave(object sender, EventArgs e)
        {
            Status_Label_List();
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            Status_Label_List();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            if (CheckChuyenTab())
                return;
            Application.Exit();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            if (CheckChuyenTab())
                return;
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
               foreach (Form f in Application.OpenForms)
              {
                   f.DialogResult = DialogResult.OK;
                    f.Close();
                   return;
               }
                frmDangNhap d = new frmDangNhap();
                d.ShowDialog();
            }
            /*DialogResult kq = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                frmDangNhap d = new frmDangNhap();
                d.Show();
                Hide();
            }*/

        }
    }
}