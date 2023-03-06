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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNhapPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapPhieuNhap(string maNV)
        {
            InitializeComponent();
            lblIdNV.Text = maNV;
            dateNgNhap.DateTime = DateTime.Today;
            cbxTrKhau.Text="0%";
            BUS.BUS bus = new BUS.BUS();
            if (bus.getDataTable("PHIEUNHAP") == null)
            {
                txtIDPN.Text = "PN0001";
                return;
            }
            try
            {
                string str = bus.getThongTinPN(0, bus.getDataTable("PHIEUNHAP").Rows.Count - 1);
                /*Lấy mã phiếu cuối cùng trong danh sách*/
                str = str.Remove(0, 2);
                /*Nôm na là xóa 'PN' để đếm số cho dễ*/
                int temp = str.Length;
                str = (Convert.ToInt32(str) + 1).ToString();
                while (str.Length < temp)
                {
                    str = "0" + str;
                }
                string mapn = "PN";
                mapn += str;
                txtIDPN.Text = mapn;
            }
            catch (Exception ex) { }
        }
        /*Tránh thay đổi ngoài dự đoán*/
        public void KiemTra_maNCC()
        {
            if (dgvCT.Rows.Count > 0)
            {
                txtIDNCC.Enabled = false;
                btnBoxNCC.Enabled = false;
            }
            else
            {
                txtIDNCC.Enabled = true;
                btnBoxNCC.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            if (bus.timkiem_NhaCungCap(txtIDNCC.Text).Rows.Count != 1)
            {
                usctrlNoti noti = new usctrlNoti("Error", "Vui lòng chọn mã Nhà Cung Cấp có trong cơ sở dữ liệu");
                noti.Width = this.Width;
                this.Controls.Add(noti);
                noti.Show();
                noti.ShowNoti();
                return;
            }
            frmNhapPhieuNhap_ChonSP frm = new frmNhapPhieuNhap_ChonSP(txtIDNCC.Text);
            frm.ShowDialog();
            DTO_SanPham[] sp = bus.search_SANPHAM(frm.MaSP);
            if (frm.DialogResult == DialogResult.OK)
            {
                this.dgvCT.Rows.Add(frm.MaSP, sp[0].TenSP, frm.SoLuong, frm.GiaTien);
            }
            KiemTra_maNCC();
        }

        private void btnXoaThem_Click(object sender, EventArgs e)
        {
            if (dgvCT.Rows.Count == 0)
            {
                MessageBox.Show("Không có chi tiết nào để xoá!");
                return;
            }
            DialogResult kq = MessageBox.Show("Bạn có chắc xóa sản phẩm đang chọn ra khỏi phiếu nhập", "Hỏi",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No) 
                return;
            DataGridViewRow currow = dgvCT.SelectedCells[0].OwningRow;
            dgvCT.Rows.Remove(currow);
            /*Vì Xóa hết ròi nên có thể chọn lại NCC*/
            if (dgvCT.Rows.Count == 0)
            {
                txtIDNCC.Enabled = true;
                btnBoxNCC.Enabled = true;
            }
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            frmThemSanPham sp = new frmThemSanPham();
            sp.ShowDialog();
            if (sp.DialogResult == DialogResult.OK)
            {
                usctrlNoti noti1 = new usctrlNoti("Success", "Thêm hàng hoá mới thành công!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
        }

        private void btnBoxNCC_Click(object sender, EventArgs e)
        {
            frmNhapPhieuNhap_NCC frm = new frmNhapPhieuNhap_NCC();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
                txtIDNCC.Text = frm.maNCC;
        }

        private void btnAddPN_Click(object sender, EventArgs e)
        {
            BUS.BUS bus= new BUS.BUS();
            if (dgvCT.Rows.Count == 0)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Chưa có dữ liệu nhập hàng ?!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
            }
            DTO_PhieuNhap pn = new DTO_PhieuNhap(txtIDPN.Text, DateChange.ToString(dateNgNhap.DateTime),txtIDNCC.Text,lblIdNV.Text , "0", "0",cbxTrKhau.Text,"0", richtxtNote.Text);
            string error = CheckNhapVao.check_Nhap(pn);
            if (error != "")
            {
                usctrlNoti noti1 = new usctrlNoti("Error", error);
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            if (bus.themData(pn) == false)
            {
                usctrlNoti noti1 = new usctrlNoti("Error", "Thao tác 'Không' thành công!");
                noti1.Width = this.Width;
                this.Controls.Add(noti1);
                noti1.Show();
                noti1.ShowNoti();
                return;
            }
            int sl = 0;
            int thanhttien = 0;
            int tongtien = 0;
            foreach (DataGridViewRow row in dgvCT.Rows)
            {
                DTO_CT_PhieuNhap ctpn = new DTO_CT_PhieuNhap(pn.MaPN, row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
                sl += int.Parse(row.Cells[2].Value.ToString());
                thanhttien += int.Parse(row.Cells[3].Value.ToString());
                DTO_SanPham[] sp = bus.search_SANPHAM(row.Cells[0].Value.ToString());
                sp[0].SoLuongKho = (int.Parse(sp[0].SoLuongKho) + int.Parse(row.Cells[2].Value.ToString())).ToString();
                bus.suaData(sp[0]);
                bus.themData(ctpn);
            }
            pn.TongSL = sl.ToString();
            pn.TongThanhTien = thanhttien.ToString();
            if (cbxTrKhau.Text == "5%")
            {
                tongtien = thanhttien - (thanhttien * 5 /100);
            }
            else if (cbxTrKhau.Text == "10%")
            {
                tongtien = thanhttien - (thanhttien * 1 / 10);
            }
            else if (cbxTrKhau.Text == "15%")
            {
                tongtien = thanhttien - (thanhttien * 15 / 100);
            }
            else if (cbxTrKhau.Text == "20%")
            {
                tongtien = thanhttien - (thanhttien * 2 / 10);
            }
            else
            {
                tongtien = thanhttien;
            }
            pn.TongTienNhap = tongtien.ToString();
            bus.suaData(pn);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn làm mới phiếu nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No) 
                return;
            dateNgNhap.DateTime = DateTime.Today;
            BUS.BUS bus= new BUS.BUS();
            if (bus.getDataTable("PHIEUNHAP") == null)
            {
                txtIDPN.Text = "PN0001";
                return;
            }
            try
            {
                string str = bus.getThongTinPN(0, bus.getDataTable("PHIEUNHAP").Rows.Count - 1);
                str = str.Remove(0, 2);
                int temp = str.Length;
                str = (Convert.ToInt32(str) + 1).ToString();
                while (str.Length < temp)
                {
                    str = "0" + str;
                }
                string mapn = "PN";
                mapn += str;
                txtIDPN.Text = mapn;
            }
            catch (Exception ex) 
            { 

            }
            txtIDNCC.Text = "";
            richtxtNote.Text = "";
            cbxTrKhau.Text = "0%";
            dgvCT.Rows.Clear();
            txtIDNCC.Enabled = true;
            btnBoxNCC.Enabled = true;
        }
    }

        
}