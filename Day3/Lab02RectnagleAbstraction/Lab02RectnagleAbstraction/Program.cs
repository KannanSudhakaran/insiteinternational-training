using InsiteInternational;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;


class Program {

    static void Main()
    {

        Rectangle r1 = new Rectangle();
        r1.width = 1000;// 1 to 100
        r1.height = 2000;// 1 to 100
        r1.color = "xyzdjldjfldfldlfjd";//red,blue,green


    }

    private static void CaseStudy3()
    {
        Rectangle rect1 = new Rectangle();
        rect1.width = 10;
        rect1.height = 20;
        rect1.color = "pink";

        Console.WriteLine(rect1.GetHashCode());


        Rectangle rect2 = new Rectangle();
        rect1 = rect2;
        rect2.color = "yellow";

        Console.WriteLine(rect1.GetHashCode());
        Console.WriteLine(rect2.GetHashCode());

        Console.WriteLine(rect1.color);
        Console.WriteLine(rect2.color);
    }

    static void CaseStudy2() {

        Rectangle big;//big expects a rectangle object
        big = new Rectangle();
        big.width = 40;
        big.height = 10;
        big.color = "red";
        Console.WriteLine("big details are");
        Console.WriteLine($"width is {big.width}," +
            $"height {big.height},color is {big.color}, " +
            $"area is {big.CalculateArea()}");
    }

     static void CaseStudy1()
    {
        Rectangle small;//small expects an object of rectangle class

        small = new Rectangle();

        Console.WriteLine(small.GetHashCode());
        Console.WriteLine($"smalls widht is {small.width} and height {small.height}, color is {small.color}");
        Console.WriteLine($"Area of small is {small.CalculateArea()}");

        small.width = 5;
        small.height = 2;
        small.color = "blue";

        Console.WriteLine($"smalls widht is {small.width} and height {small.height}, color is {small.color}");
        Console.WriteLine($"Area of small is {small.CalculateArea()}");
    }
}