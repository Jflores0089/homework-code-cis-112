using static System.Console;

class NumbersGuessingGame
{
    static void Main()
    {
        int userInput = 0;
        
        Random rg = new Random();
        
        while (userInput != 999)
        {
            WriteLine("Welcome to the numbers guessing game!\n");
            WriteLine("Please guess a number from 1 to 100.\n");
            WriteLine("Otherwise type 999 to quit.\n");
            
            int rgNum = rg.Next(1,101);

            int numTries = 0;

            userInput = int.Parse(ReadLine());
            
            while (userInput != rgNum && userInput != 999)
            {
                numTries = ++numTries;
                if (userInput != rgNum && userInput < rgNum) 
                {
                    WriteLine("Your guess is too low");
                }
                else if (userInput != rgNum && userInput > rgNum  )
                {
                    WriteLine("Your guess is too high");
                }
                WriteLine("Please type another guess");
                userInput = int.Parse(ReadLine());
            }
            if (userInput == rgNum)
            {
            WriteLine("Congratulations! You guessed right!");
            WriteLine("The number of guesses it took was {0}.",numTries);
            }
            else
            {
                if (userInput == 999)
                {
                    
                    WriteLine("Thanks for playing!");
                    WriteLine();
                    WriteLine();
                }
            }
        }
    }
}