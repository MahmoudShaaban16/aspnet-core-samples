using ITShare.CSharp.Module4.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.csharp.Module4.Classes
{
    class Program
    {

        static void Main(string[] args)
        {

            Car bmw = new Car("BMW", 2000, "small");
            // for setting only values
            bmw.CarState = "On";
            bmw.CalculateNumberofKM();

            Car volvo = bmw;
            volvo.Name = "volvo";

            Console.WriteLine(bmw.Name);

            // true or fasle
            Console.WriteLine(bmw == volvo);

            Car volvo2 = new Car();
            volvo2.Name = bmw.Name;


            Console.WriteLine(volvo2.Equals(bmw));

            CarCollection exhibition = new CarCollection();
            exhibition.ReverseCars();
            Car firstCarToBePurshaed = exhibition[0];

            LocalCar lCar = new LocalCar();

            // polymorphism example

            Customer silverCustomer = new SilverCustomer();
            Customer goldCustomer = new GoldCustomer();

            Console.Write(silverCustomer.calculateDiscount(200) == goldCustomer.calculateDiscount(200));

            Customer c = new Customer(20, new MyClass());

            Car[] cars = { new Car() { Name = "mercedes",KM=5000 }, new Car() { Name = "hundai" , KM =400}, new Car() { Name = "volvo", KM=3 } };


            List<Car> lstCars = cars.ToList();
            lstCars.Sort();
            Console.WriteLine(lstCars[2].KM);


        }
    }
}
