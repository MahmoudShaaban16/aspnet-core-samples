using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ITShare.CSharp.Module1.Arrays
{
    class OddEvenClass
    {

        public int[] Odds()
        {
            int[] myArray = new int[] { 3,4};

            List<int> myResultArray = new List<int>();

            ArrayList array = new ArrayList();

            for(int i=0;i<myArray.Length;i++)
            {
                if(myArray[i]%2!=0)
                {
                    myResultArray.Add(myArray[i]);
                    Console.WriteLine($"this is an odd number {myArray[i]}");
                }
            }
            int len = myArray.Length;

            return myArray;

        }
    }
}
