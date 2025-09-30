

class Program {

    static void Main() {

        // CaseStudy1();

        CaseStudy2();
    
    }

    private static void CaseStudy2()
    {
        string company = "InsiteInternational";
        Console.WriteLine(company.GetHashCode());
        company= company.ToUpper();
        Console.WriteLine(company.GetHashCode());
        Console.WriteLine(company);
    }

    static void CaseStudy1()
    {

        string company = "InsiteInternational";
        company.ToUpper(); //string are not modifiable,immutable
        Console.WriteLine(company);

    }

}
