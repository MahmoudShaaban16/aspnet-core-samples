using System;

namespace ITShare.CSharp.Module2.ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = {3,6,7 };
            for(int i=0;i<=arr.Length;i++)
            {
                try
                {
                    // my own business logic

                    // validation logic

                    throw new CustomException() { ErrorCode = "203", SubErrorCode = "500" };

                   /// not to be handled
                }
                catch(IndexOutOfRangeException ex)
                {

                }
                catch(NullReferenceException ex)
                {
                    throw;
                }
                catch(Exception ex)
                {
                    throw;
                }

                finally
                {
                    // close connection or close the open file
                }
            }
        }
    }

    internal class Logger
    {
        internal static void Log(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
