
using InsiteInternaitonal;
using System;
using System.Drawing;
using System.Reflection.PortableExecutable;

class Program {

    static void Main() {


        Console.ForegroundColor = ConsoleColor.Red;

        InsiteInternaitonal.Rectangle small = new InsiteInternaitonal.Rectangle();
        small.Width = 0;// setWidth(10);
        Console.WriteLine($"width is {small.Width}");

        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        small.Height = 110;
        Console.WriteLine($"Height is {small.Height}");
        Console.ResetColor();

        small.Color = "jakldfkldjflkdjfldjf";
        Console.WriteLine(small.Color);

        small.Border = BorderStyleOption.Double;
        Console.WriteLine(small.Border);
    
    }

}
