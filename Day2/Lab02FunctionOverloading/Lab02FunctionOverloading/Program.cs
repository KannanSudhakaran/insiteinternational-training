

using System;

class Program {

    static void Main() {

       
      
        PrintInfo(100);
        Console.WriteLine();
        PrintInfo("Koening");
        Console.WriteLine();
        PrintInfo(10.55d);
        Console.WriteLine();
        PrintInfo(10.55f);
        Console.WriteLine();
        PrintInfo(10.55m);//money or currency
    
    }

    static void PrintInfo(string inputValue) {

        //$" {va1}---> {va2} ==> {va3}"

        Console.WriteLine("overload #1");
        Console.WriteLine("displaying string value "+inputValue);
    }

    /// <summary>
    /// Insite Internaitonal:Displays information about an integer value, including its value and size in bytes.
    /// </summary>
    /// <param name="inputValue">The integer value to display.</param>
    static void PrintInfo(int inputValue)
    {
        Console.WriteLine("overload #2");
        Console.WriteLine($"displaying integer value {inputValue} ");
        Console.WriteLine($"size of integer is {sizeof(int)}");
    }

    static void PrintInfo(double inputValue)
    {
        Console.WriteLine("overload #3");
        Console.WriteLine($"displaying double value {inputValue} ");
        Console.WriteLine($"size of dobule is {sizeof(double)}");
    }

    static void PrintInfo(float inputValue)
    {
        Console.WriteLine("overload #4");
        Console.WriteLine($"displaying float value {inputValue} ");
        Console.WriteLine($"size of float is {sizeof(float)}");
    }

    static void PrintInfo(decimal inputValue)
    {
        Console.WriteLine("overload #5");
        Console.WriteLine($"displaying decimal value {inputValue} ");
        Console.WriteLine($"size of decimal is {sizeof(decimal)}");
    }




}