using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running(20, 10, 5);
        activities.Add(running);

        StationaryCycling cycling = new StationaryCycling(0, 21, 8);
        activities.Add(cycling);

        Swimming swimming = new Swimming(5, 50, 5, 4);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}