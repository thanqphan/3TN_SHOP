using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask.Design;
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
    public partial class frmThuNganSP : DevExpress.XtraEditors.XtraForm
    {
        public string MASP;
        public frmThuNganSP()
        {
            InitializeComponent();
            Reset();
        }
        void Reset()
        {
            dgvSP.DataSource = new BUS.BUS().timkiemSanPham(txtTimKiem.Text);
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
        private void frmThuNganSP_Load(object sender, EventArgs e)
        {

        }

        private void dgvSP_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow currow = dgvSP.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] SP = bus.search_SANPHAM(currow.Cells[0].Value.ToString());
            MASP = SP[0].MaSP;
            Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataGridViewRow currow = dgvSP.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] SP = bus.search_SANPHAM(currow.Cells[0].Value.ToString());
            MASP = SP[0].MaSP;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = new BUS.BUS().timkiemSanPham(txtTimKiem.Text);
        }
    }
}