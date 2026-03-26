using static System.Console;

class SumFiveInts
{
    static void Main()
    {
      
        int input = 0;
        int total = 0;
        
     for (int counter = 0; counter < 5;++counter)
        {
            WriteLine("Please enter a number.");
            string? userInput = ReadLine();
            input = Convert.ToInt32(userInput);

            total = total + input;


        }
        WriteLine("The Sum is {0}.",total);
    }
}