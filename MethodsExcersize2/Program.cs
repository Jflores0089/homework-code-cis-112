using static System.Console;

class SalesLetter
{
    static void DisplayContactInfo()
        {
            WriteLine("Name: Bob Jenkins");
            WriteLine("Address: 420 Highview Garden");
            WriteLine("Address: New York, NY 21289");
        }
    static void Main()
    {
       WriteLine("Hello Vapor Inc,");
       WriteLine("Im writing to place an order off 100 glasswares.");
       WriteLine("I would like the order to be sent to:");
       WriteLine();
       
       DisplayContactInfo();
       
       WriteLine();
       WriteLine("Last time the order was mistakenly sent to the warehouse down the road and i want to be sure this\nproduct arrives intact and at the correct location.");
       WriteLine("Once again the address is:");
       WriteLine(); 
       
       DisplayContactInfo();
       WriteLine();

       WriteLine("Thank you for your attention to this matter.");
       WriteLine("Bob Jenkins");
       DisplayContactInfo();
    }
}