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
    public partial class frmThuNganKH : DevExpress.XtraEditors.XtraForm
    {
        public string MaKH,DiemTichLuy;
        public frmThuNganKH()
        {
            InitializeComponent();
            Show_DSKH();
        }
        public void Show_DSKH()
        {
            dgvKH.DataSource = new BUS.BUS().timKiem_KhachHang(txtTimKiem.Text);
            foreach (DataGridViewTextBoxColumn col in this.dgvKH.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaKH":
                        col.HeaderText = "Mã khách hàng";
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvKH.DataSource = new BUS.BUS().timKiem_KhachHang(txtTimKiem.Text);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataGridViewRow currow = dgvKH.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DTO_KhachHang[] KH = bus.search_KhachHang(currow.Cells[0].Value.ToString());
            MaKH = KH[0].MaKH;
            DiemTichLuy = KH[0].DiemTichLuy;
            Close();
        }
    }
}