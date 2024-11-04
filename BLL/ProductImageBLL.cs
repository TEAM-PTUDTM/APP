using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ProductImageBLL
    {
        ProductImage ProductImageDAL = new ProductImage();
        public List<hinhanh> getProductImage()
        {
            return ProductImageDAL.getImageProduct();
        }
        public bool deleteProductImage(int id)
        {
            return ProductImageDAL.deleteImageProduct(id);
        }
        public bool updateProductImage(hinhanh img)
        {
            return ProductImageDAL.updateImageProduct(img);
        }
        public bool checkPrymaryID(int id)
        {
            var ProductImage = ProductImageDAL.findByIdImageProduct(id);
            if (ProductImage != null)
                return true;
            return false;
        }
        public List<hinhanh> getImageByMaSP(int masp)
        {
            return ProductImageDAL.findByMaSP(masp);
        }
    }
}
