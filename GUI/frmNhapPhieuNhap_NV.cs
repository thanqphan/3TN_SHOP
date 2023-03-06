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
    public partial class frmNhapPhieuNhap_NV : DevExpress.XtraEditors.XtraForm
    {
        public string maNV;
        public void Display_dgvNV()
        {
            dgvNV.DataSource = new BUS.BUS().timKiemNhanh_NhanVien(txtTimKiem.Text);
            foreach (DataGridViewTextBoxColumn col in this.dgvNV.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaNV":
                        col.HeaderText = "Mã Nhân Viên";
                        break;
                    case "HoTen":
                        col.HeaderText = "Tên Nhân Viên";
                        break;
                    case "ChucVu":
                        col.HeaderText = "Chức Vụ";
                        break;
                }
            }
        }
        public frmNhapPhieuNhap_NV()
        {
            InitializeComponent();
            Display_dgvNV();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataGridViewRow currow = dgvNV.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DTO_NhanVien[] nv = bus.search_NhanVien(currow.Cells[0].Value.ToString());
            maNV = nv[0].MaNV;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvNV.DataSource = new BUS.BUS().timKiemNhanh_NhanVien(txtTimKiem.Text);
        }

        private void dgvNV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow currow = dgvNV.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DTO_NhanVien[] nv = bus.search_NhanVien(currow.Cells[0].Value.ToString());
            maNV = nv[0].MaNV;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}