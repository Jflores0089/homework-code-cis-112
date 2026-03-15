using static System.Console;
class InchesToCentimetersInteractive
{
    static void Main()
    {
        WriteLine("How Many Inches?");
        double inches = Convert.ToDouble(ReadLine());
        const double TOCENTIMETERS = 2.54;
        double centimeters = inches * TOCENTIMETERS;
        WriteLine("{0} Inches is {1} Centimeters",inches,centimeters);

    }
}