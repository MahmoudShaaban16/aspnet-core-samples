using System;

namespace ITShare.csharp.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int age = 20, salary = 2000;
            //casting from integer to float
            float newSalary = (float)salary ;
            if(age>10)
            {
                Console.WriteLine(newSalary);

            }
        }
    }
}
