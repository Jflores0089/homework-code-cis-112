using System.ComponentModel;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Hello!\nWelcome to Getting It Right Cafe!\nWhat is your name?");
        string? name = ReadLine();
        WriteLine("Hello " + name + " have a look at our menu.");
        WriteLine();

        Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
        menu.Add("latte", 6.00m);
        menu.Add("espresso", 5.00m);
        menu.Add("americano", 4.50m);
        menu.Add("black tea", 3.00m);
        menu.Add("coffee", 3.00m);
        Dictionary<string, int> order_list = new Dictionary<string, int>();
        foreach (var item in menu)
        {
            WriteLine($"{item.Key}: ${item.Value}");
            WriteLine();
        }

        bool user_deciding = true;

        while (user_deciding)
        {
            WriteLine("What can I get you " + name + "?");
            string? user_choice = ReadLine();

            if (user_choice == null)
            {
                WriteLine("Please select a valid option.");
            }
                else
                {
                    string choice_lower = user_choice.ToLower();
                    string? matched_item = null;
                    
                    foreach (var itemName in menu.Keys)
                    {
                        if(choice_lower.Contains(itemName))
                        {
                            matched_item = itemName;
                            break;
                        }
                    }
                    if (matched_item != null)
                    {
                        WriteLine($"Excellent choice! That will be {menu[matched_item]:C}.");
                        WriteLine("How Many would you like?");
                        int quantity_ordered = int.Parse(ReadLine()?? "0");
                        if (order_list.ContainsKey(matched_item))
                        {
                            order_list[matched_item] += quantity_ordered;
                        }
                        else
                        {
                            order_list.Add(matched_item, quantity_ordered);
                        }
                    WriteLine("Would you like anything else? (yes/no)");
                        string? more = ReadLine()?.ToLower();
                    if (more == "no")
                        {
                            user_deciding = false;
                        }
                    }    
                    else
                    {
                        WriteLine("Sorry, I couldnt find a drink in what you said.\nPlease try mentioning a drink name");
                    }
                }
            }
            WriteLine("\nHere is your order summary:");
            decimal total = 0;
            foreach (var matched_item in order_list)
            {
                WriteLine($"- {matched_item.Key} x{matched_item.Value}: {order_list[matched_item.Key]:C}");
            total += order_list[matched_item.Key] * menu[matched_item.Key];
            }
            WriteLine($"\nYour total is:{total:C}");
            WriteLine("Getting it right Cafe thanks you for your patronage.");
        }    
    }   

    
