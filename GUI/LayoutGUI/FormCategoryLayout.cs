using GUI.CategoryGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.LayoutGUI
{
    public partial class FormCategoryLayout : Form
    {
        public FormCategoryLayout()
        {
            InitializeComponent();
            btn_productSize.Click += Btn_productSize_Click;
            btn_Product_color.Click += Btn_Product_color_Click;
            btn_CategoryProduct.Click += Btn_CategoryProduct_Click;
        }

        private void Btn_CategoryProduct_Click(object sender, EventArgs e)
        {
            LoadProductCategoryProduct();
        }

        private void Btn_Product_color_Click(object sender, EventArgs e)
        {
            LoadProductColor();
        }

        private void Btn_productSize_Click(object sender, EventArgs e)
        {
            LoadProductSize();
        }

        private void LoadProductCategoryProduct()
        {
            if (this.Panel_content_category.Controls.Count > 0)
                this.Panel_content_category.Controls[0].Dispose();
            FormCategoryType productForm = new FormCategoryType();
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;
            this.Panel_content_category.Controls.Add(productForm);
            this.Panel_content_category.Tag = productForm;
            productForm.Show();
        }
        private void LoadProductSize()
        {
            if (this.Panel_content_category.Controls.Count > 0)
                this.Panel_content_category.Controls[0].Dispose();
            FormCategory_Size productForm = new FormCategory_Size();
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;
            this.Panel_content_category.Controls.Add(productForm);
            this.Panel_content_category.Tag = productForm;
            productForm.Show();
        }

        private void LoadProductColor()
        {
            if (this.Panel_content_category.Controls.Count > 0)
                this.Panel_content_category.Controls[0].Dispose();
            FormCategory_Color productForm = new FormCategory_Color();
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;
            this.Panel_content_category.Controls.Add(productForm);
            this.Panel_content_category.Tag = productForm;
            productForm.Show();
        }

        private void FormCategoryLayout_Load(object sender, EventArgs e)
        {

        }
    }
}
