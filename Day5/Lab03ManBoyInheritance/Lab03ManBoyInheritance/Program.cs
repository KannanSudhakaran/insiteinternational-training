using Lab03ManBoyInheritance.InsiteInternational;

namespace Lab03ManBoyInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CaseStudy1();

            // CaseStudy2();

            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            Man x;//(IsA x expects man or subclasses or mans
            x = new Boy();

            x.Play();
            x.Read();
           
        }

        private static void CaseStudy2()
        {
            Boy y = new Boy();
            y.Play();
            y.Eat();
            y.Read();
            
        }

        private static void CaseStudy1()
        {
            Man x = new Man();
            x.Play();
            x.Read();
        }
    }
}
