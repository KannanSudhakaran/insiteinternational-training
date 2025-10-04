using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03InterfaceApp.InsiteInternational
{
    internal class CustomerDAL : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("customer created");
        }

        public void Delete()
        {
            Console.WriteLine("customer deleted");
        }

        public void Read()
        {
            Console.WriteLine("customer data reading");
        }

        public void Update()
        {
            Console.WriteLine("customer updating");
        }
    }
}
