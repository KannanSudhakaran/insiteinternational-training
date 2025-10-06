using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPublisherLib.InsiteInternational
{
    //callabck method singature
    public delegate void BalanceUpdated(Account acc);
    public class Account
    {
        private int _accno;
        private string _name;
        private string _email;
        private double _balance;

        public event BalanceUpdated OnBalanceUpdated = null;

        public Account(int accno, string name, string email, double balance)
        {
            _accno = accno;
            _name = name;
            _email = email;
            _balance = balance;

            Console.WriteLine("account created");
        }

     

        public void Deposit(double amount)
        {

            _balance += amount;
            if (OnBalanceUpdated != null)//subcribers are registered
            {
                //fire the event
                OnBalanceUpdated.Invoke(this);
            }
          

        }

        public void Withdraw(double amount)
        {

            if (_balance - amount < 500)
            {
                throw new Exception("no funds");
            }
            _balance = _balance - amount;//state changes
            if (OnBalanceUpdated != null) {
                OnBalanceUpdated.Invoke(this);
            }
           

        }

        public string Name { get { return _name; } }
        public string Email
        {
            get
            {
                return _email;
            }
        }
        public double Balance { get { return _balance; } }

        public int AcconNo { get { return _accno; } }

    }
}
