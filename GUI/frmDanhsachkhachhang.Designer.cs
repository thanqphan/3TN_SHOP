namespace GUI
{
    partial class frmDanhsachkhachhang
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
            this.dgvDanhsachkhachhang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhsachkhachhang
            // 
            this.dgvDanhsachkhachhang.AllowUserToAddRows = false;
            this.dgvDanhsachkhachhang.AllowUserToDeleteRows = false;
            this.dgvDanhsachkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsachkhachhang.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDanhsachkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachkhachhang.Location = new System.Drawing.Point(1, 2);
            this.dgvDanhsachkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhsachkhachhang.Name = "dgvDanhsachkhachhang";
            this.dgvDanhsachkhachhang.ReadOnly = true;
            this.dgvDanhsachkhachhang.RowHeadersWidth = 51;
            this.dgvDanhsachkhachhang.RowTemplate.Height = 24;
            this.dgvDanhsachkhachhang.Size = new System.Drawing.Size(685, 444);
            this.dgvDanhsachkhachhang.TabIndex = 0;
            
            // 
            // frmDanhsachkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 447);
            this.Controls.Add(this.dgvDanhsachkhachhang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDanhsachkhachhang";
            this.Text = "frmDanhsachkhachhang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachkhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhsachkhachhang;
    }
}