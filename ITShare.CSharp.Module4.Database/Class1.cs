using System;

namespace ITShare.CSharp.Module4.Database
{
    public class Class1:IClass1
    {
        public int age { get; set; }

        public void do1()
        {

        }
        public void do2()
        {

        }

        public void do2(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

   public interface IClass1
    {
        int age { get; set; }
        void do1();
        void do2(int x,int y);
       
    }
    public interface IDatabase
    {
        void saveToDatabase();
    }
    public class MyClass : IClass1,IDatabase
    {
        public int age { get; set; }

        public void do1()
        {
            
        }

        public void do2(int x, int y)
        {
            
        }

        public void saveToDatabase()
        {
            throw new NotImplementedException();
        }
    }

}
