using System;

class Program
{
    static void Main(string[] args)
    {
         Assignment assignmentOne = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignmentOne.GetSummary());


        MathAssignment assignmentTwo = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignmentTwo.GetSummary());
        Console.WriteLine(assignmentTwo.GetHomeworkList());

        WritingAssignment assignmentThree = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignmentThree.GetSummary());
        Console.WriteLine(assignmentThree.GetWritingInformation());
    }

}
