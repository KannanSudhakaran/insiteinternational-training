using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03InterfaceApp.InsiteInternational
{
    internal class DepartmentDAL : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Dept created");
        }

        public void Delete()
        {
            Console.WriteLine("Dept deleted");
        }

        public void Read()
        {
            Console.WriteLine("Dept reading");
        }

        public void Update()
        {
            Console.WriteLine("Dept updated");
        }
    }
}
