using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03ManBoyInheritance.InsiteInternational
{
    internal class Boy : Man
    {
        public override void Play()
        {
            Console.WriteLine("Boy is playing..");
        }

        public void Eat() {

            Console.WriteLine("boy is eating..");
        }

    }
}
