using IEnumerableAndLINQ.ExtensionMethods;
using Lab02AccountPolymorphism.InsiteInternational;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

            List<Account> accounts = new List<Account>();
            accounts.Add(new Account(101,"kannan",1000));
            accounts.Add(new Account(102, "keonig", 2000));
            accounts.Add(new Account(103, "Maged", 3000));
            accounts.Add(new Account(104, "Ghufran", 4000));

            //write linq query to get top 2 rich accounts

            var richAccounts = accounts.OrderByDescending(a => a.Balance)
                                      .Take(2)
                                      .ToList();

            richAccounts.ForEach(a => a.PrintInfo());

            var selctedAccounts = accounts.
                                  Select(a =>
                                  new
                                  {
                                      a.Name,
                                      a.Balance

                                  })
                                  .Where(a=>a.Name.Contains("a"))
                                  .ToList();

            selctedAccounts.ForEach(a => Console.WriteLine(a));
            //  Console.WriteLine(selctedAccounts);

            Account acc1 = new Account(101, "abc", 2000);
            Console.WriteLine(acc1);

        }

        private static void CaseStudy4() {

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
