namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMain = new DevExpress.XtraEditors.SimpleButton();
            this.btnThuNgan = new DevExpress.XtraEditors.SimpleButton();
            this.btnKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuanLi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.btnHeThong = new DevExpress.XtraEditors.SimpleButton();
            this.pnlKhoHang = new System.Windows.Forms.Panel();
            this.btnSanPham = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhapHang = new DevExpress.XtraEditors.SimpleButton();
            this.pnlQuanLi = new System.Windows.Forms.Panel();
            this.btnKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnNCC = new DevExpress.XtraEditors.SimpleButton();
            this.btnNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.pnlHeThong = new System.Windows.Forms.Panel();
            this.pnlThuNgan = new System.Windows.Forms.Panel();
            this.btnBanHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.btnTKDT = new DevExpress.XtraEditors.SimpleButton();
            this.btnTKPN = new DevExpress.XtraEditors.SimpleButton();
            this.btnTKKho = new DevExpress.XtraEditors.SimpleButton();
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.btnNameUser = new DevExpress.XtraEditors.SimpleButton();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlKhoHang.SuspendLayout();
            this.pnlQuanLi.SuspendLayout();
            this.pnlHeThong.SuspendLayout();
            this.pnlThuNgan.SuspendLayout();
            this.pnlThongKe.SuspendLayout();
            this.pnlUserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picLogout);
            this.panel1.Controls.Add(this.btnNameUser);
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 74);
            this.panel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnMain);
            this.pnlMain.Controls.Add(this.btnThuNgan);
            this.pnlMain.Controls.Add(this.btnKho);
            this.pnlMain.Controls.Add(this.btnQuanLi);
            this.pnlMain.Controls.Add(this.btnThongKe);
            this.pnlMain.Controls.Add(this.btnHeThong);
            this.pnlMain.Location = new System.Drawing.Point(2, 84);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1290, 67);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_Click);
            this.pnlMain.Leave += new System.EventHandler(this.pnlMain_Leave);
            // 
            // btnMain
            // 
            this.btnMain.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Appearance.Options.UseFont = true;
            this.btnMain.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMain.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMain.ImageOptions.SvgImage")));
            this.btnMain.Location = new System.Drawing.Point(4, 4);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(148, 46);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "Trang chủ";
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnThuNgan
            // 
            this.btnThuNgan.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuNgan.Appearance.Options.UseFont = true;
            this.btnThuNgan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThuNgan.ImageOptions.SvgImage")));
            this.btnThuNgan.Location = new System.Drawing.Point(161, 5);
            this.btnThuNgan.Margin = new System.Windows.Forms.Padding(5);
            this.btnThuNgan.Name = "btnThuNgan";
            this.btnThuNgan.Size = new System.Drawing.Size(151, 45);
            this.btnThuNgan.TabIndex = 3;
            this.btnThuNgan.Text = "Thu Ngân";
            this.btnThuNgan.Click += new System.EventHandler(this.btnThuNgan_Click);
            // 
            // btnKho
            // 
            this.btnKho.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.Appearance.Options.UseFont = true;
            this.btnKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKho.ImageOptions.SvgImage")));
            this.btnKho.Location = new System.Drawing.Point(322, 5);
            this.btnKho.Margin = new System.Windows.Forms.Padding(5);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(151, 45);
            this.btnKho.TabIndex = 4;
            this.btnKho.Text = "Kho Hàng";
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnQuanLi
            // 
            this.btnQuanLi.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLi.Appearance.Options.UseFont = true;
            this.btnQuanLi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQuanLi.ImageOptions.SvgImage")));
            this.btnQuanLi.Location = new System.Drawing.Point(483, 5);
            this.btnQuanLi.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuanLi.Name = "btnQuanLi";
            this.btnQuanLi.Size = new System.Drawing.Size(151, 45);
            this.btnQuanLi.TabIndex = 5;
            this.btnQuanLi.Text = "Quản Lí";
            this.btnQuanLi.Click += new System.EventHandler(this.btnQuanLi_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Appearance.Options.UseFont = true;
            this.btnThongKe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKe.ImageOptions.SvgImage")));
            this.btnThongKe.Location = new System.Drawing.Point(644, 5);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(151, 45);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.Appearance.Options.UseFont = true;
            this.btnHeThong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHeThong.ImageOptions.SvgImage")));
            this.btnHeThong.Location = new System.Drawing.Point(806, 6);
            this.btnHeThong.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(150, 44);
            this.btnHeThong.TabIndex = 7;
            this.btnHeThong.Text = "Hệ Thống";
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // pnlKhoHang
            // 
            this.pnlKhoHang.Controls.Add(this.btnSanPham);
            this.pnlKhoHang.Controls.Add(this.btnNhapHang);
            this.pnlKhoHang.Location = new System.Drawing.Point(321, 5);
            this.pnlKhoHang.Name = "pnlKhoHang";
            this.pnlKhoHang.Size = new System.Drawing.Size(150, 122);
            this.pnlKhoHang.TabIndex = 2;
            // 
            // btnSanPham
            // 
            this.btnSanPham.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.Appearance.Options.UseFont = true;
            this.btnSanPham.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSanPham.ImageOptions.SvgImage")));
            this.btnSanPham.Location = new System.Drawing.Point(1, 55);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(8);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(150, 58);
            this.btnSanPham.TabIndex = 8;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.Appearance.Options.UseFont = true;
            this.btnNhapHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhapHang.ImageOptions.SvgImage")));
            this.btnNhapHang.Location = new System.Drawing.Point(1, 0);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(6);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(150, 53);
            this.btnNhapHang.TabIndex = 7;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // pnlQuanLi
            // 
            this.pnlQuanLi.Controls.Add(this.btnKhachHang);
            this.pnlQuanLi.Controls.Add(this.btnNCC);
            this.pnlQuanLi.Controls.Add(this.btnNV);
            this.pnlQuanLi.Location = new System.Drawing.Point(481, 0);
            this.pnlQuanLi.Name = "pnlQuanLi";
            this.pnlQuanLi.Size = new System.Drawing.Size(151, 182);
            this.pnlQuanLi.TabIndex = 3;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Appearance.Options.UseFont = true;
            this.btnKhachHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhachHang.ImageOptions.SvgImage")));
            this.btnKhachHang.Location = new System.Drawing.Point(-1, 121);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(8);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(152, 52);
            this.btnKhachHang.TabIndex = 8;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.Appearance.Options.UseFont = true;
            this.btnNCC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNCC.ImageOptions.SvgImage")));
            this.btnNCC.Location = new System.Drawing.Point(-1, 60);
            this.btnNCC.Margin = new System.Windows.Forms.Padding(8);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(152, 58);
            this.btnNCC.TabIndex = 7;
            this.btnNCC.Text = "Nhà Cung Cấp";
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnNV
            // 
            this.btnNV.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNV.Appearance.Options.UseFont = true;
            this.btnNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNV.ImageOptions.SvgImage")));
            this.btnNV.Location = new System.Drawing.Point(0, 5);
            this.btnNV.Margin = new System.Windows.Forms.Padding(6);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(151, 53);
            this.btnNV.TabIndex = 6;
            this.btnNV.Text = "Nhân Viên";
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Appearance.Options.UseFont = true;
            this.btnTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaiKhoan.Location = new System.Drawing.Point(1, 1);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(10);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(148, 52);
            this.btnTaiKhoan.TabIndex = 9;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // pnlHeThong
            // 
            this.pnlHeThong.Controls.Add(this.btnTaiKhoan);
            this.pnlHeThong.Location = new System.Drawing.Point(805, 5);
            this.pnlHeThong.Name = "pnlHeThong";
            this.pnlHeThong.Size = new System.Drawing.Size(149, 113);
            this.pnlHeThong.TabIndex = 4;
            // 
            // pnlThuNgan
            // 
            this.pnlThuNgan.Controls.Add(this.btnBanHang);
            this.pnlThuNgan.Controls.Add(this.btnHoaDon);
            this.pnlThuNgan.Location = new System.Drawing.Point(160, 4);
            this.pnlThuNgan.Name = "pnlThuNgan";
            this.pnlThuNgan.Size = new System.Drawing.Size(150, 122);
            this.pnlThuNgan.TabIndex = 5;
            // 
            // btnBanHang
            // 
            this.btnBanHang.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.Appearance.Options.UseFont = true;
            this.btnBanHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBanHang.ImageOptions.SvgImage")));
            this.btnBanHang.Location = new System.Drawing.Point(0, -4);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(12);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(150, 58);
            this.btnBanHang.TabIndex = 10;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.Appearance.Options.UseFont = true;
            this.btnHoaDon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoaDon.ImageOptions.SvgImage")));
            this.btnHoaDon.Location = new System.Drawing.Point(0, 56);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(10);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(151, 58);
            this.btnHoaDon.TabIndex = 9;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.Controls.Add(this.btnTKDT);
            this.pnlThongKe.Controls.Add(this.btnTKPN);
            this.pnlThongKe.Controls.Add(this.btnTKKho);
            this.pnlThongKe.Location = new System.Drawing.Point(643, 4);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(150, 178);
            this.pnlThongKe.TabIndex = 6;
            // 
            // btnTKDT
            // 
            this.btnTKDT.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKDT.Appearance.Options.UseFont = true;
            this.btnTKDT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTKDT.ImageOptions.SvgImage")));
            this.btnTKDT.Location = new System.Drawing.Point(0, 117);
            this.btnTKDT.Margin = new System.Windows.Forms.Padding(10);
            this.btnTKDT.Name = "btnTKDT";
            this.btnTKDT.Size = new System.Drawing.Size(149, 52);
            this.btnTKDT.TabIndex = 9;
            this.btnTKDT.Text = "Doanh Thu";
            this.btnTKDT.Click += new System.EventHandler(this.btnTKDT_Click);
            // 
            // btnTKPN
            // 
            this.btnTKPN.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKPN.Appearance.Options.UseFont = true;
            this.btnTKPN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTKPN.ImageOptions.SvgImage")));
            this.btnTKPN.Location = new System.Drawing.Point(0, 58);
            this.btnTKPN.Margin = new System.Windows.Forms.Padding(10);
            this.btnTKPN.Name = "btnTKPN";
            this.btnTKPN.Size = new System.Drawing.Size(149, 56);
            this.btnTKPN.TabIndex = 8;
            this.btnTKPN.Text = "Phiếu Nhập";
            this.btnTKPN.Click += new System.EventHandler(this.btnTKPN_Click);
            // 
            // btnTKKho
            // 
            this.btnTKKho.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKKho.Appearance.Options.UseFont = true;
            this.btnTKKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTKKho.ImageOptions.SvgImage")));
            this.btnTKKho.Location = new System.Drawing.Point(1, 2);
            this.btnTKKho.Margin = new System.Windows.Forms.Padding(8);
            this.btnTKKho.Name = "btnTKKho";
            this.btnTKKho.Size = new System.Drawing.Size(149, 52);
            this.btnTKKho.TabIndex = 7;
            this.btnTKKho.Text = "Tồn Kho";
            this.btnTKKho.Click += new System.EventHandler(this.btnTKKho_Click);
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.Controls.Add(this.pnlThongKe);
            this.pnlUserControl.Controls.Add(this.pnlThuNgan);
            this.pnlUserControl.Controls.Add(this.pnlHeThong);
            this.pnlUserControl.Controls.Add(this.pnlQuanLi);
            this.pnlUserControl.Controls.Add(this.pnlKhoHang);
            this.pnlUserControl.Location = new System.Drawing.Point(-1, 152);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(1293, 677);
            this.pnlUserControl.TabIndex = 7;
            // 
            // picLogout
            // 
            this.picLogout.Image = global::GUI.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(1151, 41);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(33, 33);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 4;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // btnNameUser
            // 
            this.btnNameUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNameUser.ImageOptions.Image")));
            this.btnNameUser.Location = new System.Drawing.Point(972, 39);
            this.btnNameUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnNameUser.Name = "btnNameUser";
            this.btnNameUser.Size = new System.Drawing.Size(172, 35);
            this.btnNameUser.TabIndex = 3;
            this.btnNameUser.Text = "text";
            // 
            // picExit
            // 
            this.picExit.Image = global::GUI.Properties.Resources.cancel;
            this.picExit.Location = new System.Drawing.Point(1233, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(60, 49);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 2;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.z3935355526855_3f23253eaed0cbc5b09d93f4524e1235;
            this.pictureBox1.Location = new System.Drawing.Point(13, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 831);
            this.Controls.Add(this.pnlUserControl);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlKhoHang.ResumeLayout(false);
            this.pnlQuanLi.ResumeLayout(false);
            this.pnlHeThong.ResumeLayout(false);
            this.pnlThuNgan.ResumeLayout(false);
            this.pnlThongKe.ResumeLayout(false);
            this.pnlUserControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private System.Windows.Forms.PictureBox picExit;
        private DevExpress.XtraEditors.SimpleButton btnMain;
        private DevExpress.XtraEditors.SimpleButton btnThuNgan;
        private DevExpress.XtraEditors.SimpleButton btnKho;
        private DevExpress.XtraEditors.SimpleButton btnQuanLi;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.Panel pnlKhoHang;
        private DevExpress.XtraEditors.SimpleButton btnSanPham;
        private DevExpress.XtraEditors.SimpleButton btnNhapHang;
        private DevExpress.XtraEditors.SimpleButton btnHeThong;
        private System.Windows.Forms.Panel pnlQuanLi;
        private DevExpress.XtraEditors.SimpleButton btnKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnNCC;
        private DevExpress.XtraEditors.SimpleButton btnNV;
        private DevExpress.XtraEditors.SimpleButton btnTaiKhoan;
        private System.Windows.Forms.Panel pnlHeThong;
        private System.Windows.Forms.Panel pnlThuNgan;
        private DevExpress.XtraEditors.SimpleButton btnBanHang;
        private DevExpress.XtraEditors.SimpleButton btnHoaDon;
        private System.Windows.Forms.Panel pnlThongKe;
        private DevExpress.XtraEditors.SimpleButton btnTKDT;
        private DevExpress.XtraEditors.SimpleButton btnTKPN;
        private DevExpress.XtraEditors.SimpleButton btnTKKho;
        private System.Windows.Forms.Panel pnlUserControl;
        private DevExpress.XtraEditors.SimpleButton btnNameUser;
        private System.Windows.Forms.PictureBox picLogout;
    }
}