// Journal.cs
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Member variable: list of entries
    private List<Entry> _entries = new List<Entry>();

    // Method to add a new entry
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Method to display all entries
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry(); // Calls Entry's Display method
        }
    }

    // Save journal entries to a file
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetResponse()}");

            }
        }
    }

    // Load entries from a file
public void Load(string filename)
{
    _entries.Clear(); // Clear current entries

    // Read all lines from the file
    string[] lines = File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split('|'); // Split by separator
        if (parts.Length == 3)
        {
            // Create a new empty Entry
            Entry entry = new Entry("", ""); // Use the constructor with 2 parameters
            // Set the values using setters
            entry.SetDate(parts[0]);
            entry.SetPrompt(parts[1]);
            entry.SetResponse(parts[2]);

            // Add the entry to the journal
            _entries.Add(entry);
        }
    }
}
    // Optional: get all entries if needed
    public List<Entry> GetEntries() { return _entries; }
}
