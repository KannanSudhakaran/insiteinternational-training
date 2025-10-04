using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03InterfaceApp.InsiteInternational
{
    internal class EmployeeDAL : ICrudable
    {
        //crlt + L ==> line delete
        public void Create()
        {
            Console.WriteLine("Employee crated");
        }

        public void Delete()
        {
            Console.WriteLine("Employee deleted");
        }

        public void Read()
        {
            Console.WriteLine("Employee reading");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated");
        }
    }
}
