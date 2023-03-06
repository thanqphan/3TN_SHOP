namespace GUI
{
    partial class usctrlPhieuNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoPN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPNTK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radthang = new System.Windows.Forms.RadioButton();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radngay = new System.Windows.Forms.RadioButton();
            this.dateHD = new DevExpress.XtraEditors.DateEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNTK)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnXuatFile.Appearance.Options.UseFont = true;
            this.btnXuatFile.Appearance.Options.UseForeColor = true;
            this.btnXuatFile.Location = new System.Drawing.Point(989, 104);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(125, 35);
            this.btnXuatFile.TabIndex = 105;
            this.btnXuatFile.Text = "Xuất File Thống Kê";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 18);
            this.label6.TabIndex = 98;
            this.label6.Text = "Số Phiếu Nhập được tạo";
            // 
            // lblSoPN
            // 
            this.lblSoPN.AutoSize = true;
            this.lblSoPN.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPN.ForeColor = System.Drawing.Color.Orange;
            this.lblSoPN.Location = new System.Drawing.Point(525, 82);
            this.lblSoPN.Name = "lblSoPN";
            this.lblSoPN.Size = new System.Drawing.Size(82, 27);
            this.lblSoPN.TabIndex = 96;
            this.lblSoPN.Text = "10000";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 8);
            this.label2.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 23);
            this.label3.TabIndex = 92;
            this.label3.Text = "THỐNG KÊ PHIẾU NHẬP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPNTK);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 403);
            this.panel2.TabIndex = 3;
            // 
            // dgvPNTK
            // 
            this.dgvPNTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPNTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPNTK.Location = new System.Drawing.Point(1, 11);
            this.dgvPNTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPNTK.Name = "dgvPNTK";
            this.dgvPNTK.RowHeadersWidth = 51;
            this.dgvPNTK.RowTemplate.Height = 24;
            this.dgvPNTK.Size = new System.Drawing.Size(1110, 390);
            this.dgvPNTK.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1106, 8);
            this.label1.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radthang);
            this.panel1.Controls.Add(this.radnam);
            this.panel1.Controls.Add(this.radngay);
            this.panel1.Controls.Add(this.btnXuatFile);
            this.panel1.Controls.Add(this.dateHD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblSoPN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 139);
            this.panel1.TabIndex = 2;
            // 
            // radthang
            // 
            this.radthang.AutoSize = true;
            this.radthang.Location = new System.Drawing.Point(27, 82);
            this.radthang.Name = "radthang";
            this.radthang.Size = new System.Drawing.Size(82, 17);
            this.radthang.TabIndex = 107;
            this.radthang.TabStop = true;
            this.radthang.Text = "Theo Tháng";
            this.radthang.UseVisualStyleBackColor = true;
            this.radthang.CheckedChanged += new System.EventHandler(this.radthang_CheckedChanged);
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(27, 119);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(73, 17);
            this.radnam.TabIndex = 107;
            this.radnam.TabStop = true;
            this.radnam.Text = "Theo Năm";
            this.radnam.UseVisualStyleBackColor = true;
            this.radnam.CheckedChanged += new System.EventHandler(this.radnam_CheckedChanged);
            // 
            // radngay
            // 
            this.radngay.AutoSize = true;
            this.radngay.Location = new System.Drawing.Point(27, 47);
            this.radngay.Name = "radngay";
            this.radngay.Size = new System.Drawing.Size(77, 17);
            this.radngay.TabIndex = 106;
            this.radngay.TabStop = true;
            this.radngay.Text = "Theo Ngày";
            this.radngay.UseVisualStyleBackColor = true;
            this.radngay.CheckedChanged += new System.EventHandler(this.radngay_CheckedChanged);
            // 
            // dateHD
            // 
            this.dateHD.EditValue = new System.DateTime(2022, 12, 7, 12, 41, 40, 410);
            this.dateHD.Location = new System.Drawing.Point(128, 42);
            this.dateHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateHD.Name = "dateHD";
            // 
            // 
            // 
            this.dateHD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.dateHD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHD.Size = new System.Drawing.Size(213, 20);
            this.dateHD.TabIndex = 101;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.import;
            this.pictureBox1.Location = new System.Drawing.Point(429, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // usctrlPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "usctrlPhieuNhap";
            this.Size = new System.Drawing.Size(1115, 550);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNTK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateHD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXuatFile;
        private DevExpress.XtraEditors.DateEdit dateHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSoPN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPNTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radthang;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radngay;
    }
}
