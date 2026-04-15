using static System.Console;

class ChatAWhile
{
    static void Main()
    {
        string [] areaCode = new string [6] {"262", "414", "608", "715", "815","920"};
        double [] rate = new double [6] {.07, .10, .05, .16, .24, .14 }; 
        WriteLine("Please enter a area code");
        string? userCode = ReadLine();
        WriteLine("Please enter the number of minutes");
        double userMin = double.Parse(ReadLine());
        bool found = false;

        for (int i = 0; i < 6; ++i)
        {
            if (userCode == areaCode [i])
            {
                found = true;
                double total = rate [i] * userMin;
                WriteLine("The total cost is {0}",total);
            }
        }
             if (!found)
            {
                WriteLine("Please try a valid zipcode");
            }
    }   
} 