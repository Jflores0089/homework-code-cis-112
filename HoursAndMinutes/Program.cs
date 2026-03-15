using static System.Console;
    class HoursAndMinutes
    {
        static void Main()
        {
        WriteLine("How many minutes?");
        int minutes = Convert.ToInt32(ReadLine());
        int hours = minutes / 60;
        int remainder = minutes % 60;
        WriteLine("There are {0} integer hours and {1} remainder minutes in {2} minutes",hours, remainder,minutes);
        }
    }
   