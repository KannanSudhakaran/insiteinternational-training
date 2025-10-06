using AccountPublisherLib.InsiteInternational;
using IndianBankClient.Noficatiosn;

namespace IndianBankClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new Account(102, "kannan", "k@gamil.com", 500);
            acc1.RegisterSubcriber(new SmsNOfication());
            acc1.RegisterSubcriber(new TelegramNofication());

            acc1.Deposit(5000);
            Console.WriteLine() ;
            acc1.Withdraw(1000);
            Console.WriteLine();
            acc1.Deposit(500);
        }
    }
}
