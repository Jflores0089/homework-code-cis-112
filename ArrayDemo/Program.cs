using static System.Console;

class ArrayDemo
{
  static void Main()
  {
    int[] arrayDemo = new int[10];
    int userChoice = 0;
    while (userChoice != 999)
    {
      WriteLine("To view list from first to last, press 1");
      WriteLine("To view list from last to first, press 2");
      WriteLine("To view specific postion, press 3");
      WriteLine("To exit when finished, press 4");
      userChoice = Convert.ToInt32(ReadLine());
      switch (userChoice)
      {
        case 1:
          {
            for(int x = 0; x >10;++x)
            {
              WriteLine()
            }
          }
      }
    }
  }
}