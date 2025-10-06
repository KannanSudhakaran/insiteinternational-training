namespace Lab03MathDelegate
{
    internal class Program
    {
        delegate void MyDMath(int a, int b);
        static void Main(string[] args)
        {
            //lamda function
            //MyDMath x = (a, b) =>
            //{

            //    Console.WriteLine($"{a} / {b} = {a / b}");
            //};

            // x(100, 5);

            CaseSTudy1();

        }

        static void CaseSTudy1() {

            MyDMath x = Add;
            x += Sub;
            x += Mul;
            x(10, 2);


        }

        static void Add(int a, int b) {

            Console.WriteLine($"{a}+{b}={a+b}");
        }
        static void Sub(int a, int b)
        {

            Console.WriteLine($"{a}-{b}={a - b}");
        }

        static void Mul(int a, int b)
        {

            Console.WriteLine($"{a}*{b}={a * b}");
        }
    }
}
