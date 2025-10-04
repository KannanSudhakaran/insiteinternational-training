using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02AccountPolymorphism.InsiteInternational
{

    // 2 errors
    internal class CurrentAccount:Account
    {
        private const int OVER_DRAFT = -5000;
        public CurrentAccount(int accono,string name,double balance)
            :base(accono,name, balance)
        { 
        
        }
        public override void Withdraw(double amount)
        {
            if (_balance - amount < OVER_DRAFT)
            {
                //Exception ex = new Exception("below over drawft");
                //throw ex;

                throw new InsufficenFundsException(this);
            }
            _balance = _balance - amount;
        }

    }
}
