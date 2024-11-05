using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class ProductImage
    {
        private readonly QLSHOPDataContext sql = new QLSHOPDataContext();

        public async Task<List<hinhanh>> getImageProduct()
        {
            return await Task.Run(() => sql.hinhanhs.ToList());
        }

        public async Task<hinhanh> findByIdImageProduct(int id)
        {
            return await Task.Run(() => sql.hinhanhs.FirstOrDefault(img => img.MaHinhAnh == id));
        }

        public async Task<bool> addImageProduct(hinhanh img)
        {
            try
            {
                await Task.Run(() =>
                {
                    sql.hinhanhs.InsertOnSubmit(img);
                    sql.SubmitChanges();
                });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> deleteImageProduct(int id)
        {
            try
            {
                var image = await findByIdImageProduct(id);
                if (image != null)
                {
                    await Task.Run(() =>
                    {
                        sql.hinhanhs.DeleteOnSubmit(image);
                        sql.SubmitChanges();
                    });
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> updateImageProduct(hinhanh img)
        {
            try
            {
                var image = await findByIdImageProduct(img.MaHinhAnh);
                if (image != null)
                {
                    image.Hinhanh1 = img.Hinhanh1;
                    await Task.Run(() => sql.SubmitChanges());
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<hinhanh>> findByMaSP(int maSP)
        {
            return await Task.Run(() => sql.hinhanhs.Where(img => img.MaSp == maSP).ToList());
        }
    }
}
