using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class usctrlKhachHang : UserControl
    {
        usctrlNoti noti = new usctrlNoti();

        public usctrlKhachHang()
        {
            InitializeComponent();
            Show_DgvKH();
        }
        private DTO_KhachHang[] list_KH;
        public void TTKhachHang(DTO_KhachHang kh)
        {
            lblID.Text = kh.MaKH;
            lblName.Text = kh.HoTen;
            lblSDT.Text = kh.SDT;
            lblDiemTichLuy.Text = kh.DiemTichLuy;
        }

        public void Show_DgvKH()
        {
            BUS.BUS bus = new BUS.BUS();
            dgvDS.DataSource = bus.getDataTable("KHACHHANG");
            foreach (DataGridViewTextBoxColumn col in this.dgvDS.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaKH":
                        col.HeaderText = "Mã nhân viên";
                        break;
                    case "HoTen":
                        col.HeaderText = "Họ tên";
                        break;
                    case "GioiTinh":
                        col.HeaderText = "Giới tính";
                        break;;
                    case "SDT":
                        col.HeaderText = "Số Điện Thoại";
                        break;
                    case "DiemTichLuy":
                        col.HeaderText = "Điểm tích luỹ";
                        break;
                }
            }
        }
        private void usctrlKhachHang_Load(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            string st = bus.getThongTinKH(0, 0);
            list_KH = bus.search_KhachHang(st);
            TTKhachHang(list_KH[0]);
            Show_DgvKH();

        }
        private void btnDel_Click_1(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc xóa nhà cung cấp " + lblName.Text + " ra khỏi cửa hàng", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No)
                return;
            BUS.BUS bus = new BUS.BUS();
            if (bus.xoaKhachHang(lblID.Text) == false)
                MessageBox.Show("Việc xóa xảy ra một số vấn đề! Không thành công");
            else
                MessageBox.Show("Đã xóa khách hàng thành công " + lblName.Text);
            Show_DgvKH();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            if (dgvDS.CurrentRow != null)
            {
                frmCapnhatkhachhang frm = new frmCapnhatkhachhang();

                frm.SetValue(dgvDS.CurrentRow.Cells["HoTen"].Value.ToString(),
                    dgvDS.CurrentRow.Cells["GioiTinh"].Value.ToString(),
                    dgvDS.CurrentRow.Cells["SDT"].Value.ToString(),
                    dgvDS.CurrentRow.Cells["MaKH"].Value.ToString(),
                    dgvDS.CurrentRow.Cells["DiemTichLuy"].Value.ToString());  
                frm.ShowDialog();

                Show_DgvKH();
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng");
            }
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang();
            frm.ShowDialog();
            Show_DgvKH();

        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            dgvDS.DataSource = new BUS.BUS().timKiem_KhachHang(txtTimKiem.Text);
            foreach (DataGridViewTextBoxColumn col in this.dgvDS.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaKH":
                        col.HeaderText = "Mã nhân viên";
                        break;
                    case "HoTen":
                        col.HeaderText = "Họ tên";
                        break;
                    case "GioiTinh":
                        col.HeaderText = "Giới tính";
                        break;
                    case "SDT":
                        col.HeaderText = "Số Điện Thoại";
                        break;
                    case "DiemTichLuy":
                        col.HeaderText = "Điểm tích luỹ";
                        break;
                }
            }
        }

        private void picFind_Click_1(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void dgvDS_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDS.CurrentRow != null)
            {
                lblID.Text = dgvDS.CurrentRow.Cells[0].Value.ToString();
                lblName.Text = dgvDS.CurrentRow.Cells[1].Value.ToString();
                lblSex.Text = dgvDS.CurrentRow.Cells[2].Value.ToString();
                lblSDT.Text = dgvDS.CurrentRow.Cells[3].Value.ToString();
                lblDiemTichLuy.Text = dgvDS.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }
    }
}
