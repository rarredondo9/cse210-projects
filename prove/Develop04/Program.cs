using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Enumeration Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            
            if (int.TryParse(choice, out int activityChoice))
            {
                if (activityChoice >= 1 && activityChoice <= 3)
                {
                    Console.Write("Enter duration (in seconds): ");
                    int duration;
                    if (int.TryParse(Console.ReadLine(), out duration))
                    {
                        Activity activity = GetActivity(activityChoice);
                        activity.SetDuration(duration);
                        activity.Start();
                    }
                    else
                    {
                        Console.WriteLine("Invalid duration. Please enter a valid number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
    }

    static Activity GetActivity(int choice)
    {
        switch (choice)
        {
            case 1:
                return new BreathingActivity();
            case 2:
                return new ReflectionActivity();
            // case 3:
            //     return new ListingActivity();
            default:
                throw new ArgumentOutOfRangeException("Invalid activity choice.");
        }
    }
}
