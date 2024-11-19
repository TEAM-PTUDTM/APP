namespace GUI.LayoutGUI
{
    partial class FormLogin
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
            this.uc_DangNhap1 = new DangNhap.uc_DangNhap();
            this.SuspendLayout();
            // 
            // uc_DangNhap1
            // 
            this.uc_DangNhap1.Conn = null;
            this.uc_DangNhap1.Location = new System.Drawing.Point(12, 12);
            this.uc_DangNhap1.Name = "uc_DangNhap1";
            this.uc_DangNhap1.Size = new System.Drawing.Size(374, 172);
            this.uc_DangNhap1.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 187);
            this.Controls.Add(this.uc_DangNhap1);
            this.Name = "FormLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private DangNhap.uc_DangNhap uc_DangNhap1;
    }
}