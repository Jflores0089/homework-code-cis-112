using static System.Console;
class ProjectedRaisesInteractive
{
   static void Main()
    {
        WriteLine("What is Employee 1's salary?");
        double employee1 = Convert.ToDouble(ReadLine());
        WriteLine("What is Employee 2's salary?");
        double employee2 = Convert.ToDouble(ReadLine());
        WriteLine("What is Employee 3's salary?");
        double employee3 = Convert.ToDouble(ReadLine());
        const double RAISE = 0.04;
        double projected_rate1 = (RAISE * employee1) + employee1;
        double projected_rate2 = (RAISE * employee2) + employee2;
        double projected_rate3 = (RAISE * employee3) + employee3;
        WriteLine("This years projected salaries after 4% raises are:\nFor Employee 1 is: {0}\nFor Employee 2 is: {1}\nFor Employee 3 is: {2}",projected_rate1, projected_rate2, projected_rate3);
    } 
}
