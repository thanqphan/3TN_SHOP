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
using Excel = Microsoft.Office.Interop.Excel;
namespace GUI
{
    public partial class usctrlPhieuNhap : DevExpress.XtraEditors.XtraUserControl
    {
        string maPN;
        public usctrlPhieuNhap()
        {
            InitializeComponent();
            dateHD.DateTime = DateTime.Today;
            radngay.Checked = true;
        }

        private void radngay_CheckedChanged(object sender, EventArgs e)
        {
            usctrlPhieuNhap_Load(dateHD.DateTime, 0);
        }

        private void radthang_CheckedChanged(object sender, EventArgs e)
        {
            usctrlPhieuNhap_Load(dateHD.DateTime, 1);
        }

        private void radnam_CheckedChanged(object sender, EventArgs e)
        {
            usctrlPhieuNhap_Load(dateHD.DateTime, 2);
        }


        private void usctrlPhieuNhap_Load(DateTime dateHD, int type)
        {
            BUS.BUS bus = new BUS.BUS();
            DataTable list = bus.timkiemTheoNgay_PhieuNhap(dateHD, type);
            dgvPNTK.DataSource = list;
            lblSoPN.Text = list.Rows.Count.ToString();
            //Init_Today_Panel();
            foreach (DataGridViewTextBoxColumn col in this.dgvPNTK.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaPN":
                        col.HeaderText = "Mã Phiếu Nhập";
                        break;
                    case "NgLap":
                        col.HeaderText = "Ngày Nhập";
                        col.DefaultCellStyle.Format = "yyyy/MM/dd";
                        break;
                    case "MaNCC":
                        col.HeaderText = "Mã Nhà Cung Cấp";
                        break;
                    case "MaNV":
                        col.HeaderText = "Mã Nhân Viên";
                        break;
                    case "TongSL":
                        col.HeaderText = "Số Lượng Nhập";
                        break;
                    case "TongThanhTien":
                        col.HeaderText = "Thành Tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "GiaTrietKhau":
                        col.HeaderText = "Triết Khấu";
                        break;
                    case "TongTienNhap":
                        col.HeaderText = "Tổng Tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "Note":
                        col.HeaderText = "Ghi Chú";
                        break;
                }
            }
        }
        private void ExportFile(string path)
        {
            //khởi tạo Excel
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            //khởi tạo cột
            for (int i = 0; i < dgvPNTK.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvPNTK.Columns[i].HeaderText;

            }
            //khởi tạo hàng
            for (int i = 0; i < dgvPNTK.Rows.Count; i++)
            {
                for (int j = 0; j < dgvPNTK.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvPNTK.Rows[i].Cells[j].Value;
                }
            }
            //lưu file
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
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
    }
}
