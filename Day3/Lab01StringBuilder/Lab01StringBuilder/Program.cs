
using System;
using System.Text;

class Program {


    static void Main() {

        // CaseStudy1();

        CaseStudy2();
    
    }

    static void CaseStudy2() {

        //mutable
        StringBuilder userName = new StringBuilder();// allocates heap
        Console.WriteLine(userName.GetHashCode());
        userName.Append("Maged");
        userName.Append("Inline International ");
        userName.Append("Saudi");
        Console.WriteLine(userName.GetHashCode());
        Console.WriteLine(userName);

    }
    static void CaseStudy1() {
        //immutable
        string userName = "Maged ";
        Console.WriteLine(userName.GetHashCode());
        userName += "Inline International ";
        Console.WriteLine(userName.GetHashCode());
        userName += "Saudi";
        Console.WriteLine(userName.GetHashCode());

        Console.WriteLine(userName);
    }

}