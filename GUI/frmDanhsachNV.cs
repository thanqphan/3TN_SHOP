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
using DTO;
namespace GUI
{
    public partial class frmDanhsachNV : DevExpress.XtraEditors.XtraForm
    {
        public string MaNV;
        public frmDanhsachNV()
        {
            InitializeComponent();
        }
        private void frmDanhsachNV_Load(object sender, EventArgs e)
        {
            BUS.BUS bus = new BUS.BUS();
            dgvDanhsachNV.DataSource = bus.getDataTable("NHANVIEN");
            foreach (DataGridViewTextBoxColumn col in this.dgvDanhsachNV.Columns)
            {
                switch (col.HeaderText)
                {
                    case "MaNCC":
                        col.HeaderText = "Mã Nhân Viên";
                        break;
                    case "HoTen":
                        col.HeaderText = "Tên Nhân Viên";
                        break;
                    case "DiaChi":
                        col.HeaderText = "Địa Chỉ";
                        break;
                    case "SDT":
                        col.HeaderText = "Hotline";
                        break;
                    case "GT":
                        col.HeaderText = "Giới Tính";
                        break;
                    case "NgSinh":
                        col.HeaderText = "Ngày Sinh";
                        break;
                    case "ChucVu":
                        col.HeaderText = "Chức Vụ";
                        break;
                }
            }
        }

        private void dgvDanhsachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currow = dgvDanhsachNV.SelectedCells[0].OwningRow;
            BUS.BUS bus = new BUS.BUS();
            DTO_NhanVien[] KH = bus.search_NhanVien(currow.Cells[0].Value.ToString());
            MaNV = KH[0].MaNV;
            
            Close();
        }
    }
}