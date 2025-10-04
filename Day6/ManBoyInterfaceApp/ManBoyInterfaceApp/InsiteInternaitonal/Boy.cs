using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.InsiteInternaitonal
{
    internal class Boy : IMannerable, IEmotionable
    {
        
        public void Cry()
        {
            Console.WriteLine("boy is crying..");
        }

        public void Depart()
        {
            Console.WriteLine("boy is departnig.bye..");
        }

        public void Laugh()
        {
            Console.WriteLine("boy is laughing..");
        }

        public void Wish()
        {
            Console.WriteLine("boy is wishing..hello..");
        }
    }
}
