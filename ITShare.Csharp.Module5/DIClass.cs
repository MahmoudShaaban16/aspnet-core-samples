using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.Csharp.Module5
{
    
    public interface ICourse
    {
        List<string> courses { get; set; }
        void Add();
        List<string> GetCourseNames();
    }
    public class Course : ICourse
    {
        public List<string> courses { get; set; }
        public void Add()
        {
           
        }

        public List<string> GetCourseNames()
        {
            return new List<string>() { "Math","Science" };
        }
    }
    public class ITShareCourse : ICourse
    {
        public List<string> courses { get; set; }
        public void Add()
        {

        }

        public List<string> GetCourseNames()
        {
            return new List<string>() { "ASP.netCore", "Mean Stack" };
        }
    }
    //loosely coupled on ClassB,, remove it or add any class implement IClassX it will be valid
    class Student:IStudent
    {
       
        public ICourse iCourse;
        public Student(ICourse _x)
        {
            iCourse = _x;
        }
        public void Add(string courseName)
        {
            iCourse.courses.Add(courseName);
            
        }

        public int GetIndex()
        {
            return -1;
        }
    }

    internal interface IStudent
    {
        void Add(string courseName);

       int GetIndex();
        
    }
}
