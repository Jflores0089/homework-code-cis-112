using static System.Console;

class DailyTemps
{
    static void Main()
    {
        int input = 0;
        
        int numberOfTemps = 0;
        
        int totalTemps = 0;
        
        int avgTemps = 0;
        
        while (input != 999)
        {
            WriteLine("Please enter a Valid Temperature.");
            input = Convert.ToInt32(ReadLine());
            if ( input >= -20 && input <= 130)
            {
                ++numberOfTemps;
                totalTemps = input + totalTemps;

            }
            else if ((input < -20 || input > 130) && input != 999)
            {
                WriteLine("Please enter a valid input.");
            }
        }
        avgTemps = totalTemps / numberOfTemps;
        WriteLine("The number of temps entered is:{0}",numberOfTemps);
        WriteLine("The Average Temperature is {0}",avgTemps);
    }
}