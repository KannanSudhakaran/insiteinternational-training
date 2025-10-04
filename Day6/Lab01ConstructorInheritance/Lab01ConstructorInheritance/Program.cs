using Lab01ConstructorInheritance.InsiteInternational;

namespace Lab01ConstructorInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new ChildOne();

            ChildTwo c1= new ChildTwo(30); // 30
            ChildTwo c2 = new ChildTwo(50); //50

            Console.WriteLine(c1.Age); //30
            Console.WriteLine(c2.Age); //50


        }
    }
}
