using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.csharp.samples.LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentCollection sc = new StudentCollection();
            var students=sc.GenericGet((student) => student.Age > 20);
            sc.Update(x => x.Age >= 20,new Student());

        }
    }
}
