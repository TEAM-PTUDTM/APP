namespace DangNhap
{
    partial class uc_DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_can = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(137, 31);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(206, 22);
            this.txt_User.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(137, 122);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(268, 122);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(75, 23);
            this.btn_can.TabIndex = 3;
            this.btn_can.Text = "Cancel";
            this.btn_can.UseVisualStyleBackColor = true;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(137, 75);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(206, 22);
            this.txt_Pass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // uc_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label1);
            this.Name = "uc_DangNhap";
            this.Size = new System.Drawing.Size(374, 172);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label label2;
    }
}
