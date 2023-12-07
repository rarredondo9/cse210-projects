using System;

class Program
{
    static void Main(string[] args)
    {
        string address = "123 Main St, Anytown, ABC, 12345";

        Lecture lectureEvent = new Lecture("Python Lecture", "Introduction to Python programming", "2023-12-10", "10:00 AM", address, "Lecture", "John Doe", 50);
        Reception receptionEvent = new Reception("Networking Reception", "Networking event for professionals", "2023-12-15", "6:00 PM", address, "Reception", "rsvp@example.com");
        Outdoor outdoorEvent = new Outdoor("Outdoor Music Festival", "Live music and food trucks", "2023-12-20", "2:00 PM", address, "Outdoor", "Sunny");

        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lectureEvent.GenerateStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Lecture Full Details:");
        Console.WriteLine(lectureEvent.GenerateFullDetails());
        Console.WriteLine();

        Console.WriteLine("Reception Details:");
        Console.WriteLine(receptionEvent.GenerateStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Reception Full Details:");
        Console.WriteLine(receptionEvent.GenerateFullDetails());
        Console.WriteLine();

        Console.WriteLine("Outdoor Details:");
        Console.WriteLine(outdoorEvent.GenerateStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Outdoor Full Details:");
        Console.WriteLine(outdoorEvent.GenerateFullDetails());
    }
}
