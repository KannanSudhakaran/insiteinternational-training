using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02AccountPolymorphism.InsiteInternational
{
   
    internal  class Account
    {
        private int _accno;
        private string _name;
        protected double _balance;//child can modify

        public Account(int accno, string name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }

        public void Deposit(double amount) {
            _balance += amount;
        }

        public void Withdraw(double amount) {
            _balance = _balance - amount;
        }

        public int Accno { get { return _accno; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }

        public override string ToString()
        {
            return $"id {this.Accno} name is {this.Name}";
        }

    }
}
