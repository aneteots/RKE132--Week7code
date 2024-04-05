Console.WriteLine("How many steps have you walked today?");
int usersSteps = Int32.Parse(Console.ReadLine());
double result = HealthMonitor(usersSteps);
Console.WriteLine();
static double HealthMonitor(int usersSteps)
{
    if (usersSteps < 4000)
    {
        return ("You need to move more.");
    }
    else if (usersSteps >= 4000 && usersSteps < 8000)
    {
        return ("Health goal achieved,");
    }
    else
    {
        return ("Well done!");
    }
}
