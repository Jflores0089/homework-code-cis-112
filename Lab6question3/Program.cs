using static System.Console;

class sumOfIntegers
{
    static int SumOfInt(int userInput)
    {
        int sumInts = 0;
        for ( int i = 1; i <= userInput; ++i)
        {
            sumInts = sumInts + i;
        }
        return sumInts;
    }
    static void Main()
    {
        int userInput = -1;
        
        while( userInput != 0)
        {
        
            WriteLine("Please enter a number or type 0 to exit");
        
            userInput = int.Parse(ReadLine());
        
            if (userInput != 0)
            {
                SumOfInt(userInput);
            
                WriteLine("The sum of the integers up to the one you selected is {0}",SumOfInt(userInput));
            }
            else
            {
                WriteLine("Thanks for playing.");
            }
        }  
    }
}

