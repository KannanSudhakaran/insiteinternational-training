using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02AccountConstructor.InsiteInternational
{
    public class Account
    {
        //attributes or fields or instance variable
        private int _accno;
        private string _name;
        private double _balance;

        //constructor

        //local variables
        public Account(int _accno, string _name, double _balance)
        {

           this._accno = _accno;
           this._name = _name;
           this._balance = _balance;
            Console.WriteLine();
            Console.WriteLine("inside constructor");
            Console.WriteLine(this.GetHashCode());

        }
        //public  Account(int accno,string name,double balance) { 

        //    _accno = accno;
        //    _name = name;
        //    _balance = balance;

        //}

        //methods

        public void Deposit(double amount) {
            _balance += amount;
        }

        public void Withdraw(double amount) {
            if (_balance-amount<500)
            {
                Exception ex = new Exception("no funds,min bal is 500");
                throw ex;

            }
            _balance = _balance - amount;
        }

        public int AccountNo { 
          get { return _accno; }
        }

        public string Name {
            get {
                return _name;
            }
        }

        public double Balance { 
           get { return _balance; }
        }

        public Account WhoIsRich(Account second) {

            if (second.Balance > this.Balance)
                return second;
            else
               return this;


        }

    }
}
