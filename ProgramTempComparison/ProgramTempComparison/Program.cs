using static System.Console;

class ProgramTempComparison
{
    static void Main()
    {
        bool gettingWarmer = true;
        bool gettingCooler = true;
        int[] tempInput = new int[5];
        int userInput = 0;

        for (int i = 0; i < 5; ++i)
        {
            do
            {
                WriteLine("Please enter a valid temperature.");
                userInput = Convert.ToInt32(ReadLine());
            } while (userInput < -30 || userInput > 130);
            tempInput[i] = userInput;

        }
        for (int i = 1; i < 5; ++i)
        {
            if (tempInput[i] < tempInput[i - 1])
            {
                gettingWarmer = false;
            }
            else if (tempInput[i] > tempInput[i - 1])
            {
                gettingCooler = false;
            }
        }
        if (gettingWarmer == true)
        {
            WriteLine("Getting Warmer");
        }
        else if (gettingCooler == true)
        {
            WriteLine("Getting Cooler");
        }
        else
        {
            WriteLine("Its a mixed bag");
        }
        for (int x = 0; x < 5; ++x)
        {
            WriteLine(tempInput[x]);
        }
        int tempTotal = 0;
        for (int y = 0; y < 5; ++y)
        {
            tempTotal += tempInput[y];
        }
        int avgTemp = tempTotal / 5;
        WriteLine("The average temperature is {0}", avgTemp);
    }
}