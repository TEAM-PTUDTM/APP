using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CategoryBLL
    {
        CategoryDAL categoryDAL = new CategoryDAL();
        public List<danhmuc> getCategory()
        {
            return categoryDAL.getCategory();
        }
        public bool deleteCategory(int id)
        {
            return categoryDAL.deleteCategory(id);
        }
        public bool updateCategory(danhmuc danhmuc)
        {
            return categoryDAL.updateCategory(danhmuc);
        }
        public bool checkPrymaryID(int id)
        {
            var cate = categoryDAL.findByIdCategory(id);
            if (cate != null)
                return true;
            return false;
        }
    }
}
