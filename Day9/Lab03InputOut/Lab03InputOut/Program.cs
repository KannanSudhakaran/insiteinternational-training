

using System;
using System.IO;
using System.Text;

namespace Lab03InputOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  CaseStudy1();

            // CaseStudy2();

            //CaseStudy3();

            CaseStudy4(args);
        }

        private static void CaseStudy4(string[] args)
        {
            if (args.Length == 1)
            {
                string filePath = args[0];

                StreamReader sr = new StreamReader(filePath);

                Console.WriteLine(sr.ReadToEnd());
                sr.Close();

            }
            else
            {
                Console.WriteLine("pass a file path");
            }
        }

        private static void CaseStudy3()
        {
            // string filePath = @"C:\LiveSessionKoenig\Csharp_InsiteIntl_training\Day1\Lab01WelcomeApp\Lab01WelcomeApp\Welcome.cs";
            Console.WriteLine("enter the file path");
            string filePath= Console.ReadLine();

            StreamReader sr = new StreamReader(filePath);

            Console.WriteLine(sr.ReadToEnd());
            sr.Close();

        }

        private static void CaseStudy2()
        {
            StringBuilder htmlcontent = new StringBuilder();
            htmlcontent.Append("<html>");
            htmlcontent.Append("<body>");
            htmlcontent.Append("<h1>");
            htmlcontent.Append("C# says hello to HTML !!");
            htmlcontent.Append("</h1>");
            htmlcontent.Append("</body>");
            htmlcontent.Append("</html>");
            Console.WriteLine(htmlcontent);

            string filePath = @"C:\LiveSessionKoenig\Csharp_InsiteIntl_training\welcome.html";
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            writer.Write(htmlcontent.ToString());
            
            writer.Close();//disponse
            fs.Close();//dispose objects

            Console.WriteLine("file is crated at "+filePath);
          



        }

        private static void CaseStudy1()
        {

            Console.WriteLine("Enter your name");
            string userName= Console.ReadLine();
            Console.WriteLine($"hello dear {userName}");
        }
    }
}
