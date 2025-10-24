using C_EgitimKamp_301_Entity_Layer.concrete;
using ClassLibrary1C_EgitimKamp_301_DataAccessLayer.Abstract;
using ClassLibrary1C_EgitimKamp_301_DataAccessLayer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1C_EgitimKamp_301_DataAccessLayer.EntityFramework
{
    public class EfProductDal:GenericRepository<Product> ,IProductDal
    {
    }
}
