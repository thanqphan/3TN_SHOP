using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class usctrlDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        public usctrlDoanhThu()
        {
            InitializeComponent();
            Init_Today_Panel();
            Init_ComboBoxThoiGian();
        }
        void Init_ComboBoxThoiGian()
        {
            string[] time = { "Hôm nay", "Hôm qua", "Tháng này", "Tháng trước", "Tất cả hoá đơn trong năm nay" };
            cbbThoigian.Items.AddRange(time);
        }
        void Init(string mahd, string makh, string manv, string nglap)
        {
            BUS.BUS bus = new BUS.BUS();
            DataTable list = bus.searchHoaDon(mahd, makh, manv, nglap);
            list.Columns.Remove(list.Columns[3]);
            dgvHDTK.DataSource = list;
            foreach (DataGridViewTextBoxColumn col in this.dgvHDTK.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaHD":
                        col.HeaderText = "Mã hoá đơn";
                        break;
                    case "MaNV":
                        col.HeaderText = "Mã nhân viên";
                        break;
                    case "MaKH":
                        col.HeaderText = "Mã khách hàng";
                        break;
                    case "NgLap":
                        col.HeaderText = "Ngày tạo hoá đơn";
                        break;
                    case "TienGiamGia":
                        col.HeaderText = "Giảm giá";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "TongThanhTien":
                        col.HeaderText = "Tổng tiền hàng";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "TongTien":
                        col.HeaderText = "Thành tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                }
            }
        }
        void Initthang(string th, string nm)
        {
            BUS.BUS bus = new BUS.BUS();
            DataTable list = bus.searchHoaDonTheoThang(th, nm);
            list.Columns.Remove(list.Columns[3]);
            dgvHDTK.DataSource = list;
            foreach (DataGridViewTextBoxColumn col in this.dgvHDTK.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaHD":
                        col.HeaderText = "Mã hoá đơn";
                        break;
                    case "MaNV":
                        col.HeaderText = "Mã nhân viên";
                        break;
                    case "MaKH":
                        col.HeaderText = "Mã khách hàng";
                        break;
                    case "NgLap":
                        col.HeaderText = "Ngày tạo hoá đơn";
                        break;
                    case "TienGiamGia":
                        col.HeaderText = "Giảm giá";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "TongThanhTien":
                        col.HeaderText = "Tổng tiền hàng";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "TongTien":
                        col.HeaderText = "Thành tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                }
            }
        }
        void Initnam(string nm)
        {
            BUS.BUS bus = new BUS.BUS();
            DataTable list = bus.searchHoaDonTheoNam(nm);
            list.Columns.Remove(list.Columns[3]);
            dgvHDTK.DataSource = list;
            foreach (DataGridViewTextBoxColumn col in this.dgvHDTK.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaHD":
                        col.HeaderText = "Mã hoá đơn";
                        break;
                    case "MaNV":
                        col.HeaderText = "Mã nhân viên";
                        break;
                    case "MaKH":
                        col.HeaderText = "Mã khách hàng";
                        break;
                    case "NgLap":
                        col.HeaderText = "Ngày tạo hoá đơn";
                        break;
                    case "TienGiamGia":
                        col.HeaderText = "Giảm giá";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "TongThanhTien":
                        col.HeaderText = "Tổng tiền hàng";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                    case "TongTien":
                        col.HeaderText = "Thành tiền";
                        col.DefaultCellStyle.Format = "#,##0";
                        break;
                }
            }
        }
        private void cbbThoigian_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            switch (cbbThoigian.SelectedIndex)
            {
                case 0:
                    lblDoanhthutext.Text = "DOANH THU THUẦN HÔM NAY";
                    lblDoanhThu.Text = bus.doanhThuTheoNgay(DateChange.ToString(DateTime.Today)) + " VND";
                    lblSoHD.Text = bus.soLuongTheoNgay(DateChange.ToString(DateTime.Today));
                    Init("", "", "", DateChange.ToString(DateTime.Today));
                    break;
                case 1:
                    lblDoanhthutext.Text = "DOANH THU THUẦN HÔM QUA";
                    lblDoanhThu.Text = bus.doanhThuTheoNgay(DateChange.ToString(DateTime.Today.AddDays(-1))) + " VND";
                    lblSoHD.Text = bus.soLuongTheoNgay(DateChange.ToString(DateTime.Today.AddDays(-1)));
                    Init("", "", "", DateChange.ToString(DateTime.Today.AddDays(-1)));
                    break;
                case 2:
                    int dec = 12;
                    lblDoanhthutext.Text = "DOANH THU THUẦN THÁNG NÀY";
                    lblDoanhThu.Text = bus.doanhThuTheoThang(DateTime.Today.Month.ToString(), DateTime.Today.Year.ToString()) + " VND";
                    lblSoHD.Text = bus.soLuongTheoThang(DateTime.Today.Month.ToString(), DateTime.Today.Year.ToString());
                    Initthang(DateTime.Today.Month.ToString(), DateTime.Today.Year.ToString());
                    break;
                case 3:
                    lblDoanhthutext.Text = "DOANH THU THUẦN THÁNG TRƯỚC";
                    lblDoanhThu.Text = bus.doanhThuTheoThang(DateTime.Today.AddMonths(-1).Month.ToString(), DateTime.Today.Year.ToString()) + " VND";
                    lblSoHD.Text = bus.soLuongTheoThang(DateTime.Today.AddMonths(-1).Month.ToString(), DateTime.Today.Year.ToString());
                    Initthang(DateTime.Today.AddMonths(-1).Month.ToString(), DateTime.Today.Year.ToString());
                    break;
                case 4:
                    lblDoanhthutext.Text = "TỔNG DOANH THU NĂM NAY";
                    lblDoanhThu.Text = bus.doanhThuTheoNam(DateTime.Today.Year.ToString()) + " VND";
                    lblSoHD.Text = bus.soLuongTheoNam(DateTime.Today.Year.ToString());
                    Initnam(DateTime.Today.Year.ToString());
                    break;
            }
        }
        private void Init_Today_Panel()
        {
            BUS.BUS bus = new BUS.BUS();
            DateTime dt = DateTime.Today;
            lblDoanhThu.Text = bus.doanhThuTheoNgay(DateChange.ToString(dt)) + " VND";
            lblSoHD.Text = bus.soLuongTheoNgay(DateChange.ToString(dt));
        }

        private void usctrlDoanhThu_Load_1(object sender, EventArgs e)
        {
            Init_Today_Panel();
            cbbThoigian.SelectedIndex = 1;
            cbbThoigian.SelectedIndex = 0;
            BUS.BUS bus = new BUS.BUS();
        }
        private void ExportFile2(string path)
        {
            //khởi tạo Excel
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            //khởi tạo cột
            for (int i = 0; i < dgvHDTK.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvHDTK.Columns[i].HeaderText;

            }
            //khởi tạo hàng
            for (int i = 0; i < dgvHDTK.Rows.Count; i++)
            {
                for (int j = 0; j < dgvHDTK.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvHDTK.Rows[i].Cells[j].Value;
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
                    ExportFile2(saveFileDialog.FileName);
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
