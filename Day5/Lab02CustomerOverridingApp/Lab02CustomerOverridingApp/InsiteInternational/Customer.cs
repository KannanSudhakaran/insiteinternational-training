using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02CustomerOverridingApp.InsiteInternational
{
    internal class Customer
    {
        //auto implemented property syntax
        private int _id;
        private string _name;

        public int Id
        {
            get
            {

                return _id;
            }
            set { _id = value; }
        }


        public string Name {

            get {
                return _name;
            }
            set { _name = value; }
        
        }

        //public int Id { get; set; }
        //public string Name { get; set; }

    
        public override string ToString()
        {
            string parentString = base.ToString();
            return $"custoemer is is {this.Id} and name is {this.Name} , parent value {parentString}";
        }



        public override bool Equals(object? box)
        {
           Customer second =   (Customer)box;

            return (this.Id == second.Id && this.Name == second.Name);
            
            
        }


    }
}
