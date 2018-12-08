using System;

namespace ITShare.CSharp.Module1.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            for(int i=0;i<100;i++)
            {
               
                if(i==20)
                {
                    Console.WriteLine($"inside loop with index 20");
                    continue;

                }

                
                int y = (i++);
                Console.WriteLine(y);
            }

            Console.WriteLine("Outside the loop");
        }
    }
}
