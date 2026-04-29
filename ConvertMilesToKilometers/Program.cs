using static System.Console;

class ConvertMilesToKilometers
{
    static double MtoK (double miles)
    {
        double kilos = miles * 1.60934;

        return kilos;
    }
    static void Main()
    {
        WriteLine("Please enter the amount of miles");
        double miles = double.Parse(ReadLine());
         double kilos = MtoK(miles);
         WriteLine("{0} miles is equal to {1} kilometers.", miles, kilos);
    }
}
