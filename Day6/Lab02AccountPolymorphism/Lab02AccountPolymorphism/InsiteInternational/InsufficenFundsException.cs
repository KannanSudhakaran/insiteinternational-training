using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02AccountPolymorphism.InsiteInternational
{
    internal class InsufficenFundsException :Exception
    {
        private Account _account;
        public InsufficenFundsException(Account account) { 
        
            _account = account; 
        }

        public override string Message {
            get {

                return "WorldBank says dear " + _account.Name + ",your account " + _account.Accno + "does seem to have enoguh fund";
            }
        
        }

    }
}
