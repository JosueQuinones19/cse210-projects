// Entry.cs
using System;

public class Entry
{
    // Member variables
    private string _prompt;
    private string _response;
    private string _date;

    // Constructor
    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToShortDateString(); // Stores today's date automatically
    }

    // Empty constructor for loading from file
    public Entry() { }

    // Method to display the entry
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    // Optional getters if needed later
    public string GetPrompt() { return _prompt; }
    public string GetResponse() { return _response; }
    public string GetDate() { return _date; }
    // Setters to allow Journal to modify private members when loading from file
    public void SetPrompt(string prompt) { _prompt = prompt; }
    public void SetResponse(string response) { _response = response; }
    public void SetDate(string date) { _date = date; }

// Constructor with date, prompt, and response
public Entry(string date, string prompt, string response)
{
    _date = date;
    _prompt = prompt;
    _response = response;
}
}
