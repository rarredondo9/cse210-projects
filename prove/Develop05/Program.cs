using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("------ Goal Tracking System ------");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals to File");
            Console.WriteLine("5. Load Goals from File");
            Console.WriteLine("6. Exit");
            Console.WriteLine("----------------------------------");
            Console.Write("Enter your choice (1-6): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        AddGoal(goalManager);
                        break;
                    case 2:
                        RecordEvent(goalManager);
                        break;
                    case 3:
                        goalManager.DisplayGoals();
                        break;
                    case 4:
                        goalManager.SaveToFile("goals.csv");
                        break;
                    case 5:
                        goalManager.LoadFromFile("goals.csv");
                        break;
                    case 6:
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void AddGoal(GoalManager manager)
    {
        Console.WriteLine("------ Add Goal ------");
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter goal type (1-3): ");

        if (int.TryParse(Console.ReadLine(), out int goalType))
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal value: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                switch (goalType)
                {
                    case 1:
                        manager.AddGoal(new SimpleGoal { Name = name, Value = value });
                        Console.WriteLine("Simple Goal added successfully.");
                        break;
                    case 2:
                        manager.AddGoal(new EternalGoal { Name = name, Value = value });
                        Console.WriteLine("Eternal Goal added successfully.");
                        break;
                    case 3:
                        Console.Write("Enter target count: ");
                        if (int.TryParse(Console.ReadLine(), out int targetCount))
                        {
                            Console.Write("Enter bonus value: ");
                            if (int.TryParse(Console.ReadLine(), out int bonusValue))
                            {
                                manager.AddGoal(new ChecklistGoal { Name = name, Value = value, TargetCount = targetCount, BonusValue = bonusValue });
                                Console.WriteLine("Checklist Goal added successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid bonus value. Failed to add Checklist Goal.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid target count. Failed to add Checklist Goal.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid goal type. No goal added.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid value. No goal added.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. No goal added.");
        }
    }

    static void RecordEvent(GoalManager manager)
    {
        Console.WriteLine("------ Record Event ------");
        Console.Write("Enter the name of the goal to mark as complete: ");
        string goalName = Console.ReadLine();
        int pointsEarned = manager.RecordEvent(goalName);
        if (pointsEarned > 0)
        {
            Console.WriteLine($"Event recorded for '{goalName}'. Earned {pointsEarned} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }
}