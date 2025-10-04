using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01ConstructorInheritance.InsiteInternational
{
    internal class ParentTwo
    {
        private int _age;
        public ParentTwo(int age) { 
        
            _age = age;
        }

        public int Age { 
          get { return _age; }
        }
    }
}
