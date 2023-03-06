namespace GUI
{
    partial class usctrlNoti
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
            this.lblNoti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoti
            // 
            this.lblNoti.BackColor = System.Drawing.Color.White;
            this.lblNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.Location = new System.Drawing.Point(-3, 0);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(675, 32);
            this.lblNoti.TabIndex = 0;
            this.lblNoti.Text = "Thông Báo :))";
            this.lblNoti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usctrlNoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoti);
            this.Name = "usctrlNoti";
            this.Size = new System.Drawing.Size(660, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNoti;
    }
}
