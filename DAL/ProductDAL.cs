using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.Linq;
using DTO;
using System.ComponentModel;

namespace DAL
{
    public class ProductDAL
    {
        QLSHOPDataContext sql = new QLSHOPDataContext();
        public List<sanpham> getProduct()
        {
            return sql.sanphams.Select(pro => pro).ToList<sanpham>();
        }
        public sanpham findByIdProduct(int id)
        {
            return sql.sanphams.Where(pro => pro.MaSP == id).FirstOrDefault();
        }
        public bool addProduct(sanpham sp)
        {
            try
            {
                sql.sanphams.InsertOnSubmit(sp);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteProduct(int id)
        {
            try
            {
                var product = findByIdProduct(id);
                sql.sanphams.DeleteOnSubmit(product);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateProduct(sanpham sp)
        {
            try
            {
                var product = findByIdProduct(sp.MaSP);
                product.TenSP = sp.TenSP;
                product.Gia = sp.Gia;
                product.PhanTramGiamGia = sp.PhanTramGiamGia;
                product.MoTa = sp.MoTa;
                product.MaDanhMuc = sp.MaDanhMuc;
                product.MaNhaCungCap = sp.MaNhaCungCap;
                product.TrinhTrang = sp.TrinhTrang;
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


