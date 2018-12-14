using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.csharp.samples.LambdaExpressions
{
    class StudentCollection
    {
       
        List<Student> StudentList { get; set; }
        public delegate bool update(Student s);
        public StudentCollection()
        {
            StudentList = new List<Student>();
            StudentList.Add(new Student() { Name = "Mahmoud", Age = 20 });
            StudentList.Add(new Student() { Name = "Ahmed", Age = 40 });
        }
        public void Add(Student student)
        {
            StudentList.Add(student);
        }

        public List<Student> Get()
        {
            return StudentList;
        }
        public List<Student> Get(int age)
        {
            Func<Student, bool> filterfunction = (s) => { return s.Age == age;
            };
            return StudentList.Where(filterfunction).ToList();
        }
        public List<Student> Get(int age,string name)
        {
            return StudentList.Where(x => x.Name == name).ToList();

        }
        public List<Student> Get(string name)
        {
            return StudentList.Where(x => x.Name == name).ToList();
        }

        public bool Update(Func<Student,bool> updateFN,Student s)
        {
           
            return updateFN(s);
        }
        
        public List<Student> GenericGet(Func<Student,bool> filter)
        {
            List<Student> filteredList = new List<Student>();
            foreach(Student s in StudentList)
            {
                if(filter(s))
                {
                    filteredList.Add(s);
                }

            }
            return filteredList;
        }
    }

    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        
    }
}
