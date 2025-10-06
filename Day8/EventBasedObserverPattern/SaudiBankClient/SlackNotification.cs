using AccountPublisherLib.InsiteInternational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudiBankClient
{
    internal class SlackNotification
    {

        public void Notify(Account account) {

            Console.WriteLine("sneding slacknotificaiton");
            Console.WriteLine("for account holder"+account.Name);
            Console.WriteLine("final balance is "+account.Balance);
        
        }
    }
}
