using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab01PlayerCounterApp.InsiteInternational
{
    internal class Player
    {
        //instance variables
        private string _name;
        private int _age;
        private static int _count;

        public Player(string name, int age) { 
            _name = name;
            _age = age;
            _count += 1;
            Console.WriteLine("player created(overlaod2)");
         
        }

        public Player(string name)
        {
            _name = name;
            _age = 20;
            _count += 1;
            Console.WriteLine("player created(overlaod1)");
        }

        public string Name { 
           get { return _name; }
        }

        public int Age { 
           get { return _age; }
        }

        public int Count {

            get {
               
                return _count;
            }
        }

        //static method can only access
        //static data
        //static method only accessed via classname
       //static method affinity ot static data
        public static int GetPlayerCount()
        {
            
            return _count;
        }

    }
}
