namespace GUI
{
    partial class frmDanhsachNV
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
            this.dgvDanhsachNV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhsachNV
            // 
            this.dgvDanhsachNV.AllowUserToAddRows = false;
            this.dgvDanhsachNV.AllowUserToDeleteRows = false;
            this.dgvDanhsachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachNV.Location = new System.Drawing.Point(2, -5);
            this.dgvDanhsachNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhsachNV.Name = "dgvDanhsachNV";
            this.dgvDanhsachNV.ReadOnly = true;
            this.dgvDanhsachNV.RowHeadersWidth = 51;
            this.dgvDanhsachNV.RowTemplate.Height = 24;
            this.dgvDanhsachNV.Size = new System.Drawing.Size(1012, 454);
            this.dgvDanhsachNV.TabIndex = 0;
            this.dgvDanhsachNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsachNV_CellContentClick);
            // 
            // frmDanhsachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 452);
            this.Controls.Add(this.dgvDanhsachNV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDanhsachNV";
            this.Text = "frmDanhsachNV";
            this.Load += new System.EventHandler(this.frmDanhsachNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhsachNV;
    }
}