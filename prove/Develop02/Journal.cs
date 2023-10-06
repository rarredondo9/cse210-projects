using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.FormatForFile());
                }
            }

            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public void LoadFromFile(string fileName)
    {
        try
        {
            entries.Clear(); 

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        Entry entry = new Entry
                        {
                            Date = parts[0],
                            Prompt = parts[1],
                            Response = parts[2]
                        };
                        entries.Add(entry);
                    }
                }
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
