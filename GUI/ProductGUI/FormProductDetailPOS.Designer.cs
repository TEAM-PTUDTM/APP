namespace GUI.ProductGUI
{
    partial class FormProductDetailPOS
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
            this.Panel_ListProductItem = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.SuspendLayout();
            // 
            // Panel_ListProductItem
            // 
            this.Panel_ListProductItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Panel_ListProductItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Panel_ListProductItem.Location = new System.Drawing.Point(3, 5);
            this.Panel_ListProductItem.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_ListProductItem.Name = "Panel_ListProductItem";
            this.Panel_ListProductItem.ShadowColor = System.Drawing.Color.Black;
            this.Panel_ListProductItem.Size = new System.Drawing.Size(795, 443);
            this.Panel_ListProductItem.TabIndex = 1;
            // 
            // FormProductDetailPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_ListProductItem);
            this.Name = "FormProductDetailPOS";
            this.Text = "FormProductDetailPOS";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel Panel_ListProductItem;
    }
}