using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02AccountConstructor.InsiteInternational
{
    public class Account
    {
        //attributes or fields
        private int _accno;
        private string _name;
        private double _balance;

        //constructor
        public  Account(int accno,string name,double balance) { 
        
            _accno = accno;
            _name = name;
            _balance = balance;

        }

        //methods

        public void Deposit(double amount) {
            _balance += amount;
        }

        public void Withdraw(double amount) {

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


    }
}
