using AccountPublisherLib.InsiteInternational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianBankClient.Noficatiosn
{
    internal class TelegramNofication : IAccountSubcriber
    {
        public TelegramNofication() {
            Console.WriteLine("telegram created");
        }
        public void BalanceUpdate(Account account)
        {
            Console.WriteLine("sending nofication via telgraom");
            Console.WriteLine("for account holder"+account.Name);
            Console.WriteLine("final balcnie is"+account.Balance);
        }
    }
}
