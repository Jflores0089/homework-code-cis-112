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
        List<string> order_list = new List<string>();
        foreach (var item in menu)
        {
            WriteLine(item.Key + " " + item.Value);
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
                        order_list.Add(matched_item);
                        WriteLine($"Excellent choice! That will be {menu[matched_item]:C}.");
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
            foreach (string item in order_list)
            {
            WriteLine($"- {item}: {menu[item]:C}");
            total += menu[item];
            }
            WriteLine($"\nYour total is:{total:C}");
            WriteLine("Getting it right Cafe thanks you for your patronage.");
        }    
    }   

    
