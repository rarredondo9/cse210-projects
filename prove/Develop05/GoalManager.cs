using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public class GoalManager
{
    private List<Goal> goalsList;

    public GoalManager()
    {
        goalsList = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goalsList.Add(goal);
    }

    public int RecordEvent(string goalName)
    {
        foreach (var goal in goalsList)
        {
            if(goal.Name == goalName)
            {
                return goal.Complete();
            }
        }
        return 0;
    }
    
    public void DisplayGoals() 
    {
        foreach (var goal in goalsList)
        {
            string completionStatus = goal.Completed ? "[X]" : "[ ]";
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{completionStatus} {goal.Name} Completed {checklistGoal.CurrentCount}/{checklistGoal.TargetCount} times");
            }
            else
            {
                Console.WriteLine($"{completionStatus} {goal.Name} - Value: {goal.Value}");
            }
        }
    } 

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var goal in goalsList)
                {
                    string line = $"{goal.GetType().Name},{goal.Name},{goal.Value},{goal.Completed}";
                    
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        line += $",{checklistGoal.TargetCount},{checklistGoal.CurrentCount},{checklistGoal.BonusValue}";
                    }

                    writer.WriteLine(line);                
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
        Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }    

    public void LoadFromFile(string filename)
    {
        try
        {
            goalsList.Clear(); // Clear existing goals before loading from file

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    int value = int.Parse(parts[2]);
                    bool completed = bool.Parse(parts[3]);

                    Goal goal;
                    if (type == nameof(SimpleGoal))
                    {
                        goal = new SimpleGoal { Name = name, Value = value, Completed = completed };
                    }
                    else if (type == nameof(EternalGoal))
                    {
                        goal = new EternalGoal { Name = name, Value = value, Completed = completed };
                    }
                    else if (type == nameof(ChecklistGoal))
                    {
                        int targetCount = int.Parse(parts[4]);
                        int currentCount = int.Parse(parts[5]);
                        int bonusValue = int.Parse(parts[6]);
                        goal = new ChecklistGoal { Name = name, Value = value, Completed = completed, TargetCount = targetCount, CurrentCount = currentCount, BonusValue = bonusValue };
                    }
                    else
                    {
                        // Handle unrecognized goal type
                        continue;
                    }

                    goalsList.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
        
}