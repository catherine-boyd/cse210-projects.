using System;
using ExerciseTracking;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running(34.4, 60, "23/05/2002");
        Activity cycling = new Cycling(37, 45,"2/12/1997");
        Activity swimming = new Swimming(20, 40, "02nd/09/2017");

        List<Activity> activities = new List<Activity> {running, cycling, swimming };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(running.GetSummary());
            Console.WriteLine(cycling.GetSummary());
            Console.WriteLine(swimming.GetSummary());
        }
    }
}