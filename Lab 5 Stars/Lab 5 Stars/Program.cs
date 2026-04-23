using static System.Console;
class Stars
 
{
static void Main()
 
{
    for (int x = 1; x <= 5; ++x)
{
    for (int y = 1; y <= 5 - x; ++y)
{
    Write(" ");
}
    for (int z = 1; z <= 2 * x - 1; ++z)
        {
        Write("*");
        }
        WriteLine();
}
}

}