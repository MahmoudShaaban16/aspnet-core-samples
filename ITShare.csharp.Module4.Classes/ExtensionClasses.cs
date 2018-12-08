using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.csharp.Module4.Classes
{
    public static class CallCollectionReverse
    {
        public static Car[] ReverseCars(this CarCollection x)
        {
            return x.GetAllNewCars().Reverse().ToArray();
        }
    }


}
