using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.Csharp.Module5
{
    public interface IModel<T> where T:class
    {
        List<T> List();
        void Add(T obj);
        void Update(T obj);
    }

    public class ProductsModel : IModel<ProductsModel>
    {
        public void Add(ProductsModel obj)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> List()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductsModel obj)
        {
            throw new NotImplementedException();
        }
    }
    public interface ICustomerModel:IModel<CustomersModel>
    {
        CustomersModel GetBy(int customerId);
    }
    public class CustomersModel :ICustomerModel
    {
        public string Name { get; internal set; }

        public void Add(CustomersModel obj)
        {
            throw new NotImplementedException();
        }

        public CustomersModel GetBy(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<CustomersModel> List()
        {
            throw new NotImplementedException();
        }

        public void Update(CustomersModel obj)
        {
            throw new NotImplementedException();
        }


    }
}
