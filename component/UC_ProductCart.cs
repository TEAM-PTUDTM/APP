using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace component
{
    public partial class UC_ProductCart : UserControl
    {
        private Form _parentForm;
        private Panel _overlayPanel;

        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal Sale { get; set; }
        public decimal Gia { get; set; }

        private Type _formProductDetailType;

        public UC_ProductCart()
        {
            InitializeComponent();
            _parentForm = null;
            _overlayPanel = new Panel();
        }

        public UC_ProductCart(Form defaultForm)
        {
            InitializeComponent();
            _parentForm = defaultForm;
            _overlayPanel = new Panel();
        }

        public void SetFormProductDetail(Type formType)
        {
            _formProductDetailType = formType;
        }

        public void SetParentForm(Form parentForm)
        {
            _parentForm = parentForm;
        }

        private void UC_ProductCart_Load(object sender, EventArgs e)
        {
            label_Price.Text = Gia.ToString("C");
            label_Sale.Text = Sale.ToString("P");
            Lable_NameProduct.Text = TenSP;
        }
        public event EventHandler<int> DetailButtonClick;

        private void btn_detail_Click(object sender, EventArgs e)
        {
            DetailButtonClick?.Invoke(this, MaSP);

            //MessageBox.Show($"Error");
            //if (_parentForm == null)
            //{
            //    _parentForm = this.FindForm();
            //}

            //if (_parentForm != null && _formProductDetailType != null)
            //{
            //    _overlayPanel.Size = _parentForm.ClientSize;
            //    _overlayPanel.Location = new Point(0, 0);
            //    _overlayPanel.BackColor = Color.FromArgb(128, 0, 0, 0);

            //    _parentForm.Controls.Add(_overlayPanel);
            //    _overlayPanel.BringToFront();

            //    try
            //    {
            //        Form formDetail = (Form)Activator.CreateInstance(_formProductDetailType, MaSP);
            //        formDetail.FormClosed += (s, args) =>
            //        {
            //            _parentForm.Controls.Remove(_overlayPanel);
            //        };

            //        formDetail.ShowDialog();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error: {ex.Message}");
            //    }
            //}
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
