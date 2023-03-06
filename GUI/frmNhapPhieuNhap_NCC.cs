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
    public partial class frmNhapPhieuNhap_NCC : DevExpress.XtraEditors.XtraForm
    {
        public string maNCC ;
        public void Display_dgvNCC()
        {
            dgvNCC.DataSource = new BUS.BUS().timkiem_NhaCungCap(txtTimKiem.Text);
            foreach (DataGridViewTextBoxColumn col in this.dgvNCC.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaNCC":
                        col.HeaderText = "Mã nhà cung cấp";
                        break;
                    case "TenNCC":
                        col.HeaderText = "Tên nhà cung cấp";
                        break;
                    case "DiaChi":
                        col.HeaderText = "Địa chỉ";
                        break;
                    case "SDT":
                        col.HeaderText = "Số điện thoại";
                        break;
                    case "TrangThai":
                        col.HeaderText = "Trạng thái";
                        break;
                }
            }
        }
        public frmNhapPhieuNhap_NCC()
        {
            InitializeComponent();
            Display_dgvNCC();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataGridViewRow currow = dgvNCC.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DTO_NhaCungCap[] NCC = bus.search_NhaCungCap(currow.Cells[0].Value.ToString());
            maNCC = NCC[0].MaNCC;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvNCC.DataSource = new BUS.BUS().timkiem_NhaCungCap(txtTimKiem.Text);
        }

        private void dgvNCC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow currow = dgvNCC.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DTO_NhaCungCap[] NCC = bus.search_NhaCungCap(currow.Cells[0].Value.ToString());
            maNCC = NCC[0].MaNCC;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}