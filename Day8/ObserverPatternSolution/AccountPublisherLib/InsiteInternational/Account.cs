using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPublisherLib.InsiteInternational
{
    //publisher
    public class Account
    {
        private int _accno;
        private string _name;
        private string _email;
        private double _balance;

        //list of subcribbers
        private List<IAccountSubcriber> _subcribers = null;
        public Account(int accno, string name, string email, double balance)
        {
            _accno = accno;
            _name = name;
            _email = email;
            _balance = balance;
            _subcribers = new List<IAccountSubcriber>();

            Console.WriteLine("account created");
        }

        public void RegisterSubcriber(IAccountSubcriber subcriber)
        {
            _subcribers.Add(subcriber);
        }

        public void Deposit(double amount)
        {

            _balance += amount;
            //nofity all  the subcribers
            foreach (IAccountSubcriber subscriber in _subcribers)
            {
                subscriber.BalanceUpdate(this);
            }

        }

        public void Withdraw(double amount)
        {

            if (_balance - amount < 500)
            {
                throw new Exception("no funds");
            }
            _balance = _balance - amount;//state changes
            foreach (IAccountSubcriber subcriber in _subcribers)
            {

                subcriber.BalanceUpdate(this);
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
