using C_EgitimKamp_301_Entity_Layer.concrete;
using ClassLibrary1C_EgitimKamp_301_BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1C_EgitimKamp_301_BusinessLayer.concrete
{
    public class OrderManager : IOrderService


    {
        private readonly IOrderService _orderDal;

        public OrderManager(IOrderService orderdal)
        {
            _orderDal = orderdal;
        }

        public void TDelete(Order entity)
        {
            _orderDal.TDelete(entity);
        }

        public List<Order> TGetAll()
        {
           return _orderDal.TGetAll();
        }

        public Order TGetById(int id)
        {
            return _orderDal.TGetById(id);
        }

        public void TInsert(Order entity)
        {
            _orderDal.TInsert(entity);
        }

        public void TUpdate(Order entity)
        {
            _orderDal.TUpdate(entity);
        }
    }
}
