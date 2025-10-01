using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03ManBoyInheritance.InsiteInternational
{
    internal class Man
    {

        //can be overriden in child
        public virtual void Play() {
            Console.WriteLine("Man is playing..");
        }

        public void Read() {

            Console.WriteLine("Man is reading");
        }

    }
}
