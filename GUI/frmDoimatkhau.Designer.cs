namespace GUI
{
    partial class frmDoimatkhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXacminhMK = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuuMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txtMKcu
            // 
            this.txtMKcu.Location = new System.Drawing.Point(281, 12);
            this.txtMKcu.Multiline = true;
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(334, 29);
            this.txtMKcu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Location = new System.Drawing.Point(281, 65);
            this.txtMKmoi.Multiline = true;
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(334, 29);
            this.txtMKmoi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xác minh mật khẩu mới";
            // 
            // txtXacminhMK
            // 
            this.txtXacminhMK.Location = new System.Drawing.Point(281, 116);
            this.txtXacminhMK.Multiline = true;
            this.txtXacminhMK.Name = "txtXacminhMK";
            this.txtXacminhMK.Size = new System.Drawing.Size(334, 29);
            this.txtXacminhMK.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnThoat.Image = global::GUI.Properties.Resources.remove;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(436, 177);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 41);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLuuMK
            // 
            this.btnLuuMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLuuMK.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnLuuMK.Image = global::GUI.Properties.Resources.diskette;
            this.btnLuuMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuMK.Location = new System.Drawing.Point(88, 177);
            this.btnLuuMK.Name = "btnLuuMK";
            this.btnLuuMK.Size = new System.Drawing.Size(107, 41);
            this.btnLuuMK.TabIndex = 3;
            this.btnLuuMK.Text = "Lưu";
            this.btnLuuMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuMK.UseVisualStyleBackColor = false;
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 242);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuuMK);
            this.Controls.Add(this.txtXacminhMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.label1);
            this.Name = "frmDoimatkhau";
            this.Text = "frmDoimatkhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXacminhMK;
        private System.Windows.Forms.Button btnLuuMK;
        private System.Windows.Forms.Button btnThoat;
    }
}