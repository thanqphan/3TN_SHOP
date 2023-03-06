using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask.Design;
using DTO;
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
    public partial class frmNhapPhieuNhap_NhapSP : DevExpress.XtraEditors.XtraForm
    {
        public string soLuong = "", donGia = "";
        public frmNhapPhieuNhap_NhapSP(string maSP)
        {
            InitializeComponent();
            BUS.BUS bus = new BUS.BUS();
            DTO_SanPham[] sp = bus.search_SANPHAM(maSP);
            string ma = sp[0].MaSP;
            if (System.IO.File.Exists(Application.StartupPath + "/HinhSanPham/" + ma + ".jpg"))
                picPicSP.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + ma + ".jpg");
            else
                picPicSP.Image = Image.FromFile(Application.StartupPath + "/HinhSanPham/" + ma + ".png");
            lblNameSP.Text = sp[0].TenSP;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtSL.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng phải nhập bằng số!");
                txtSL.Text = "1";
                return;
            }
            if (int.Parse(txtSL.Text) <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                txtSL.Text = "1";
                return;
            }
            /*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\*/
            try
            {
                int.Parse(txtThanhTien.Text);
            }
            catch
            {
                MessageBox.Show("Tiền hàng phải nhập bằng số");
                txtThanhTien.Text = "1";
                return;
            }
            if (int.Parse(txtThanhTien.Text) <= 0|| int.Parse(txtThanhTien.Text)<1000)
            {
                MessageBox.Show("Số tiền không hợp lệ");
                txtThanhTien.Text = "1000";
                return;
            }
            soLuong = txtSL.Text;
            donGia = txtThanhTien.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}