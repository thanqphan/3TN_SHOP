using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usctrlNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public usctrlNhanVien()
        {
            InitializeComponent();
            
        }
        public void Display_ThTin(DTO_NhanVien nv)
        {
            lblID.Text = nv.MaNV;
            lblName.Text = nv.HoTen;
            lblDiaChi.Text = nv.DiaChi;
            lblSDT.Text = nv.SDT;
            lblSex.Text = nv.GT;
            lblDate.Text = TransFormat.SubString( nv.NgSinh);
            lblChucVu.Text = nv.ChucVu;
            
        }
        private DTO_NhanVien[] list_NV;
        public void Display_dgvNV()
        {
            BUS.BUS bus = new BUS.BUS();
            dgvDS.DataSource = bus.getDataTable("NHANVIEN");
            foreach (DataGridViewTextBoxColumn col in this.dgvDS.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaNV":
                        col.HeaderText = "Mã Nhân Viên";
                        break;
                    case "HoTen":
                        col.HeaderText = "Tên Nhân Viên";
                        break;
                    case "DiaChi":
                        col.HeaderText = "Địa Chỉ";
                        break;
                    case "SDT":
                        col.HeaderText = "Hotline";
                        break;
                    case "GT":
                        col.HeaderText = "Giới Tính";
                        break;
                    case "NgSinh":
                        col.HeaderText = "Ngày Sinh";
                        break;
                    case "ChucVu":
                        col.HeaderText = "Chức Vụ";
                        break;
                }
            }
            dgvDS.Columns[0].Width = 50;
            dgvDS.Columns[1].Width = 120;
            dgvDS.Columns[2].Width = 90;
            dgvDS.Columns[3].Width = 110;
            dgvDS.Columns[4].Width = 50;
            dgvDS.Columns[5].Width = 110;
            dgvDS.Columns[6].Width = 100;

        }
        private void usctrlNhanVien_Load(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            string st = bus.getThongTinNV(0, 0);
            list_NV = bus.search_NhanVien(st);
            Display_ThTin(list_NV[0]);
            Display_dgvNV();
        }
        private void ShowSelectedRow()
        {
            try
            {
                DataGridViewRow currow = dgvDS.SelectedCells[0].OwningRow;
                BUS.BUS bus = new BUS.BUS();
                DTO_NhanVien[] NV = bus.search_NhanVien(currow.Cells[0].Value.ToString());
                lblName.Text= NV[0].HoTen;
                lblID.Text = NV[0].MaNV;
                lblDiaChi.Text= NV[0].DiaChi;
                lblSDT.Text= NV[0].SDT;
                lblSex.Text = NV[0].GT;
                lblDate.Text = TransFormat.SubString( NV[0].NgSinh);
                lblChucVu.Text = NV[0].ChucVu;
                
            }
            catch (Exception e)
            {
                string er = "Error";
                lblName.Text = lblChucVu.Text = lblID.Text = lblDate.Text = lblDiaChi.Text =lblSDT.Text=lblSex.Text= er;
                usctrlNoti noti = new usctrlNoti("Error", "Không tìm thấy tên này");
                noti.Width = this.Width;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "")
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Chọn một nhân viên để sửa!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            if (lblChucVu.Text == "Quản lí" && ThongTinDangNhap.UserChucVu == "Quản lí")
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Bạn không có quyền hạn thao tác trên nhân viên này!");
                noti1.Width = pnlNoti.Width;
                this.pnlNoti.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            frmCapnhatnhanvien frmCapNhat = new frmCapnhatnhanvien(lblID.Text);
            frmCapNhat.ShowDialog();
            Display_dgvNV();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "")
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Chọn một nhân viên để xoá!");
                noti1.Width = pnlNoti.Width;
                this.pnlNoti.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            if (lblChucVu.Text == "Quản lí" && ThongTinDangNhap.UserChucVu == "Quản lí")
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Bạn không có quyền hạn thao tác trên nhân viên này. Vui lòng sử dụng một tài khoản cấp cao hơn");
                noti1.Width = pnlNoti.Width;
                this.pnlNoti.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            DialogResult kq = MessageBox.Show("Bạn có chắc xóa nhân viên " + lblName.Text + " ra khỏi cửa hàng", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No) 
                return;
            BUS.BUS bus= new BUS.BUS();
            if (bus.xoaNhanVien(lblID.Text) == false)
                MessageBox.Show("Việc xóa xảy ra một số vấn đề! Liên hệ Thăng :)");
            else 
                MessageBox.Show("Đã xóa nhân viên " + lblName.Text + " ra khỏi cửa hàng");
            Display_dgvNV();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmNhapNhanVien frm = new frmNhapNhanVien();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                usctrlNoti noti1 = new usctrlNoti("Success", "Thêm nhân viên thành công!");
                noti1.Width = pnlNoti.Width;
                this.pnlNoti.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            Display_dgvNV();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDS.DataSource = new BUS.BUS().timKiemNhanh_NhanVien(txtTimKiem.Text);
            ShowSelectedRow();
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            Display_dgvNV();
        }

        

        private void dgvDS_Click(object sender, EventArgs e)
        {
            ShowSelectedRow();
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowSelectedRow();
        }
    }
}
