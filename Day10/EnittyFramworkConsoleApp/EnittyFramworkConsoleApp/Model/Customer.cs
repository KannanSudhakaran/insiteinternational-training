using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnittyFramworkConsoleApp.Model
{
    internal class Customer
    {
        //will create primry  keys
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public  List<Order> Orders { get; set; }= new List<Order>();


    }
}
