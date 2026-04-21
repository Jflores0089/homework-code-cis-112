using static System.Console;

class F2C
{
    static void Main()
    {
        
        WriteLine("Please enter the current temperature in Fahrenheit");
        double userInput = double.Parse(ReadLine());
        double celsius = (userInput - 32) * 5f / 9f;
        string result = celsius.ToString("F1");
        WriteLine("The temperature in Celsius is {0}",result);
    }
}