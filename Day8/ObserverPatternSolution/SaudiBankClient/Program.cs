using AccountPublisherLib.InsiteInternational;
using SaudiBankClient.NoficationsServices;

namespace SaudiBankClient
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //publisher
            Account acc1 = new Account(101, "Kuzaimah", "k@gamil.com", 1000);

            
            
            
            //register the subcribers
            
            acc1.RegisterSubcriber(new EmailAccountSubcriber());
            acc1.RegisterSubcriber(new ViberAccountSubcriber());

            //change state of publisher
            acc1.Deposit(500);
            Console.WriteLine("end of main");

        }
    }
}
