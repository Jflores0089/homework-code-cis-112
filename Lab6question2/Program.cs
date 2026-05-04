using static System.Console;

class digitsInInteger
{
    static int Digits(int userInput)
    {
        int numTimesDivided = 0;
        while (userInput > 0)
        {
            userInput /= 10;
            ++numTimesDivided;
        }
        return numTimesDivided;
    }
    static void Main()
    {
        WriteLine("Please enter a numeric value.");
        
        int userInput = int.Parse(ReadLine());

        Digits(userInput);
        
        WriteLine("The number of digits in your numeric value is {0}",Digits(userInput));
    }
}