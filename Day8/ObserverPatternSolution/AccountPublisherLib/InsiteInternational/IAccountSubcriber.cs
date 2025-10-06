using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPublisherLib.InsiteInternational
{
    public interface IAccountSubcriber
    {
        void BalanceUpdate(Account account);
    }
}
