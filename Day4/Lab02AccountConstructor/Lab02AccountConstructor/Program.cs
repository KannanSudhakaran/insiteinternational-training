using Lab02AccountConstructor.InsiteInternational;

namespace Lab02AccountConstructor
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            // CaseStudy2();
            Account one = new Account(1, "a", 100); 
            Account two = new Account(2, "b", 200); 
            Account third = new Account(3, "c", 300);

            Account[] manyAccounts = new Account[3];
            manyAccounts[0] = one;
            manyAccounts[1] = two;
            manyAccounts[2] = third;

            foreach (Account temp in manyAccounts) {
                PrintInfo(temp, "");
             }





        }

        private static void CaseStudy2()
        {
            Account acc1 = new Account(1003, "Kuzaimah", 4000);
            PrintInfo(acc1, "acc1 object");


            Account acc2 = new Account(1004, "kannan", 1000);
            PrintInfo(acc2, "acc2");


            Account rich = acc2.WhoIsRich(acc1);//WhoIsRicher(acc1,acc2);
            PrintInfo(rich, "richest accoutn details");
            Console.WriteLine(rich == acc2);
        }

        private static void CaseStudy1()
        {
            Account acc1 = new Account(1001, "Kuzaimah", 3000);
            Console.WriteLine(acc1.GetHashCode());
            PrintInfo(acc1, "acc1 object");

            acc1.Deposit(1000);
            PrintInfo(acc1, "after deposit");

            try
            {
                acc1.Withdraw(5000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            PrintInfo(acc1, "after withdraw");


            Account acc2 = new Account(102, "kannan", 2000);
            PrintInfo(acc2, "acc2");


            Console.WriteLine("End of main");
        }

        private static void PrintInfo(Account account,string details) {

            Console.WriteLine();
            Console.WriteLine($"printing info of {details} ");
            Console.WriteLine($"hashcode is {account.GetHashCode()}");
            Console.WriteLine($"name is {account.Name}");
            Console.WriteLine($"balance is {account.Balance}");
            Console.WriteLine($"Accno is {account.AccountNo}");

        }
    }
}
