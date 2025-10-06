using AccountPublisherLib.InsiteInternational;

namespace SaudiBankClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new Account(101, "Kuzaimah", "k@abc.om", 1000);
            var slackobj = new SlackNotification();
          
            //attaching event with hanlder(callback)
            acc1.OnBalanceUpdated += SendViberMessage;
            acc1.OnBalanceUpdated += SendEmail;
            acc1.OnBalanceUpdated += slackobj.Notify;
            // acc1.OnBalanceUpdated += Foo;

            //acc1.OnBalanceUpdated.Invoke(acc1);

            acc1.Deposit(2000);

            acc1.Withdraw(500);

        }



        //event handlers,callback  methods
        static void SendViberMessage(Account acc) {

            Console.WriteLine("sneding viber message");
            Console.WriteLine("for :"+acc.Name);
            Console.WriteLine("upated balance is "+acc.Balance);
        }

        static void SendEmail(Account acc) {

            Console.WriteLine("sending email");
            Console.WriteLine("for "+acc.Email);
            Console.WriteLine("updated balance"+acc.Balance);
        }

        

        static void Foo() { }
    }
}
