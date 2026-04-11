using static System.Console;
class CheckZips
{
     static void Main()
    {
        bool found = false;
        
        string [] zips = new string [10]{"12590","12601","56891","69001","10029","20456","34123","77734","09235","12345"};
        
        WriteLine("Please enter a valid zipcode");
        
        string userInput = ReadLine();
        
        for (int i = 0; i < 10; ++i)
        {
            if (userInput == zips[i])
            
            {
                found = true;
            }   
        }    
            if (found)
            {
                WriteLine("Zipcode located.");
            }
            else
            {
                WriteLine("This Zipcode is incorrect!");
            }
        

    }
}

