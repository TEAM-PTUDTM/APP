using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SizeDAL
    {

        QLSHOPDataContext sql = new QLSHOPDataContext();
        public List<kichthuoc> getSize()
        {
            return sql.kichthuocs.Select(size => size).ToList<kichthuoc>();
        }
        public kichthuoc findByIdSize(int id)
        {
            return sql.kichthuocs.Where(Size => Size.MaKichThuoc == id).FirstOrDefault();
        }
        public bool addSize(kichthuoc Size)
        {
            try
            {
                sql.kichthuocs.InsertOnSubmit(Size);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteSize(int id)
        {
            try
            {
                var Size = findByIdSize(id);
                sql.kichthuocs.DeleteOnSubmit(Size);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateSize(kichthuoc Size)
        {
            try
            {
                var s = findByIdSize(Size.MaKichThuoc);
                s.TenKichThuoc = Size.TenKichThuoc;
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
