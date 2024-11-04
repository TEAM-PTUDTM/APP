using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ColorDAL
    {
        QLSHOPDataContext sql = new QLSHOPDataContext();
        public List<mausac> getColor()
        {
            return sql.mausacs.Select(color => color).ToList<mausac>();
        }
        public mausac findByIdColor(int id)
        {
            return sql.mausacs.Where(color => color.MaMau == id).FirstOrDefault();
        }
        public bool addColor(mausac color)
        {
            try
            {
                sql.mausacs.InsertOnSubmit(color);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteColor(int id)
        {
            try
            {
                var Color = findByIdColor(id);
                sql.mausacs.DeleteOnSubmit(Color);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateColor(mausac color)
        {
            try
            {
                var Color = findByIdColor(color.MaMau);
                Color.TenMau = color.TenMau;
                Color.HEXCODE = color.HEXCODE;
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
