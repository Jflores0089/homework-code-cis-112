using static System.Console;
class ProjectedRaises
{
   static void Main()
    {
        double employee1 = 45000;
        double employee2 = 55000;
        double employee3 = 70000;
        const double RAISE = 0.04;
        double projected_rate1 = (RAISE * employee1) + employee1;
        double projected_rate2 = (RAISE * employee2) + employee2;
        double projected_rate3 = (RAISE * employee3) + employee3;
        WriteLine("This years projected salaries after 4% raises are:\nFor Employee 1 is: {0}\nFor Employee 2 is: {1}\nFor Employee 3 is: {2}",projected_rate1, projected_rate2, projected_rate3);
    } 
}
