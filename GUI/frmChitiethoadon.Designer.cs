namespace GUI
{
    partial class frmChitiethoadon
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
            this.lblChitiethoadon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvChitiethoadon = new System.Windows.Forms.DataGridView();
            this.lblNV = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChitiethoadon
            // 
            this.lblChitiethoadon.AutoSize = true;
            this.lblChitiethoadon.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChitiethoadon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblChitiethoadon.Location = new System.Drawing.Point(19, 15);
            this.lblChitiethoadon.Name = "lblChitiethoadon";
            this.lblChitiethoadon.Size = new System.Drawing.Size(142, 31);
            this.lblChitiethoadon.TabIndex = 0;
            this.lblChitiethoadon.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên:";
            // 
            // dgvChitiethoadon
            // 
            this.dgvChitiethoadon.AllowUserToAddRows = false;
            this.dgvChitiethoadon.AllowUserToDeleteRows = false;
            this.dgvChitiethoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiethoadon.Location = new System.Drawing.Point(9, 96);
            this.dgvChitiethoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChitiethoadon.Name = "dgvChitiethoadon";
            this.dgvChitiethoadon.ReadOnly = true;
            this.dgvChitiethoadon.RowHeadersWidth = 51;
            this.dgvChitiethoadon.RowTemplate.Height = 24;
            this.dgvChitiethoadon.Size = new System.Drawing.Size(606, 327);
            this.dgvChitiethoadon.TabIndex = 2;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNV.Location = new System.Drawing.Point(450, 56);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(37, 22);
            this.lblNV.TabIndex = 3;
            this.lblNV.Text = "NV";
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.Location = new System.Drawing.Point(450, 15);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(38, 22);
            this.lblKH.TabIndex = 4;
            this.lblKH.Text = "KH";
            // 
            // frmChitiethoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 433);
            this.Controls.Add(this.lblNV);
            this.Controls.Add(this.lblKH);
            this.Controls.Add(this.dgvChitiethoadon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblChitiethoadon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChitiethoadon";
            this.Text = "frmChitiethoadon";
            this.Load += new System.EventHandler(this.frmChitiethoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiethoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChitiethoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvChitiethoadon;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.Label lblKH;
    }
}