using System;

namespace ITShare.CSharp.Module1.ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Switch Sample

            string name = "ali";
            string result = "";
            switch(name.Length)
            {
                case 1 : result = "is less than 20";break;
                case 2: result = "";break;

                
            }
        }
    }
}
