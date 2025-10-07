using Lab02AccountPolymorphism.InsiteInternational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndLINQ.ExtensionMethods
{
    static class AccountExtension
    {

        public static void PrintInfo(this IEnumerable<string> input)
        {

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

        }
        public static void PrintInfo(this Account input) {

            Console.WriteLine($"" +
                $"Accno is {input.Accno}" +
                $"Name is {input.Name}" +
                $"Balance is {input.Balance}" +
                $"");
        
        }
    }
}
