using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EgitimKamp_301_Entity_Layer.concrete
{
    public class Customer

    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDisrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }

        public bool CustomerStatus { get; set; }



    }
}
