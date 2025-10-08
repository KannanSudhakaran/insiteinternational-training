using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnittyFramworkConsoleApp.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public Customer Customer { get; set; }

       
    }
}
