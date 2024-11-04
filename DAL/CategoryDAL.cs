using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CategoryDAL
    {
        QLSHOPDataContext sql = new QLSHOPDataContext();
        public List<danhmuc> getCategory()
        {
            return sql.danhmucs.Select(cate => cate).ToList<danhmuc>();
        }
        public danhmuc findByIdCategory(int id)
        {
            return sql.danhmucs.Where(cate => cate.MaDanhMuc == id).FirstOrDefault();
        }
        public bool addCategory(danhmuc danhmuc)
        {
            try
            {
                sql.danhmucs.InsertOnSubmit(danhmuc);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCategory(int id)
        {
            try
            {
                var category = findByIdCategory(id);
                sql.danhmucs.DeleteOnSubmit(category);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateCategory(danhmuc danhmuc)
        {
            try
            {
                var category = findByIdCategory(danhmuc.MaDanhMuc);
                category.TenDanhMuc = danhmuc.TenDanhMuc;
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
