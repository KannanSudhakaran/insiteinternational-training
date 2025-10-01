using Lab03ManBoyInheritance.InsiteInternational;

namespace Lab03ManBoyInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            // CaseStudy2();

            //CaseStudy3();

            CaseStudy4();
        }

        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Toddler());
            AtThePark(new Infant());
        }

        static void AtThePark(Man x)//polymorphic method { 
        {
            Console.WriteLine("At the park..");
            x.Play();
        }
        private static void CaseStudy3()
        {
            Man x=null;//(IsA x expects man or subclasses or mans
            x = new Boy();

            x.Play();
            x.Read();
           
           
        }

        private static void CaseStudy2()
        {
            Boy y = new Boy();
            y.Eat();
            y.Play();
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
