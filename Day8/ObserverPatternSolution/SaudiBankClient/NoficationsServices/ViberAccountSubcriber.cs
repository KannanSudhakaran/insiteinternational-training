using AccountPublisherLib.InsiteInternational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudiBankClient.NoficationsServices
{
    internal class ViberAccountSubcriber : IAccountSubcriber
    {
        public void BalanceUpdate(Account account)
        {
            Console.WriteLine("connecting to viber network");
            Console.WriteLine("sending notifcaiton via viber to user"+account.Name);
            Console.WriteLine("upated balance "+account.Balance);
        }
    }
}
