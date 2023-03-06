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
using BUS;
using DTO;

namespace GUI
{
    public partial class usctrlNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        public usctrlNhaCungCap()
        {
            InitializeComponent();
        }
        private DTO_NhaCungCap[] list_NCC;
        public void Display_ThTin(DTO_NhaCungCap ncc)
        {
            lblID.Text = ncc.MaNCC;
            lblName.Text = ncc.TenNCC;
            lblSDT.Text = ncc.SDT; 
            lblDiaChi.Text = ncc.DiaChi;
            lblTrangThai.Text = ncc.TrangThai;
        }
        public void Display_dgvNCC()
        {
            BUS.BUS bus = new BUS.BUS();
            dgvDS.DataSource = bus.getDataTable("NHACUNGCAP");
            foreach(DataGridViewTextBoxColumn col in this.dgvDS.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaNCC":
                        col.HeaderText = "Mã Nhà Cung Cấp";
                        break;
                    case "TenNCC":
                        col.HeaderText = "Tên Nhà Cung Cấp";
                        break;
                    case "DiaChi":
                        col.HeaderText = "Địa Chỉ";
                        break;
                    case "SDT":
                        col.HeaderText = "Hotline";
                        break;
                    case "TrangThai":
                        col.HeaderText = "Trạng Thái Hợp tác";
                        break;
                }
            }
        }

        private void usctrlNhaCungCap_Load(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            string st = bus.getThongTinNCC(0, 0);
            list_NCC= bus.search_NhaCungCap(st);
            Display_ThTin(list_NCC[0]);
            Display_dgvNCC();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCapnhatnhacungcap frm = new frmCapnhatnhacungcap(lblID.Text);
            frm.ShowDialog();
            Display_dgvNCC();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc xóa nhà cung cấp " + lblName.Text + " ra khỏi cửa hàng", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No) 
                return;
            BUS.BUS bus = new BUS.BUS();
            if (bus.xoaNhaCungCap(lblID.Text) == false)
                MessageBox.Show("Việc xóa xảy ra một số vấn đề! Không thành công");
            else 
                MessageBox.Show("Đã xóa nhà cung cấp " + lblName.Text + " ra khỏi cửa hàng");
            Display_dgvNCC();
        }

        private void btnDSSP_Click(object sender, EventArgs e)
        {
            frmDanhsachSPcuaNCC frm = new frmDanhsachSPcuaNCC(lblID.Text);
            frm.ShowDialog();
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string iD;
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvDS.Rows[e.RowIndex];
                iD = row.Cells[0].Value.ToString();
                //Đưa dữ liệu vào textbox
                BUS.BUS bus = new BUS.BUS();
                list_NCC = bus.search_NhaCungCap(iD);
                Display_ThTin(list_NCC[0]);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmNhapNCC frm = new frmNhapNCC();
            frm.ShowDialog();
            Display_dgvNCC();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDS.DataSource = new BUS.BUS().timkiem_NhaCungCap(txtTimKiem.Text);
            foreach (DataGridViewTextBoxColumn col in this.dgvDS.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaNCC":
                        col.HeaderText = "Mã Nhà Cung Cấp";
                        break;
                    case "TenNCC":
                        col.HeaderText = "Tên Nhà Cung Cấp";
                        break;
                    case "DiaChi":
                        col.HeaderText = "Địa Chỉ";
                        break;
                    case "SDT":
                        col.HeaderText = "Hotline";
                        break;
                    case "TrangThai":
                        col.HeaderText = "Trạng Thái Hợp tác";
                        break;
                }
            }
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }
    }
}
