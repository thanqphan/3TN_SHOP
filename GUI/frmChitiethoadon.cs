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
    public partial class frmChitiethoadon : DevExpress.XtraEditors.XtraForm
    {
        string maHD;
        public frmChitiethoadon()
        {
            InitializeComponent();
        }
        public frmChitiethoadon(string MaHD)
        {
            InitializeComponent();
            this.maHD = MaHD;
        }

        private void frmChitiethoadon_Load(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            DataTable temp = bus.InHoaDon(maHD);
            if (temp.Rows.Count == 0)
            {
                MessageBox.Show("Lỗi! Hoá đơn này không chứa bất kì sản phẩm nào!");
                lblKH.Text = "";
                lblNV.Text = "";
                return;
            }
            lblKH.Text = temp.Rows[0].ItemArray[4].ToString();
            lblNV.Text = temp.Rows[0].ItemArray[5].ToString();
            lblChitiethoadon.Text = maHD;
            dgvChitiethoadon.DataSource = temp;
            foreach (DataGridViewTextBoxColumn col in this.dgvChitiethoadon.Columns)
            {
                switch (col.HeaderText)
                {
                    case "TenSP":
                        col.HeaderText = "Tên sản phẩm";
                        break;
                    case "SOLUONG":
                        col.HeaderText = "Số lượng";
                        break;
                    case "GIATIEN":
                        col.HeaderText = "Giá tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "TONGTIENHANG":
                        col.HeaderText = "Tổng tiền hàng";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "TENKH":
                        col.HeaderText = "Khách hàng";
                        break;
                    case "TENNV":
                        col.HeaderText = "Nhân viên";
                        break;
                }
            }
        }
    }
}