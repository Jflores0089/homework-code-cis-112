using static System.Console;

class VolumeOfBox
{
    static double Volume(double length, double width, double height)
    {
        return length * width * height;
    }
    static void Main()
    {
        double length = 0.0;
        double width = 0.0;
        double height = 0.0;

        WriteLine("What is the length?");
        length = double.Parse(ReadLine());
        WriteLine("What is the width?");
        width = double.Parse(ReadLine());
        WriteLine("What is the height?");
        height = double.Parse(ReadLine());

        WriteLine("The volume is {0}.",Volume(length, width, height));

    }
}