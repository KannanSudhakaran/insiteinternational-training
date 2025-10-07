namespace Lab01LamdaAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inline functions
            Func<int, int, double> addFn = (a,b) => {
                return a + b;
            };

            Console.WriteLine(addFn(10,20));


            Action<string, int> printName = (name,iter) => {
                for (int i = 1; i <= iter; i++) {
                    Console.WriteLine(i+" "+name.ToUpper());
                }
            };
            printName("Ghufran", 10);

         

        }

        static void CaseSTudy2() {

            Action<string, string> actionPtr;
            actionPtr = PrintDetails;
            actionPtr.Invoke("Kuzaimah", "Saudi");
            actionPtr.Invoke("Maged", "Saudi");
        }

        static void CaseStudy1() {

            Func<int, int, double> fncPtr1;//expects a function return double and 2input
            fncPtr1 = Mulitply;
            double result = fncPtr1(10, 5);
            Console.WriteLine(result);

        }

        static void PrintDetails(string name, string location) {

            Console.WriteLine("name is "+name);
            Console.WriteLine("locaiton is "+location);
        
        }
        static double Mulitply(int a, int b) { 
        
            return a * b;
        }
    }
}
