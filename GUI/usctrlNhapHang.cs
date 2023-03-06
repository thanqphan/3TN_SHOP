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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class usctrlNhapHang : DevExpress.XtraEditors.XtraUserControl
    {
        
        public usctrlNhapHang(string username)
        {
            InitializeComponent();
            BUS.BUS bus = new BUS.BUS();
            DTO_NhanVien[] nv = bus.search_NhanVien_theoTenTK(username);
            txtIDNV.Text = nv[0].MaNV;
        }
        private void Display_dgvPN()
        {
            BUS.BUS bus = new BUS.BUS();
            dgvPN.DataSource = bus.timkiemnhanh_PhieuNhap(txtIDPN.Text,txtIDNCC.Text);
            foreach(DataGridViewTextBoxColumn col in this.dgvPN.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaPN":
                        col.HeaderText = "Mã Phiếu Nhập";
                        break;
                    case "NgLap":
                        col.HeaderText = "Ngày Nhập";
                        break;
                    case "MaNCC":
                        col.HeaderText = "Mã Nhà Cung Cấp";
                        break;
                    case "MaNV":
                        col.HeaderText = "Mã Nhân Viên";
                        break;
                    case "TongSL":
                        col.HeaderText = "Số Lượng Nhập";
                        break;
                    case "TongThanhTien":
                        col.HeaderText = "Thành Tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "GiaTrietKhau":
                        col.HeaderText = "Triết Khấu";
                        break;
                    case "TongTienNhap":
                        col.HeaderText = "Tổng Tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "Note":
                        col.HeaderText = "Ghi Chú";
                        break;
                }
            }
        }
        private void Display_dgvPN_TimKiem(string pn, string ncc, string nv)
        {
            BUS.BUS bus = new BUS.BUS();
            dgvPN.DataSource = bus.timKiem_PhieuNhap_Ma(pn, ncc, nv);
            foreach (DataGridViewTextBoxColumn col in this.dgvPN.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaPN":
                        col.HeaderText = "Mã Phiếu Nhập";
                        break;
                    case "NgLap":
                        col.HeaderText = "Ngày Nhập";
                        break;
                    case "MaNCC":
                        col.HeaderText = "Mã Nhà Cung Cấp";
                        break;
                    case "MaNV":
                        col.HeaderText = "Mã Nhân Viên";
                        break;
                    case "TongSL":
                        col.HeaderText = "Số Lượng Nhập";
                        break;
                    case "TongThanhTien":
                        col.HeaderText = "Thành Tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "GiaTrietKhau":
                        col.HeaderText = "Triết Khấu";
                        break;
                    case "TongTienNhap":
                        col.HeaderText = "Tổng Tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "Note":
                        col.HeaderText = "Ghi Chú";
                        break;
                }
            }
        }
        private void usctrlNhapHang_Load(object sender, EventArgs e)
        {
            Display_dgvPN();
        }
        public void NhapPhieuNhap()
        {
            frmNhapPhieuNhap frm = new frmNhapPhieuNhap(txtIDNV.Text);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                usctrlNoti noti1 = new usctrlNoti("Success", "Thêm phiếu nhập mới thành công!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            Display_dgvPN();
        }
        private void picBoxNCC_Click(object sender, EventArgs e)
        {
            frmNhapPhieuNhap_NCC ncc = new frmNhapPhieuNhap_NCC();
            ncc.ShowDialog();
            if (ncc.DialogResult == DialogResult.OK)
                txtIDNCC.Text = ncc.maNCC;
        }
        private void picBoxNV_Click(object sender, EventArgs e)
        {
            frmNhapPhieuNhap_NV nv = new frmNhapPhieuNhap_NV();
            nv.ShowDialog();
            if (nv.DialogResult == DialogResult.OK)
                txtIDNV.Text = nv.maNV;
        }
        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {
            frmReportPhieuNhap pn = new frmReportPhieuNhap();
            pn.ShowDialog();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            NhapPhieuNhap();
        }

        private void btnXoaNhap_Click(object sender, EventArgs e)
        {
            DataGridViewRow currow = dgvPN.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DialogResult res = MessageBox.Show("Bạn có chắc xóa phiếu nhập " + currow.Cells[0].Value.ToString() + " không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) 
                return;
            foreach (DataRow row in bus.InPhieuNhap(currow.Cells[0].Value.ToString()).Rows)
            {
                bus.xoaCTPN(currow.Cells[0].Value.ToString(), row["MaSP"].ToString());
            }
            if (bus.xoaPhieuNhap(currow.Cells[0].Value.ToString()))
                MessageBox.Show("Bạn đã xóa Phiếu Nhập " + currow.Cells[0].Value.ToString() + " thành công");
            else 
                MessageBox.Show("Có vấn đề xảy ra! Không thành công");
            Display_dgvPN();
        }

        private void picFind_Click(object sender, EventArgs e)
        {
            Display_dgvPN_TimKiem(txtIDPN.Text, txtIDNCC.Text, txtIDNV.Text);
        }

        private void picReset_Click(object sender, EventArgs e)
        {
            txtIDNCC.Text = "";
            txtIDPN.Text = "";
            txtIDNV.Text = "";
            Display_dgvPN();
        }
    }
}
