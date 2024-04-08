using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStudent.Extension
{
    static class Helper
    {
       public static string Capitalize(this string str)
        {
           return str = str.Substring(0,1).ToUpper()+str.Substring(1).ToLower();
        }

    }
}
