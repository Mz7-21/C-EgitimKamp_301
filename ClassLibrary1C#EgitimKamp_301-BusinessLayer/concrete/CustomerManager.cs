using C_EgitimKamp_301_Entity_Layer.concrete;
using ClassLibrary1C_EgitimKamp_301_BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1C_EgitimKamp_301_BusinessLayer.concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerService _customerdal;

        public CustomerManager(ICustomerService customerdal)
        {
            _customerdal = customerdal;
        }

        public void TDelete(Customer entity)
        {
            _customerdal.TDelete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerdal.TGetAll(); // x*n;
            // _customerdal.GetAll().Page.(1,20) 1n
        }

        public Customer TGetById(int id)
        {
            return _customerdal.TGetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName != "" && entity.CustomerSurname.Length >= 3 && entity.CustomerCity
                != null && entity.CustomerSurname != "" && entity.CustomerName.Length <= 30) 
            {

                _customerdal.TInsert(entity);
            
            }
            else
            {
                //hata mesajı  ver

            }
        }

        public void TUpdate(Customer entity)
        {
            if (entity.CustomerId != 0 && entity.CustomerCity.Length >= 3)
            {
                _customerdal.TUpdate(entity);
            }
            else
            {
                //hata mesajı yaz

            }
        }
    }
}
