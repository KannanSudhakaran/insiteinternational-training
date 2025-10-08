using Microsoft.AspNetCore.Mvc;
using System.Text;
using WelcomeMVCApp.Models;

namespace WelcomeMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> list = new List<Customer>();
            list.Add(new Customer { Id=1, Name="Ghufran",Address="Saudi" });
            list.Add(new Customer { Id = 2, Name = "Kuzaimah", Address = "Saudi" });

            StringBuilder output= new StringBuilder();

            foreach (Customer customer in list)
            {
                output.Append($"<h1> {customer.Name} </h1>");
            }


            return Content(output.ToString(),"text/html");

        }
    }
}
