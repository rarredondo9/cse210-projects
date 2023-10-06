using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry entry = CreateJournalEntry(promptGenerator);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayJournal();
                    break;

                case "3":
                    journal.SaveToFile("myJournal.csv"); 
                    break;

                case "4":
                    journal.LoadFromFile("myJournal.csv"); 
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static Entry CreateJournalEntry(PromptGenerator promptGenerator)
    {
        Entry entry = new Entry();
        entry.Date = DateTime.Now.ToString();
        entry.Prompt = promptGenerator.GenerateRandomPrompt();

        Console.WriteLine($"Prompt: {entry.Prompt}");
        Console.Write("Enter your response: ");
        entry.Response = Console.ReadLine();

        return entry;
    }
}
