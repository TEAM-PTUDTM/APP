using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void SetParentForm(Form parentForm)
        {
            _parentForm = parentForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_ProductCart_Load(object sender, EventArgs e)
        {
            label_Price.Text = Gia.ToString("C");
            label_Sale.Text = Sale.ToString("P");
            Lable_NameProduct.Text = TenSP;
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
           
        }
    }
}
