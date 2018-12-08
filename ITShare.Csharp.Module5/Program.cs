using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.Csharp.Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsModel p = new ProductsModel();
            p.Add(new ProductsModel());

            CustomersModel customer = new CustomersModel() { Name = "" };
            customer.GetBy(1);
        }
    }
}
