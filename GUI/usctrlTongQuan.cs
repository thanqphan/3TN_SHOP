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
    public partial class usctrlTongQuan : DevExpress.XtraEditors.XtraUserControl
    {
        public usctrlTongQuan()
        {
            InitializeComponent();
            dateHD.DateTime = DateTime.Today;
        }
        private void Init_Today_Panel()
        {
            BUS.BUS bus = new BUS.BUS();
            lblDoanhthu.Text = bus.doanhThuTheoNgay(DateChange.ToString(dateHD.DateTime)) + " VND";
            lblHD.Text = bus.soLuongTheoNgay(DateChange.ToString(dateHD.DateTime));
        }
        private void Init_Chart()
        {
            chartControl1.DataSource = new BUS.BUS().top5_maSP_BanChayTheoDoanhThu(DateChange.ToString(dateHD.DateTime));
        }
        private void usctrlTongQuan_Load(object sender, EventArgs e)
        {
            Init_Today_Panel();
            Init_Chart();
        }

        private void dateHD_EditValueChanged(object sender, EventArgs e)
        {
            Init_Today_Panel();
            Init_Chart();
        }
    }
}
