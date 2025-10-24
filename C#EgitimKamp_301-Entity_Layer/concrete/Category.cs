using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EgitimKamp_301_Entity_Layer.concrete
{
    public class Category


    {

        //*field-variable-property

        // int id; -> bu birt field

        // public int y {  get; set; } -> bu bir property

        //    void test()
        //    {

        //        int p;  ----> bu bir variable olur

        //    }
        //} // get temel ayar (isimler büyük harfle yazılsın)\set ise kurallar koyar(en az 5 karakter gibi)
















        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }






    }
}
