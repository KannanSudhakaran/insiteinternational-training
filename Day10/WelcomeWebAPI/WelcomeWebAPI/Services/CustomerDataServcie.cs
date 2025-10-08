using WelcomeWebAPI.Models;

namespace WelcomeWebAPI.Services
{
    public class CustomerDataServcie
    {

        public List<Customer> GetCustomerData() {

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { Id = 1, Name = "Ghufran" });
            customers.Add(new Customer { Id = 2, Name = "Kuzahimah" });

            return customers;

        }
    }
}
