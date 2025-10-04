using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.InsiteInternaitonal
{
    internal class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man is departiing goodbye");
        }

        public void Wish()
        {
            Console.WriteLine("man says hello..to everyone");
        }
    }
}
