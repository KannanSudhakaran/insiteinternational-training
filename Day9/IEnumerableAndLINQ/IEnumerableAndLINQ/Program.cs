using IEnumerableAndLINQ.ExtensionMethods;
using Lab02AccountPolymorphism.InsiteInternational;
using System;
using System.Collections.Generic;
using System.Linq;


namespace IEnumerableAndLINQ
{
    static class Temp {

        public static void Print(this string name) {
            Console.WriteLine(name);
        }
        public static string MyHello2(this string input)
        {

            return $"Hello2 {input}".ToUpper();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            IEnumerable<string> names;// expects object of class which implent IEnuerable
            names = new string[] { "kannan", "koenig limited", "insite inernational", "maged", "ghufran" };
            names.PrintInfo();


        }

        private static void CaseStudy3()
        {
            string name = "INsite";


            Console.WriteLine(name.MyHello());

            var acc1 = new Account(101, "kannan", 1000);
            acc1.PrintInfo();
        }

        private static void CaseStudy2()
        {
            IEnumerable<string> names;// expects object of class which implent IEnuerable
            names = new string[] { "kannan", "koenig limited", "insite inernational", "maged", "ghufran" };

            var orderedNames = names.OrderByDescending(n => n.Length);

            foreach (var name in orderedNames)
            {
                Console.WriteLine(name);
            }

           
        }

        static void CaseSTudy1() {

            IEnumerable<string> names;// expects object of class which implent IEnuerable
            names = new string[] { "kannan", "koenig", "insite", "maged", "ghufran" };

            //syntatic sugar on enumerator
            foreach (string temp in names)
            {

                Console.WriteLine(temp.ToUpper());
                Console.WriteLine(temp);

            }

            Console.WriteLine("using get enumerator");
            IEnumerator<string> cursor = names.GetEnumerator();
            while (cursor.MoveNext())
            {
                Console.WriteLine(cursor.Current.ToUpper());
            }

        }
    }
}
