using Lab01PlayerCounterApp.InsiteInternational;
using System.Runtime.CompilerServices;

namespace Lab01PlayerCounterApp
{
    internal class Program
    {
        //int foo = 100;//instance variable
        //static int bar = 200;
        static void Main(string[] args)
        {
           
           
            CaseStudy1();

            //static method

            Player p1 = new Player("A");
            Player p2 = new Player("B");
            Player p3 = new Player("B");

            Console.WriteLine(Player.GetPlayerCount());





        }

        private static void CaseStudy1()
        {
            Player p1 = new Player("Maged");
            PrintInfo(p1, "p1 object");

            Player p2 = new Player("kannan", 30);
            PrintInfo(p2, "p2 object");

            Player p3 = new Player("Kuzaimah", 30);
            PrintInfo(p3, "p3 object");
        }

        static void PrintInfo(Player p, string additionalDetails) {

            Console.WriteLine(additionalDetails);
            Console.WriteLine("age is "+p.Age+ "name is "+p.Name);
            Console.WriteLine("counter is " + p.Count);
            Console.WriteLine();

        }
    }
}
