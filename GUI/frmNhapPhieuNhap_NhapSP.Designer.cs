namespace GUI
{
    partial class frmNhapPhieuNhap_NhapSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapPhieuNhap_NhapSP));
            this.picPicSP = new System.Windows.Forms.PictureBox();
            this.lblNameSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPicSP)).BeginInit();
            this.SuspendLayout();
            // 
            // picPicSP
            // 
            this.picPicSP.Image = global::GUI.Properties.Resources.z3935355526855_3f23253eaed0cbc5b09d93f4524e1235;
            this.picPicSP.Location = new System.Drawing.Point(35, 26);
            this.picPicSP.Name = "picPicSP";
            this.picPicSP.Size = new System.Drawing.Size(159, 138);
            this.picPicSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPicSP.TabIndex = 0;
            this.picPicSP.TabStop = false;
            // 
            // lblNameSP
            // 
            this.lblNameSP.AutoSize = true;
            this.lblNameSP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSP.Location = new System.Drawing.Point(58, 180);
            this.lblNameSP.Name = "lblNameSP";
            this.lblNameSP.Size = new System.Drawing.Size(105, 18);
            this.lblNameSP.TabIndex = 1;
            this.lblNameSP.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thành Tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số Lượng :";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(339, 42);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(204, 23);
            this.txtSL.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(339, 78);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(204, 23);
            this.txtThanhTien.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(411, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 61);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmNhapPhieuNhap_NhapSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 289);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNameSP);
            this.Controls.Add(this.picPicSP);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmNhapPhieuNhap_NhapSP.IconOptions.SvgImage")));
            this.Name = "frmNhapPhieuNhap_NhapSP";
            this.Text = "Chi tiết Sản Phẩm Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.picPicSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPicSP;
        private System.Windows.Forms.Label lblNameSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtThanhTien;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}