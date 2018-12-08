using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.csharp.Module4.Classes
{

    
    class LocalCar:Car
    {

        public string OfficalName { get { return name+"_marketName"; } set { name = value; } }
        public LocalCar():base("local",2000)
        {
           
        }

        public void Park()
        {
            // calling a function in the base class
            base.CalculateNumberofKM();
        }


    }
}
