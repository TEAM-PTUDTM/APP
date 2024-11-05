using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using BLL;
using component;
using DTO;

namespace GUI.ProductGUI
{
    public partial class FormProductDetail : Form
    {
        ProductBLL Product_BLL = new ProductBLL();
        CategoryBLL Category_BLL = new CategoryBLL();
        ProductImageBLL ProductImage_BLL = new ProductImageBLL();
        private int _MaSP;
        private string imagePath;
        public FormProductDetail(int MaSP)
        {
            InitializeComponent();
            _MaSP = MaSP;
            ShowImageProduct();
        }

        private void FormProductDetail_Load(object sender, EventArgs e)
        {
            // Ẩn nút create khi chưa có ảnh
            btn_create.Enabled = false;

            

            sanpham pro = Product_BLL.findByIdProduct(_MaSP);

            textBox_Name.Text = pro.TenSP.ToString();
            txt_Price.Text = (string)pro.Gia.ToString();
            txt_Sale.Text = (string)pro.PhanTramGiamGia.ToString();
            textbox_Title.Text = pro.MoTa.ToString();

            // Thiết lập ComboBox_Category
            ComboBox_Category.Items.Clear();


            var categories = Category_BLL.getCategory();

            // Đưa danh sách các danh mục vào ComboBox_Category
            foreach (var category in categories)
            {
                ComboBox_Category.Items.Add(category.TenDanhMuc);
            }

            // Chọn danh mục hiện tại của sản phẩm
            ComboBox_Category.SelectedItem = categories.FirstOrDefault(c => c.MaDanhMuc == pro.MaDanhMuc)?.TenDanhMuc;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel_Image_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void ShowImageProduct()
        {

            // Xóa các control cũ
            Panel_Image.Controls.Clear();

            List<hinhanh> ListImage = await ProductImage_BLL.getImageByMaSP(_MaSP);

            //đưa hình ảnh vào panle
            int xOffset = 0; // Vị trí hiện tại theo chiều ngang
            int yOffset = 0; // Vị trí hiện tại theo chiều dọc
            int itemWidth = 111; // Chiều rộng UC
            int itemHeight = 133;// Chiều cao UC
            int spacing = 2; // khoảng cách 


            Panel_Image.AutoScroll = true;

            foreach (var img in ListImage)
            {
                UC_Image imageItem = new UC_Image()
                {
                    MaHinhAnh = img.MaHinhAnh,
                    UrlImage = img.Hinhanh1
                };

                // Lắng nghe sự kiện xóa ảnh
                imageItem.ImageDeleted += ShowImageProduct;

                if (xOffset + itemWidth > Panel_Image.Width)
                {
                    xOffset = 0; // Reset vị trí ngang
                    yOffset += itemHeight + spacing; // Di chuyển xuống hàng mới
                }

                // Đặt vị trí cho UserControl
                imageItem.Location = new System.Drawing.Point(xOffset, yOffset);

                // Cập nhật giá trị xOffset để đặt vị trí cho UserControl kế tiếp
                xOffset += itemWidth + spacing;

                // Thêm UserControl vào panel_Products
                Panel_Image.Controls.Add(imageItem);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            // Configure Cloudinary
            Account account = new Account(
                "dkcizqsb3", // Cloud name
                "949665292283997", // API Key
                "YiDW4WfWgWa9GiY_gtpp95DQwvo" // API Secret
            );
            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);

            // Upload the image to Cloudinary
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(imagePath)
            };
            var uploadResult = cloudinary.Upload(uploadParams);

            if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string imageUrl = uploadResult.SecureUrl.ToString();

               
                hinhanh product = new hinhanh
                {
                    MaSp = _MaSP,
                    Hinhanh1 = imageUrl,
                };

                imagePath = null;
                btn_create.Visible = false;

                MessageBox.Show("Image uploaded successfully and URL saved to the database.");
                ShowImageProduct();
            }
            else
            {
                MessageBox.Show("Failed to upload image to Cloudinary.");
            }
        }
    }
}
