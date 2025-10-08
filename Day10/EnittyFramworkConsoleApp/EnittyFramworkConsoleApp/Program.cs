using EnittyFramworkConsoleApp.Data;
using EnittyFramworkConsoleApp.Model;
using Microsoft.EntityFrameworkCore;

namespace EnittyFramworkConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var db = new InsiteDbContext();

            var kannan = db.Customers
                           .Single(c => c.Id == 1);

            var o1 = new Order { Name = "pen", Price = 100 };

            kannan.Orders.Add(o1);

            db.SaveChanges();

           
          

            
        }

        private static void CaseStudy2()
        {
            var db = new InsiteDbContext();
            var customers = db.Customers
                 .Include(c => c.Orders)
                 .ToList();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Address);

                foreach (var order in customer.Orders)
                {

                    Console.WriteLine(order.Name);
                    Console.WriteLine(order.Price);
                }
            }

        }

        private static void CaseStudy1()
        {
            var db = new InsiteDbContext();

            var c1 = new Customer { Name = "kannan", Address = "mumbai" };
            var o1 = new Order { Name = "books", Price = 100 };
           
            c1.Orders.Add(o1);

            db.Customers.Add(c1);

            db.SaveChanges();
        }
    }
}
