using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace component
{
    public partial class UC_Image : UserControl
    {
        ProductImageBLL ProductImageBLL = new ProductImageBLL();
        private string urlImage;
        private int maHinhAnh;

        // Delegate để thông báo sự kiện xóa hình ảnh
        public delegate void ImageDeletedHandler();
        public event ImageDeletedHandler ImageDeleted;

        public string UrlImage { get => urlImage; set => urlImage = value; }
        public int MaHinhAnh { get => maHinhAnh; set => maHinhAnh = value; }


        public UC_Image()
        {
            InitializeComponent();
            
        }
        private void UC_Image_Load(object sender, EventArgs e)
        {
            pictureBox_image.Load(UrlImage);
        }
        private void pictureBox_image_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Are you sure you want to delete this image?", "Delete Image", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ProductImageBLL.deleteProductImage(MaHinhAnh);

                ImageDeleted?.Invoke();

                MessageBox.Show("Image deleted successfully.");
            }
        }

        
    }
}
