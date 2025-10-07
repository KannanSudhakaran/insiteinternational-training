

namespace Lab02SimpleDelegate
{
   // delegate void DPrintMessage(string name);

    internal class Program
    {
        static void Main(string[] args)
        {
            //Account acc1--> acc1 expects account object or subclasses of accoutn
            //ITransaction txn==> txn expects object of a class which implentents ITransaction
            //DSomeDelegate obj==> obj expects a function with same signature of delegate


            Casestudy1();

            // CasStudy2();


            // PrintWizard(PrintGoodBye);

           

        }


        //callback
        static void PrintWizard(Action<string> callBack) {

            Console.WriteLine("inside printing wizard");
            Console.WriteLine("doing printing opertonan..");
            Console.WriteLine("notifyonce its done");
            callBack.Invoke("PrintWizard");
        
        
        }
        private static void CasStudy2()
        {
            Action<string> fnPointer = PrintGoodBye;
            fnPointer += PrintHello;
            fnPointer += PrintGoodBye;

            fnPointer.Invoke("Maged");

        }

        private static void Casestudy1()
        {
            Action<string> fnPointer;// x expects a function with same signature of delegate
            fnPointer = PrintGoodBye;

            fnPointer.Invoke("Kuzaimah");
            fnPointer.Invoke("Maged");
        }

        static void PrintHello(string name) {
            Console.WriteLine($"Hello says {name}");
        }

        static void PrintGoodBye(string name) {
            Console.WriteLine($"Goodbye says {name}");
        }

        static void Foo() {
            Console.WriteLine("inside foo methods");
        }


    }
}
