using DevExpress.CodeParser;
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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class usctrlHoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        public usctrlHoaDon()
        {
            InitializeComponent();
            dateNgLap.DateTime =DateTime.Today ;
        }
        void Init(string mahd, string makh, string manv, string nglap)
        {
            BUS.BUS bus = new BUS.BUS();
            DataTable list = bus.searchHoaDon(mahd, makh, manv, nglap);
            dgvHD.DataSource = list;
            foreach (DataGridViewTextBoxColumn col in this.dgvHD.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaHD":
                        col.HeaderText = "Mã hoá đơn";
                        break;
                    case "NgLap":
                        col.HeaderText = "Ngày tạo hoá đơn";
                        
                        break;
                    case "MaKH":
                        col.HeaderText = "Mã khách hàng";
                        break;
                    case "MaNV":
                        col.HeaderText = "Mã nhân viên";
                        break;
                    case "TongSL":
                        col.HeaderText = "Tổng số lượng";
                        break;
                    case "TongThanhTien":
                        col.HeaderText = "Tổng thành tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "TienGiamGia":
                        col.HeaderText = "Tiền giảm giá";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "TongTien":
                        col.HeaderText = "Tổng tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                }
            }
        }

        private void usctrlHoaDon_Load(object sender, EventArgs e)
        {
            Init("", "", "", "");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dateNgLap.Text == "")
            {
                Init(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, "");
                return;
            }
            Init(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, DateChange.ToString(dateNgLap.DateTime));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            txtMaNV.Text = "";
            dateNgLap.Text = "";
            Init(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, dateNgLap.Text);
        }

        private void picBoxKH_Click(object sender, EventArgs e)
        {
            frmThuNganKH frmdskh = new frmThuNganKH();
            frmdskh.ShowDialog();
            txtMaKH.Text = frmdskh.MaKH;
        }

        private void picBoxNV_Click(object sender, EventArgs e)
        {
            frmDanhsachNV frmdsnv = new frmDanhsachNV();
            frmdsnv.ShowDialog();
            txtMaNV.Text = frmdsnv.MaNV;
        }

        private void dateNgLap_Click(object sender, EventArgs e)
        {

        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            DataGridViewRow currow = dgvHD.SelectedCells[0].OwningRow;
            frmChitiethoadon ct = new frmChitiethoadon(currow.Cells[0].Value.ToString());
            ct.ShowDialog();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //định dạng đuôi file Excel
            saveFileDialog.Title = "ExportExcel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportFile(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công" + ex.Message);
                }
            }
        }
        private void ExportFile(string path)
        {
            //khởi tạo Excel
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            //khởi tạo cột
            for (int i = 0; i < dgvHD.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvHD.Columns[i].HeaderText;

            }
            //khởi tạo hàng
            for (int i = 0; i < dgvHD.Rows.Count; i++)
            {
                for (int j = 0; j < dgvHD.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvHD.Rows[i].Cells[j].Value;
                }
            }
            //lưu file
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
    }
}
