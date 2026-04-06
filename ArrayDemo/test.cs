using static System.Console;

class ArrayDemo
{
  static void Main()
  {
    int[] arrayDemo = new int[10];
    int userChoice = 0;
        for (int i = 0; i < 10; ++i)
         { 
            WriteLine("Please enter a random number");
            arrayDemo[i] = int.Parse(ReadLine());
         }
        while (userChoice != 4)
        {
                    Write("\nTo view list from first to last, press: 1");
                    Write("\nTo view list from last to first, press: 2");
                    Write("\nTo view specific postion, press: 3");
                    Write("\nTo exit when finished, press: 4");
                    Write("\nTo sort this list of numbers press: 5   ");
                    userChoice = Convert.ToInt32(ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            {
                                for (int x = 0; x < 10; ++x)
                                {
                                WriteLine(arrayDemo[x]);
                                }
                                break;
                            }
                        case 2:
                    {
                        for (int x =9; x >= 0; --x)
                        {
                            WriteLine(arrayDemo[x]);
                        }
                        break;
                    }
                        case 3:
                    {
                        WriteLine("Please enter a position 0-9");
                        int userInput = int.Parse(ReadLine());
                        WriteLine("Your Number is {0}",arrayDemo[userInput]);
                        
                        break;
                    }
                        case 4:
                    {
                        WriteLine("Thanks for using the program!");

                        break;
                    }
                        case 5:
                    {
                        Array.Sort(arrayDemo);
                        for (int y = 0; y < 10; ++y)
                        WriteLine(arrayDemo[y]);

                        break;
                    }
                    }
        }
          
  }
}