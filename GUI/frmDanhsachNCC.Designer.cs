namespace GUI
{
    partial class frmDanhsachNCC
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
            this.dgvDanhsachNCC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhsachNCC
            // 
            this.dgvDanhsachNCC.AllowUserToAddRows = false;
            this.dgvDanhsachNCC.AllowUserToDeleteRows = false;
            this.dgvDanhsachNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsachNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachNCC.Location = new System.Drawing.Point(1, -4);
            this.dgvDanhsachNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhsachNCC.Name = "dgvDanhsachNCC";
            this.dgvDanhsachNCC.ReadOnly = true;
            this.dgvDanhsachNCC.RowHeadersWidth = 51;
            this.dgvDanhsachNCC.RowTemplate.Height = 24;
            this.dgvDanhsachNCC.Size = new System.Drawing.Size(1107, 459);
            this.dgvDanhsachNCC.TabIndex = 0;
            // 
            // frmDanhsachNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 458);
            this.Controls.Add(this.dgvDanhsachNCC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDanhsachNCC";
            this.Text = "frmDanhsachNCC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhsachNCC;
    }
}