using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01ConstructorInheritance.InsiteInternational
{
    internal class ChildTwo : ParentTwo
    {
        //hardcode age=20
        public ChildTwo():base(20) { 
        
        }

        public ChildTwo(int age) : base(age)
        {

        }
    }
}
