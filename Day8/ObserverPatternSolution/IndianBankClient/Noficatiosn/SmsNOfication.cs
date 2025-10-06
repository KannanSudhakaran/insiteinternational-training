using AccountPublisherLib.InsiteInternational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianBankClient.Noficatiosn
{
    internal class SmsNOfication : IAccountSubcriber
    {

        public SmsNOfication() {

            Console.WriteLine("sms created");
        }
        public void BalanceUpdate(Account account)
        {
            Console.WriteLine("sms notifcation initalited for "+account.Name);
            Console.WriteLine("balance  is "+account.Balance);
        }
    }
}
