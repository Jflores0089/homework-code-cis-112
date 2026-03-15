using static System.Console;
class InchesToCentimeters
{
    

    static void Main()
    {
        const double CONVERSION  = 2.54;
        double inches = 5.5;
        double centimeters = (inches * CONVERSION);
        WriteLine("{0} Inches is equal to {1} Centimeters", inches, centimeters);
    }
}