using System;

namespace ITShare.CSharp.Module2.Methods
{
    // struct for returning multiple values in the same return of a function
    internal struct ReturnOfFunction
    {
        public string name;
        public string address;
        public int count;
    }

    internal struct InputOfFunction
    {
        public string name;
        public string address;
        public int count;
    }

    internal class ShoppingCart
    {
        // a method without a return
        // a method name should be short and verbal
        public int ClearShoppingCart(int shoppingCartId, string name, string addr)
        {
            Console.WriteLine($"clear shopping cart:{shoppingCartId}");
            return 0;
        }

        /// <summary>
        ///  default way to return multiple values of a function
        /// </summary>
        ///
        /// <returns></returns>
        private ReturnOfFunction returnMultipleValues()
        {
            ReturnOfFunction fn = new ReturnOfFunction();
            fn.address = "Cairo, Egypt";
            fn.count = 20;
            fn.name = "my shopping cart";
            return fn;
        }

        /// <summary>
        ///  using output parameters
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        ///
        public void GetOutputParams(int productId, out string productName, out decimal price)
        {
            
            
            productName = "Milk";
            price = 15;
        }

        // defining a function takes parameters as an object or a structur

        private void doTakeObjectParameter(InputOfFunction myInput)
        {
        }

        private decimal calculateTotalGold(int[] productQuantities, decimal[] prices)
        {
            decimal total = 0;
            total = SumOfProducs(productQuantities, prices, total);

            total = total - (total * 20 / 100);
            return total;
        }
        
        private static decimal SumOfProducs(int[] productQuantities, decimal[] prices, decimal total)
        {
            for (int i = 0; i <= productQuantities.Length; i++)
            {
                total += productQuantities[i] * prices[i];
            }

            return total;
        }

        private decimal calculateTotalPremium(int[] productQuantities, decimal[] prices)
        {
            decimal total = 0;
            total = SumOfProducs(productQuantities, prices, total);

            total = total - (total * 20 / 100);
            return total;
        }

        /// defining a function and using the params keyword
        /// <summary>
        /// Return multiple values using ValueTuples
        /// </summary>

        /// <returns></returns>
        ///

        public void DoParams(params int[] myParameters)
        {
        }
         
        public ValueTuple<int, string, decimal> ReturnUsingTuple()
        {
            return (20, "shopping cart", 500);
        }

        private int? getLength(int? arr = 0)
        {
            int? ret = null;
            //using expression
            //int y = ret != null ? ret.Value : 0;

            int x = 0;
            x = NewMethod(arr, x);
            return ret;
        }

        private static int NewMethod(int? arr, int x)
        {
            if (arr != null)
            {
                x = 2;
            }

            return x;
        }

        // an overloaded method of clearShoppingCart but with different parameter

        private void ClearShoppingCart(int[] Id)
        {
            Console.WriteLine($"clear shopping cart with an array");
        }

        // you can use params to pass any number of product Ids
        private void AddItems(int shopppingCartId, params int[] productIds)
        {
            foreach (int productId in productIds)
            {
                Console.Write(productId);
            }
        }

        // a method with a return type
        private int GetItemsCount()
        {
            return 5;
        }

        // GetItemsCount can be like
        private int count = 0;

        private int GetCount() => count;

        // you can create a function with optional parameters
        public void AddNewItem(string name = "Meat", decimal price = 25, decimal vat = 10)
        {
        }

        // Creating a function with out parameters

        private void GetLatestProduct(out int productId, out string productName)
        {
            productId = 20;
            productName = "TVs";
        }
        private void GetLatestProduct(out int productId, out string productName,int discountRate)
        {
            productId = 20;
            productName = "TVs";
        }
        // Creating a function with ref parameters

        public void GetItemDetails(int productId, ref decimal price)
        {
            if(price==0)
            {
                price = 40;
            }

            price++;
        }

        public void CalculateTax()
        {
            void internalFunction()
            {
                Console.Write("this is a console from internal function");

            }
            internalFunction();
        }

        // delegates

         public delegate int Add(int x);

        public int HandleSumDynamically(Func<int,int> add)
        {
            return add(2)+2;
        }
    }
}