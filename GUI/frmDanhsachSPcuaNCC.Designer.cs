namespace GUI
{
    partial class frmDanhsachSPcuaNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhsachSPcuaNCC));
            this.dgvDSSPcuaNCC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSPcuaNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSSPcuaNCC
            // 
            this.dgvDSSPcuaNCC.AllowUserToAddRows = false;
            this.dgvDSSPcuaNCC.AllowUserToDeleteRows = false;
            this.dgvDSSPcuaNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSPcuaNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSPcuaNCC.Location = new System.Drawing.Point(2, 2);
            this.dgvDSSPcuaNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSSPcuaNCC.Name = "dgvDSSPcuaNCC";
            this.dgvDSSPcuaNCC.ReadOnly = true;
            this.dgvDSSPcuaNCC.RowHeadersWidth = 51;
            this.dgvDSSPcuaNCC.RowTemplate.Height = 24;
            this.dgvDSSPcuaNCC.Size = new System.Drawing.Size(906, 423);
            this.dgvDSSPcuaNCC.TabIndex = 0;
            // 
            // frmDanhsachSPcuaNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 427);
            this.Controls.Add(this.dgvDSSPcuaNCC);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmDanhsachSPcuaNCC.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDanhsachSPcuaNCC";
            this.Text = "Danh Sách Sản Phẩm Thuộc Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmDanhsachSPcuaNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSPcuaNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSPcuaNCC;
    }
}