namespace GUI
{
    partial class usctrlDoanhThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbThoigian = new System.Windows.Forms.ComboBox();
            this.lblSP1 = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDoanhthutext = new System.Windows.Forms.Label();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHDTK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDTK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbThoigian);
            this.panel1.Controls.Add(this.lblSP1);
            this.panel1.Controls.Add(this.lblDoanhThu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblDoanhthutext);
            this.panel1.Controls.Add(this.lblSoHD);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnXuatFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 139);
            this.panel1.TabIndex = 0;
            // 
            // cbbThoigian
            // 
            this.cbbThoigian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThoigian.FormattingEnabled = true;
            this.cbbThoigian.Location = new System.Drawing.Point(128, 50);
            this.cbbThoigian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbThoigian.Name = "cbbThoigian";
            this.cbbThoigian.Size = new System.Drawing.Size(150, 21);
            this.cbbThoigian.TabIndex = 114;
            this.cbbThoigian.SelectedIndexChanged += new System.EventHandler(this.cbbThoigian_SelectedIndexChanged_1);
            // 
            // lblSP1
            // 
            this.lblSP1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP1.Location = new System.Drawing.Point(12, 41);
            this.lblSP1.Name = "lblSP1";
            this.lblSP1.Size = new System.Drawing.Size(111, 41);
            this.lblSP1.TabIndex = 113;
            this.lblSP1.Text = "Thời gian:";
            this.lblSP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDoanhThu.Location = new System.Drawing.Point(819, 84);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(82, 27);
            this.lblDoanhThu.TabIndex = 112;
            this.lblDoanhThu.Text = "10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 18);
            this.label6.TabIndex = 111;
            this.label6.Text = "SỐ HÓA ĐƠN ĐÃ THANH TOÁN ";
            // 
            // lblDoanhthutext
            // 
            this.lblDoanhthutext.AutoSize = true;
            this.lblDoanhthutext.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhthutext.Location = new System.Drawing.Point(717, 49);
            this.lblDoanhthutext.Name = "lblDoanhthutext";
            this.lblDoanhthutext.Size = new System.Drawing.Size(185, 18);
            this.lblDoanhthutext.TabIndex = 110;
            this.lblDoanhthutext.Text = "DOANH THU ĐẠT ĐƯỢC";
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHD.ForeColor = System.Drawing.Color.Orange;
            this.lblSoHD.Location = new System.Drawing.Point(540, 84);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(82, 27);
            this.lblSoHD.TabIndex = 109;
            this.lblSoHD.Text = "10000";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.profits9;
            this.pictureBox2.Location = new System.Drawing.Point(718, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 108;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.bill;
            this.pictureBox1.Location = new System.Drawing.Point(429, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(903, 8);
            this.label2.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 92;
            this.label3.Text = "THỐNG KÊ DOANH THU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHDTK);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 403);
            this.panel2.TabIndex = 1;
            // 
            // dgvHDTK
            // 
            this.dgvHDTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDTK.Location = new System.Drawing.Point(1, 11);
            this.dgvHDTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHDTK.Name = "dgvHDTK";
            this.dgvHDTK.RowHeadersWidth = 51;
            this.dgvHDTK.RowTemplate.Height = 24;
            this.dgvHDTK.Size = new System.Drawing.Size(1110, 390);
            this.dgvHDTK.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1106, 8);
            this.label1.TabIndex = 103;
            // 
            // usctrlDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "usctrlDoanhThu";
            this.Size = new System.Drawing.Size(1115, 550);
            this.Load += new System.EventHandler(this.usctrlDoanhThu_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnXuatFile;
        private System.Windows.Forms.DataGridView dgvHDTK;
        private System.Windows.Forms.ComboBox cbbThoigian;
        private System.Windows.Forms.Label lblSP1;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDoanhthutext;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
