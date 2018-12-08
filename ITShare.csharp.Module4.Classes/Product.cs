using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.csharp.Module4.Classes
{

    // bad example to if/else and violating the open/close prinicple
    class Product
    {
        decimal price;

        public Product()
        {
            price = 0;
        }
        decimal calculateDiscount(string customerType,int years)
        {
            // if else satements are one of the code smell 
            decimal discount = 0;
            if (customerType == "G")
            {

                discount = (price - Convert.ToInt32((price * (years / 100)))) - 20;
            }
            else if (customerType == "S")
            {
                discount = 20;
            }
            else if (customerType == "X")
                discount = 10;
            return discount;
        }
    }
}
