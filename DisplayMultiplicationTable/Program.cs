using static System.Console;

class DisplayMultiplicationTables
{
    static void Main()
    {
       for(int x = 1; x <= 10; ++x)
        {
        for(int y = 1; y <= 10; ++y)
            {
                WriteLine("{0}*{1} = {2}",x,y,(x*y));
            }  
        }


    }
}