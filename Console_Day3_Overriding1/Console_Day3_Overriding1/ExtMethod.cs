using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Day3_Overriding1
{
   static class ExtMethod
    {
        public static void NewEmployeeMethod(this Employee e,string str)
        {
            Console.WriteLine("this is ext method"+ str);
        }

    }
}
