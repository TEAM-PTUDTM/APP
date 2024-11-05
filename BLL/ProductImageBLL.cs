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
        private readonly ProductImage ProductImageDAL = new ProductImage();

        public async Task<List<hinhanh>> getProductImage()
        {
            return await ProductImageDAL.getImageProduct();
        }
        public async Task<bool> addImageProduct(hinhanh hinhanh)
        {
            return await ProductImageDAL.addImageProduct(hinhanh);
        }
        public async Task<bool> deleteProductImage(int id)
        {
            return await ProductImageDAL.deleteImageProduct(id);
        }

        public async Task<bool> updateProductImage(hinhanh img)
        {
            return await ProductImageDAL.updateImageProduct(img);
        }

        public async Task<bool> checkPrimaryID(int id)
        {
            var productImage = await ProductImageDAL.findByIdImageProduct(id);
            return productImage != null;
        }

        public async Task<List<hinhanh>> getImageByMaSP(int masp)
        {
            return await ProductImageDAL.findByMaSP(masp);
        }
    }
}
