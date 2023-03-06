using Microsoft.Reporting.WinForms;
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
    public partial class frmReportPhieuNhap : Form
    {
        public frmReportPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmReportPhieuNhap_Load(object sender, EventArgs e)
        {

            BUS.BUS bus = new BUS.BUS();
            try
            {
                //la61y d9uo72ng da64n file rp
                reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportPhieuNhap.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                //la61y dataset
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = bus.getDataTable("PHIEUNHAP");
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                var Ngay = new ReportParameter("Ngay", DateChange.ToString(DateTime.Today));
                // var TongCong = new ReportParameter("Tongcong", );

                this.reportViewer1.LocalReport.SetParameters(Ngay);
                // this.reportViewer1.LocalReport.SetParameters(TongCong);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
