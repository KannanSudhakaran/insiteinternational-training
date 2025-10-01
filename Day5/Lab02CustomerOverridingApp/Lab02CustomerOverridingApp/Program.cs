using Lab02CustomerOverridingApp.InsiteInternational;

namespace Lab02CustomerOverridingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            Customer c1 = new Customer { Name="Kuzaimah", Id=1 };
            Customer c2 = new Customer { Name = "Kuzaimah", Id = 1 };

            Customer c3 = c1;

            Console.WriteLine(c3==c1);

            Console.WriteLine(c1==c2);
            Console.WriteLine(c1.Equals(c2)) ;
        }

        private static void CaseStudy1()
        {
            //property initilazliation sytnax ,without constructor
            Customer c1 = new Customer
            {

                Name = "Kannan",
                Id = 1
            };

            Console.WriteLine(c1);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c1.GetType());
        }
    }
}
