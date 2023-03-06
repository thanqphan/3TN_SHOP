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
    public partial class frmInHoaDon : Form
    {
        string maHD;
        public frmInHoaDon()
        {
            InitializeComponent();
        }
        public frmInHoaDon(string MaHD, int tienKhachDua)
        {
            InitializeComponent();
            this.maHD = MaHD;
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ParamTienKhachDua", tienKhachDua.ToString()));
        }
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RptHoaDon.SP_GetRptHoaDon' table. You can move, or remove it, as needed.
            //this.SP_GetRptHoaDonTableAdapter.Fill(this.RptHoaDon.SP_GetRptHoaDon, maHD);
            this.reportViewer1.LocalReport.DataSources[0].Value = SP_GetRptHoaDonTableAdapter.GetData(maHD);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
