// Lab 2 question #9
using static System.Console;
class Rectangle_homework
{
    static void Main()
    {
        WriteLine("What is the Length?");
        double length = Convert.ToDouble(ReadLine());
        WriteLine("What is the Width?");
        double width = Convert.ToDouble(ReadLine());
        double area = width * length;
        double perimeter = (2 * width) + (2* length);
        WriteLine("Perimeter: {0}, Area: {1}, Width: {2}, Length: {3}",perimeter, area, width, length);
    }
}