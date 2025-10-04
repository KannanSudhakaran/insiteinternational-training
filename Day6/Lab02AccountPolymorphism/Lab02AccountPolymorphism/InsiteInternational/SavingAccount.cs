using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02AccountPolymorphism.InsiteInternational
{
    internal class SavingAccount:Account
    {
        private const int MIN_BALANCE = 1000;//magic no
        public SavingAccount(int accono,string name,double balance) :base(accono,name,balance)
        { 
        
        
        }
        public override void Withdraw(double amount)
        {
            if (_balance - amount < MIN_BALANCE) {
                //Exception exception = new Exception("no funds");
                //throw exception;

                throw new InsufficenFundsException(this);
            }
            _balance = _balance - amount;


        }
    }
}
