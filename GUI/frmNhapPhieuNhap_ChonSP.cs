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

namespace GUI
{
    public partial class frmNhapPhieuNhap_ChonSP : DevExpress.XtraEditors.XtraForm
    {
        public string MaSP;
        public string MaNCC;
        public string SoLuong, GiaTien;
        
        public frmNhapPhieuNhap_ChonSP(string maNCC)
        {
            InitializeComponent();
            MaNCC = maNCC;
            Display_dgvSP();
        }
        public void Display_dgvSP()
        {
            dgvSP.DataSource = new BUS.BUS().search_sanpham_NCC(MaNCC);
            foreach (DataGridViewTextBoxColumn col in this.dgvSP.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaSP":
                        col.HeaderText = "Mã sản phẩm";
                        break;
                    case "TenSP":
                        col.HeaderText = "Tên sản phẩm";
                        break;
                    case "DonGia":
                        col.HeaderText = "Đơn giá";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataGridViewRow currow = dgvSP.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] SP = bus.search_SANPHAM(currow.Cells[0].Value.ToString());
            MaSP = SP[0].MaSP;
            frmNhapPhieuNhap_NhapSP nhapsp = new frmNhapPhieuNhap_NhapSP(MaSP);
            nhapsp.ShowDialog();
            SoLuong = nhapsp.soLuong;
            GiaTien = nhapsp.donGia;
            if (nhapsp.DialogResult == DialogResult.OK)
                this.DialogResult = DialogResult.OK;
            Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = new BUS.BUS().search_sanpham_ncc(txtTimKiem.Text, MaNCC);

        }

        private void dgvSP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow currow = dgvSP.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] SP = bus.search_SANPHAM(currow.Cells[0].Value.ToString());
            MaSP = SP[0].MaSP;
            frmNhapPhieuNhap_NhapSP nhapsp = new frmNhapPhieuNhap_NhapSP(MaSP);
            nhapsp.ShowDialog();
            SoLuong = nhapsp.soLuong;
            GiaTien = nhapsp.donGia;
            if (nhapsp.DialogResult == DialogResult.OK)
                this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}