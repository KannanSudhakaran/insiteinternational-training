using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndLINQ.ExtensionMethods
{
    static class StringExtension//step 1
    {
        //step2: create a static method ,with this pointer of string
        public static string MyHello(this string input) {

            return $"Hello {input}".ToUpper();
        }
    }
}
