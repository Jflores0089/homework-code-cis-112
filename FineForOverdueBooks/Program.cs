using static System.Console;
class FineForOverdueBooks
{
    

   static double Fine(double books, double days)
    {
         double price = .10;
         
        if (days <= 7)
        {
          double total = days * books * price;

           return total;
        }
        
        else
        {
            double total = 0;
            total = days * books * (2 * price);
            
            return total;
        }
    }
    static void Main()
    {
        
        WriteLine("How many books do you have overdue?");
        double books = double.Parse(ReadLine());
        WriteLine("How many days late?");
        double days = double.Parse(ReadLine());
        Fine(books, days);
        WriteLine($"The total due is {Fine( books, days):C}");
    }
}