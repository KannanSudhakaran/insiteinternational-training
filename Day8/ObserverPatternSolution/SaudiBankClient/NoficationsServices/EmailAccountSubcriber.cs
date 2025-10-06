using AccountPublisherLib.InsiteInternational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudiBankClient.NoficationsServices
{
    internal class EmailAccountSubcriber : IAccountSubcriber
    {
        public void BalanceUpdate(Account account)
        {
            Console.WriteLine("sending mail notfications to customer"+account.Name);
            Console.WriteLine("email send to " + account.Email);
            Console.WriteLine("banced changed to" + account.Balance);
        }
    }
}
