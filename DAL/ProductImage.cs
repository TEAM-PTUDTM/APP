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
        QLSHOPDataContext sql = new QLSHOPDataContext();
        public List<hinhanh> getImageProduct()
        {
            return sql.hinhanhs.Select(img => img).ToList<hinhanh>();
        }
        public hinhanh findByIdImageProduct(int id)
        {
            return sql.hinhanhs.Where(img => img.MaHinhAnh == id).FirstOrDefault();
        }
        public bool addImageProduct(hinhanh img)
        {
            try
            {
                sql.hinhanhs.InsertOnSubmit(img);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteImageProduct(int id)
        {
            try
            {
                var image = findByIdImageProduct(id);
                sql.hinhanhs.DeleteOnSubmit(image);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateImageProduct(hinhanh img)
        {
            try
            {
                var image = findByIdImageProduct(img.MaHinhAnh);
                image.Hinhanh1 = img.Hinhanh1;
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<hinhanh> findByMaSP(int maSP)
        {
            return sql.hinhanhs.Where(img => img.MaSp == maSP).ToList<hinhanh>();
        }
    }
}
