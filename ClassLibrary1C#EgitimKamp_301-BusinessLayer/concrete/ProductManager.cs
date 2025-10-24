using C_EgitimKamp_301_Entity_Layer.concrete;
using ClassLibrary1C_EgitimKamp_301_BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1C_EgitimKamp_301_BusinessLayer.concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductService _productDal;

        public ProductManager(IProductService productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product entity)
        {
            _productDal.TDelete(entity);
        }

        public List<Product> TGetAll()
        {
            return _productDal.TGetAll();
        }

        public Product TGetById(int id)
        {
            return _productDal.TGetById(id);
        }

        public void TInsert(Product entity)
        {
            _productDal.TInsert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.TUpdate(entity);
        }
    }
}
