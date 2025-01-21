using System;

public class Artwork 
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Creator { get; set; }
    
    public Artwork(string title, string description, string creator)
    {
        Title = title;
        Description = description;
        Creator = creator;
    }

    public void DisplayArtInfo()
    {
        Console.WriteLine($"Titel: {Title}");
        Console.WriteLine($"Beskrivning: {Description}");
        Console.WriteLine($"Upphovsmakare: {Creator}");
        Console.WriteLine($"-------------------------------");

    }
}
