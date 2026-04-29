using static System.Console;

class PaintingEstimate
{
    static double Estimate (double Length, double Width)
    {
       double totalCost = ((2 * Length * 9) + (2 * Width * 9)) * 6;

       return totalCost;
    }

    static void Main()
    {
        WriteLine("Welcome to Hardware Goods");
        WriteLine("What is the length of the wall?");
        double Length = double.Parse(ReadLine());
        WriteLine("What is the width of the wall?");
        double Width = double.Parse(ReadLine());
        double price = Estimate (Length, Width);
        WriteLine($"The price for painting will be {price:C}");
        
    }
}