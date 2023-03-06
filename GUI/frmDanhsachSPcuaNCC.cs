using DevExpress.XtraEditors;
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
    public partial class frmDanhsachSPcuaNCC : DevExpress.XtraEditors.XtraForm
    {
        string iD = "";
        public frmDanhsachSPcuaNCC(string maNCC)
        {
            InitializeComponent();
            iD= maNCC;
        }

        private void frmDanhsachSPcuaNCC_Load(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            dgvDSSPcuaNCC.DataSource = bus.list_SanPham_NCC(iD);
            foreach (DataGridViewTextBoxColumn col in this.dgvDSSPcuaNCC.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaSP":
                        col.HeaderText = "Mã sản phẩm";
                        break;
                    case "TenSP":
                        col.HeaderText = "Tên sản phẩm";
                        break;
                    case "SizeSP":
                        col.HeaderText = "Size Sản Phẩm";
                        break;
                    case "MauSP":
                        col.HeaderText = "Màu Sản Phẩm";
                        break;
                    case "MaNCC":
                        col.HeaderText = "Nhà cung cấp";
                        break;
                    case "DonGia":
                        col.HeaderText = "Đơn giá";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "SoLuongKho":
                        col.HeaderText = "Số lượng";
                        break;
                    case "TrangThai":
                        col.HeaderText = "Trạng thái";
                        break;
                    case "MaLoaiSP":
                        col.HeaderText = "Mã Loại ";
                        break;
                }
            }
        }
    }
}