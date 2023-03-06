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

namespace GUI
{
    public partial class usctrlTonKho : DevExpress.XtraEditors.XtraUserControl
    {
        public usctrlTonKho()
        {
            InitializeComponent();
        }
        void Init()
        {
            BUS.BUS bus = new BUS.BUS();
            DataTable list = bus.getDataTable("SANPHAM");
            dgvSP.DataSource = list;
            foreach (DataGridViewTextBoxColumn col in this.dgvSP.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaSP":
                        col.HeaderText = "Mã sản phẩm";
                        break;
                    case "TenSP":
                        col.HeaderText = "Tên sản phẩm";
                        break;
                    case "MauSP":
                        col.HeaderText = "Màu sản phẩm";
                        break;
                    case "SizeSP":
                        col.HeaderText = "Size";
                        break;
                    case "DonGia":
                        col.HeaderText = "Đơn giá";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "MaLoaiSP":
                        col.HeaderText = "Mã loại ";
                        break;
                    case "SoLuongKho":
                        col.HeaderText = "Số lượng";
                        break;
                    case "TrangThai":
                        col.HeaderText = "Trạng thái";
                        break;
                }
            }
        }

        private void usctrlTonKho_Load(object sender, EventArgs e)
        {
            Init();
            Init_Chart();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = new BUS.BUS().timkiemSanPhamTonKho(txtTimKiem.Text);
            foreach (DataGridViewTextBoxColumn col in this.dgvSP.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaSP":
                        col.HeaderText = "Mã sản phẩm";
                        break;
                    case "TenSP":
                        col.HeaderText = "Tên sản phẩm";
                        break;
                    case "MauSP":
                        col.HeaderText = "Màu sản phẩm";
                        break;
                    case "SizeSP":
                        col.HeaderText = "Size";
                        break;
                    case "DonGia":
                        col.HeaderText = "Đơn giá";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "MaLoaiSP":
                        col.HeaderText = "Mã loại ";
                        break;
                    case "SoLuongKho":
                        col.HeaderText = "Số lượng";
                        break;
                    case "TrangThai":
                        col.HeaderText = "Trạng thái";
                        break;
                }
            }
        }
        private void Init_Chart()
        {
            chartSP.DataSource = new BUS.BUS().TopTonKho();
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }
    }
}
