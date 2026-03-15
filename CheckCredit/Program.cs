using static System.Console;
class CheckCredit
{
    static void Main()
    {
        WriteLine("What is the purchase price?");
        double pPrice = Convert.ToDouble(ReadLine());
        if (pPrice > 8000)
        {
            WriteLine("Sorry Declined");
        }
        else
        {
            WriteLine("Approved");
        }
    }
}