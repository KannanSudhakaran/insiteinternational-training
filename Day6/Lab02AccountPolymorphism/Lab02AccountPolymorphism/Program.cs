using Lab02AccountPolymorphism.InsiteInternational;

namespace Lab02AccountPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1; //(ISA) acc1 expects object of Current or Saving
            acc1  = new SavingAccount(101, "Kuzaimah", 1000);
            PrintBalanceSlip(acc1);


            Account acc2 = new CurrentAccount(102, "Kannan", 400);
            PrintBalanceSlip(acc2);


            try
            {
                acc2.Withdraw(5401);

            }
            //exceptions are polymorphic
            catch (InsufficenFundsException ex)
            {

            }
            catch (Exception ex)
            {
                // (ISA)

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                // Console.WriteLine(ex.StackTrace);

                Console.ResetColor();
            }

         


            PrintBalanceSlip(acc2);

            Console.WriteLine("end of main");
        }


        static void PrintBalanceSlip(Account account) {

            Console.WriteLine("Printing balance slipt pls..wait..");
            Console.WriteLine("balance is " + account.Balance);
            Console.WriteLine("accno is " + account.Accno);
            Console.WriteLine("name is" + account.Name);
            Console.WriteLine();
        }


    }
}
