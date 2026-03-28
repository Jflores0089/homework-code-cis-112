using static System.Console;

class CountVowels
{
    static void Main()
    {
    WriteLine("Please enter a word");
    string? userInput = ReadLine();
    if (string.IsNullOrWhiteSpace(userInput))
{
    userInput = "there";
}
    int counter = 0;

        foreach (char currentChar in userInput)
        {
            if ("aeiouAEIOU".Contains(currentChar))
            {
                ++counter;
            } 
        }
        WriteLine("The Vowel Count is {0}.", counter);
    }
}