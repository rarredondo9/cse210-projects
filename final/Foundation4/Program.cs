using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0f);
        Cycling cyclingActivity = new Cycling("03 Nov 2022", 30, 12.0f);
        Swimming swimmingActivity = new Swimming("03 Nov 2022", 30, 10);

        List<Activity> activities = new List<Activity> { runningActivity, cyclingActivity, swimmingActivity };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GenerateSummary());
        }
    }
}
