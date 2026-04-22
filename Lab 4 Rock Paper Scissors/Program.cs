using static System.Console;

class RockPaperScissors
{
    static void Main()
    {
        Random rg = new Random();
        WriteLine("Welcome to Rock,Paper,Scissors");
        int userInput = 0;
        
        while (userInput != 4)
        {
            WriteLine("Please make a selection");
            WriteLine("1. Rock\n2. Paper\n3. Scissors\n4. Exit Game");
            userInput = int.Parse(ReadLine());
            string compChoice = "";
            string choice = "";
            int compInput = rg.Next(1,4);

        if (userInput == 4)
            {
                WriteLine("Thanks for playing!");
                break;
            }

        switch(userInput)
        {
            case 1: choice = "Rock";
            break;

            case 2: choice = "Paper";
            break;

            case 3 : choice = "Scissors";
            break;
        }
        switch(compInput)
        {
            case 1: compChoice = "Rock";
            break;

            case 2: compChoice = "Paper";
            break;

            case 3: compChoice = "Scissors";
            break;
        }
        
             if(choice == "Rock" && compChoice == "Paper")
        {
            WriteLine("Players {0} Gets Wrapped Up by Computers {1}. Computer Wins!",choice,compChoice);
        }
        else if (choice == "Paper" && compChoice == "Rock")
        {
            WriteLine("Players {0} Wraps Up Computers {1}. Player Wins!",choice,compChoice);
        }
        else if (choice == "Scissors" && compChoice == "Rock")
        {
            WriteLine("Players {0} Gets Crushed by Computers {1}. Computer Wins!",choice,compChoice);
        }
        else if (choice == "Paper" && compChoice == "Scissors")
        {
            WriteLine("Players {0} Gets Cut Up By Computers {1}. Computer Wins",choice,compChoice);
        }
        else if (choice == "Scissors" && compChoice == "Paper")
        {
            WriteLine("Players {0} Cuts up Computers {1}. Player Wins!",choice,compChoice);
        }
        else if (choice == "Rock" && compChoice == "Scissors")
        {
            WriteLine("Players {0} Crushes Computers {1}. Player Wins!",choice,compChoice);
        }
        else if(choice == compChoice)
        {
            WriteLine("Its a tie!");
        }
        }
    }
}