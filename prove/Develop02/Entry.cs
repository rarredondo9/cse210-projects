class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    public string FormatForFile()
    {
        return $"{Date},\"{Prompt}\",\"{Response}\"";
    }
}
