using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.csharp.Module4.Classes
{
    partial class Customer
    {

        protected int years;
        public Customer()
        {
            years = 0;
        }

        public virtual decimal calculateDiscount(decimal price)
        {
            int localDiscount(int x) {
                return x;
            }

            return localDiscount(2);

        }
    }

    class GoldCustomer : Customer
    {
        public override decimal calculateDiscount(decimal price)
        {

            return base.calculateDiscount(price) + (price - Convert.ToInt32((price * (years / 100)))) + 20;
        }
    }

    class SilverCustomer : Customer
    {
        public override decimal calculateDiscount(decimal price)
        {

            return base.calculateDiscount(price) + (price) + 3;
        }
    }
}
