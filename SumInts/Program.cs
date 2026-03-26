using static System.Console;

class SumInts
{
    static void Main()
    {
        int input = 0;
        int total = 0;

        while (input != 999)
        {
            WriteLine("Please enter a number.");
            input = Convert.ToInt32(ReadLine());
            if (input != 999)
            {
            total = input+ total;    
            }
            
        }
        WriteLine("Your total is {0}",total);
    }
}