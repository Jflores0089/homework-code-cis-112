using static System.Console;

class StarsAndSpaces
{
    static void Main()
    {
        for (int x = 1; x <= 5; ++x)
        {
            if ( x == 1)
            {
                Write("    *");
            }
            else if (x != 1)
            {
               for (int i = 1; i <= 5 - x; ++i)
                {
                    Write(" ");
                }
                    Write("*");
                for (int j = 1; j <= 2 * x - 3; ++j)
                {
                    Write(" ");   
                }
                    Write("*");
            }
            WriteLine();
        }    
    }
}
