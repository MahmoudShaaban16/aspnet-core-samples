using System;

namespace ITShare.CSharp.Module1.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OddEvenClass m = new OddEvenClass();
            m.Odds();
            //int[] degrees = new int[]{2,4,5 };
            //int sumOfDegrees = 0;
            //for(int i=0;i<degrees.Length;i++)
            //{
            //    sumOfDegrees=sumOfDegrees+ degrees[i];
            //}
            //sumOfDegrees = 0;
            //// foreach 
            //foreach(int degree in degrees)
            //{
            //    sumOfDegrees = sumOfDegrees + degree;
            //}
            //Console.WriteLine(sumOfDegrees);


            //sumOfDegrees = 0;
            //int arrIndex = 0;
            //do
            //{
            //    sumOfDegrees += degrees[arrIndex];
            //    arrIndex = arrIndex + 1;// or arrIndex++

            //}while(!(degrees[arrIndex]< 20));
            //Console.WriteLine(sumOfDegrees);
        }
    }
}
