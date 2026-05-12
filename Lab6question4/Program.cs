using static System.Console;

class BabylonianMethod
{
   
    private static double Square(double x)
    {
       double oldGuess = x;
       
       double newGuess = oldGuess / 2;
       
    while (oldGuess - newGuess > .00001)
        {
           double avgGuess = (newGuess + x / newGuess) / 2;
           
           oldGuess = newGuess;
           
           newGuess = avgGuess;
        }
        
        return newGuess;

    }
    
    static void Main()
    {
        WriteLine("Hello! Please enter a number!");
        
        double userInput = double.Parse(ReadLine()!);
        
        WriteLine("The square root of your number is approximately {0}", Square(userInput));

    }
}