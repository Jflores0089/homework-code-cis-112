//Lab 3 invoice application

using System.Text;
using static System.Console;
class InvoiceApp
{
    static void Main()
    {
        string apple = "Apple";
        decimal cost = .50M;
        int numPurchased = 6;
        decimal subtotal = cost * numPurchased;
        decimal taxRate = subtotal * 0.10M;
        decimal total = subtotal + taxRate;
        
        WriteLine("Item:{0}", apple);
        WriteLine("Quantity:{0}", numPurchased);
        WriteLine("Unit Price:{0}", cost);
        WriteLine("Subtotal:{0}", subtotal);
        WriteLine("Tax:{0}", taxRate);
        WriteLine("Total:{0}", total);
        
    }
}