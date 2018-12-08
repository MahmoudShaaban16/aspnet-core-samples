using System;
using System.Collections.Generic;

namespace ITShare.CSharp.Module3.Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var number in oddNumbers(1,10))
            {
                Console.WriteLine(number);
            }
        }

        private static IEnumerable<int> oddNumbers(int first, int last)
        {
            for(int i=first;i<=last;i++)
            {
                if(i%2!=0)
                {
                    yield return i;
                }
            }
        }
    }
}
