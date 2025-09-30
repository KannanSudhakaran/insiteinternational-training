

using InsiteInternational.Domain;

class Program {


    static void Main() {

        Rectangle r1 = new Rectangle();
      
        r1.SetWidth(1000);
        r1.SetHeight(1000);
        r1.SetColor("pink");

        Console.WriteLine($"widh is {r1.GetWidth()} ," +
            $" height is {r1.GetHeight()}" +
            $" color is {r1.GetColor()}" +
            $" area is {r1.CalculateArea()}");
           

      
    
    }

}
