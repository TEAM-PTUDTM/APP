using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SizeBLL
    {
        SizeDAL SizeDAL = new SizeDAL();
        public List<kichthuoc> getSize()
        {
            return SizeDAL.getSize();
        }
        public bool deleteSize(int id)
        {
            return SizeDAL.deleteSize(id);
        }
        public bool updateSize(kichthuoc kichthuoc)
        {
            return SizeDAL.updateSize(kichthuoc);
        }
        public bool checkPrymaryID(int id)
        {
            var size = SizeDAL.findByIdSize(id);
            if (size != null)
                return true;
            return false;
        }
    }
}
