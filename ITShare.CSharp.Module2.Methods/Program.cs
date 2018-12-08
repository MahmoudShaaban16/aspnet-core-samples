using System;
using static ITShare.CSharp.Module2.Methods.ShoppingCart;

namespace ITShare.CSharp.Module2.Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /// example for output parameters
            ShoppingCart c = new ShoppingCart();
            string productName;
            decimal price;
            c.GetOutputParams(20, out productName, out price);

            ValueTuple<int, string, decimal> myTuple = c.ReturnUsingTuple();
            // reading the integer value at the tuple

            //Console.WriteLine($"product name is {productName}, price is {price}");
            //Console.WriteLine(logMessage(price:20,name:"this is a new message",number:30));

            /// calling using params keyword sample
            ///
           // c.DoParams(20, 40, 40);


            //calling a method with decimal parameter

            decimal p = 70;
            
            c.GetItemDetails(20, ref p);
            Console.WriteLine(p);
            Func<int,int> add = y => y + 2;
          
            c.HandleSumDynamically(add);
            
          
        }

        private static string logMessage(int number, float price, string name = "this is a default")
        {
            return name;
        }
    }
}