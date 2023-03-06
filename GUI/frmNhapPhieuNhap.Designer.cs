namespace GUI
{
    partial class frmNhapPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapPhieuNhap));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDPN = new System.Windows.Forms.TextBox();
            this.txtIDNCC = new System.Windows.Forms.TextBox();
            this.dateNgNhap = new DevExpress.XtraEditors.DateEdit();
            this.btnBoxNCC = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaThem = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.richtxtNote = new System.Windows.Forms.RichTextBox();
            this.btnRetry = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddPN = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIdNV = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTrKhau = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thông tin Phiếu Nhập :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 11);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Nhà Cung Cấp :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày Lập Phiếu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã Phiếu Nhập :";
            // 
            // txtIDPN
            // 
            this.txtIDPN.Location = new System.Drawing.Point(175, 61);
            this.txtIDPN.Name = "txtIDPN";
            this.txtIDPN.Size = new System.Drawing.Size(307, 23);
            this.txtIDPN.TabIndex = 0;
            // 
            // txtIDNCC
            // 
            this.txtIDNCC.Location = new System.Drawing.Point(175, 93);
            this.txtIDNCC.Name = "txtIDNCC";
            this.txtIDNCC.Size = new System.Drawing.Size(307, 23);
            this.txtIDNCC.TabIndex = 1;
            // 
            // dateNgNhap
            // 
            this.dateNgNhap.EditValue = null;
            this.dateNgNhap.Location = new System.Drawing.Point(499, 212);
            this.dateNgNhap.Name = "dateNgNhap";
            this.dateNgNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgNhap.Size = new System.Drawing.Size(307, 22);
            this.dateNgNhap.TabIndex = 3;
            // 
            // btnBoxNCC
            // 
            this.btnBoxNCC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBoxNCC.ImageOptions.SvgImage")));
            this.btnBoxNCC.Location = new System.Drawing.Point(484, 86);
            this.btnBoxNCC.Name = "btnBoxNCC";
            this.btnBoxNCC.Size = new System.Drawing.Size(44, 30);
            this.btnBoxNCC.TabIndex = 2;
            this.btnBoxNCC.Click += new System.EventHandler(this.btnBoxNCC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Chi tiết Phiếu Nhập :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(12, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 11);
            this.panel2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Danh sách Hàng Nhập :";
            // 
            // dgvCT
            // 
            this.dgvCT.AllowUserToAddRows = false;
            this.dgvCT.AllowUserToDeleteRows = false;
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.SOLUONG,
            this.THANHTIEN});
            this.dgvCT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCT.Location = new System.Drawing.Point(12, 235);
            this.dgvCT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.ReadOnly = true;
            this.dgvCT.RowHeadersVisible = false;
            this.dgvCT.RowHeadersWidth = 51;
            this.dgvCT.Size = new System.Drawing.Size(794, 237);
            this.dgvCT.TabIndex = 27;
            // 
            // MASP
            // 
            this.MASP.FillWeight = 50F;
            this.MASP.HeaderText = "Mã Sản Phẩm";
            this.MASP.MinimumWidth = 6;
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            // 
            // TENSP
            // 
            this.TENSP.HeaderText = "Tên Sản Phẩm";
            this.TENSP.MinimumWidth = 6;
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.FillWeight = 50F;
            this.SOLUONG.HeaderText = "Số Lượng Nhập";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(813, 235);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 55);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm vào List";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnAddSP
            // 
            this.btnAddSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddSP.ImageOptions.SvgImage")));
            this.btnAddSP.Location = new System.Drawing.Point(813, 417);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(159, 55);
            this.btnAddSP.TabIndex = 6;
            this.btnAddSP.Text = "Thêm Sản Phẩm";
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // btnXoaThem
            // 
            this.btnXoaThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaThem.ImageOptions.SvgImage")));
            this.btnXoaThem.Location = new System.Drawing.Point(813, 308);
            this.btnXoaThem.Name = "btnXoaThem";
            this.btnXoaThem.Size = new System.Drawing.Size(159, 55);
            this.btnXoaThem.TabIndex = 5;
            this.btnXoaThem.Text = "Xóa khỏi List";
            this.btnXoaThem.Click += new System.EventHandler(this.btnXoaThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Note :";
            // 
            // richtxtNote
            // 
            this.richtxtNote.Location = new System.Drawing.Point(15, 538);
            this.richtxtNote.Name = "richtxtNote";
            this.richtxtNote.Size = new System.Drawing.Size(548, 148);
            this.richtxtNote.TabIndex = 32;
            this.richtxtNote.Text = "";
            // 
            // btnRetry
            // 
            this.btnRetry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRetry.ImageOptions.Image")));
            this.btnRetry.Location = new System.Drawing.Point(623, 596);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(183, 84);
            this.btnRetry.TabIndex = 9;
            this.btnRetry.Text = "Nhập Lại Phiếu";
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnAddPN
            // 
            this.btnAddPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPN.ImageOptions.Image")));
            this.btnAddPN.Location = new System.Drawing.Point(623, 506);
            this.btnAddPN.Name = "btnAddPN";
            this.btnAddPN.Size = new System.Drawing.Size(183, 84);
            this.btnAddPN.TabIndex = 8;
            this.btnAddPN.Text = "Tạo Phiếu Nhập";
            this.btnAddPN.Click += new System.EventHandler(this.btnAddPN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Mã Nhân Viên :";
            // 
            // lblIdNV
            // 
            this.lblIdNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIdNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNV.Location = new System.Drawing.Point(172, 130);
            this.lblIdNV.Name = "lblIdNV";
            this.lblIdNV.Size = new System.Drawing.Size(310, 18);
            this.lblIdNV.TabIndex = 36;
            this.lblIdNV.Text = "Mã Nhân Viên :";
            this.lblIdNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "Triết Khấu :";
            // 
            // cbxTrKhau
            // 
            this.cbxTrKhau.FormattingEnabled = true;
            this.cbxTrKhau.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%",
            ""});
            this.cbxTrKhau.Location = new System.Drawing.Point(104, 482);
            this.cbxTrKhau.Name = "cbxTrKhau";
            this.cbxTrKhau.Size = new System.Drawing.Size(109, 24);
            this.cbxTrKhau.TabIndex = 7;
            // 
            // frmNhapPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 710);
            this.Controls.Add(this.cbxTrKhau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblIdNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddPN);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.richtxtNote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoaThem);
            this.Controls.Add(this.btnAddSP);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBoxNCC);
            this.Controls.Add(this.dateNgNhap);
            this.Controls.Add(this.txtIDNCC);
            this.Controls.Add(this.txtIDPN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmNhapPhieuNhap.IconOptions.SvgImage")));
            this.Name = "frmNhapPhieuNhap";
            this.Text = "Tạo Phiếu Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.dateNgNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDPN;
        private System.Windows.Forms.TextBox txtIDNCC;
        private DevExpress.XtraEditors.DateEdit dateNgNhap;
        private DevExpress.XtraEditors.SimpleButton btnBoxNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnAddSP;
        private DevExpress.XtraEditors.SimpleButton btnXoaThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richtxtNote;
        private DevExpress.XtraEditors.SimpleButton btnRetry;
        private DevExpress.XtraEditors.SimpleButton btnAddPN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIdNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxTrKhau;
    }
}