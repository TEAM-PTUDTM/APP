using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ColorBLL
    {
        ColorDAL colorDAL = new ColorDAL();
        public List<mausac> getColor()
        {
            return colorDAL.getColor();
        }
        public bool deleteColor(int id) 
        { 
            return colorDAL.deleteColor(id);
        }
        public bool addColor(mausac mausac) 
        {
            if (checkPrymaryID(mausac.MaMau) == false)
            {
                return colorDAL.addColor(mausac);
            }
            return false;
            
        }
        public bool updateColor(mausac mausac) 
        { 
            return colorDAL.updateColor(mausac);
        }

        public bool checkPrymaryID(int id) 
        {
            var color = colorDAL.findByIdColor(id);
            if (color != null)
                return true;
            return false;
        }
    }
}
