using ITShare.CSharp.Module4.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.csharp.Module4.Classes
{
    partial class Customer
    {
        IClass1 c;
        public Customer(float de, IClass1 _c)
        {
            c = _c;
            
        }

        void doWhatClass1Does()
        {
            c.do1();
        }
    }
}
