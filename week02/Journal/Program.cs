using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // --- Step 1: Create a new Journal object ---
        // This object will store all journal entries
        Journal myJournal = new Journal();

        // --- Step 2: Define a list of prompts ---
        // Prompts are questions that help the user reflect and write entries
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        // --- Step 3: Prepare variables for the menu loop ---
        bool running = true;           // Control variable to keep the program running
        Random random = new Random();  // Random object to select a random prompt

        // --- Step 4: Start the menu loop ---
        while (running)
        {
            // Display the menu options to the user
            Console.WriteLine("\n--- Journal Menu ---");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            // Read the user's choice
            string choice = Console.ReadLine();

            // --- Step 5: Handle user choice with a switch ---
            switch (choice)
            {
                case "1":
                    // Option 1: Write a new entry

                    // Select a random prompt from the list
                    int index = random.Next(prompts.Count);
                    string selectedPrompt = prompts[index];

                    // Show the prompt to the user
                    Console.WriteLine(selectedPrompt);

                    // Read the user's response from the console
                    string userResponse = Console.ReadLine();

                    // Get the current date as a string
                    string date = DateTime.Now.ToShortDateString();

                    // Create a new Entry object using the date, prompt, and response
                    Entry newEntry = new Entry(date, selectedPrompt, userResponse);

                    // Add the new entry to the journal
                    myJournal.AddEntry(newEntry);

                    // Confirm to the user that the entry was added
                    Console.WriteLine("Entry added successfully!");
                    break;

                case "2":
                    // Option 2: Display all entries
                    // Call the journal's DisplayJournal method, which iterates through all entries
                    myJournal.DisplayJournal();
                    break;

                case "3":
                    // Option 3: Save the journal to a file

                    // Ask the user for a filename
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();

                    // Call the journal's Save method, which writes all entries to the file
                    myJournal.Save(saveFile);

                    // Confirm to the user
                    Console.WriteLine("Journal saved successfully!");
                    break;

                case "4":
                    // Option 4: Load a journal from a file

                    // Ask the user for a filename
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();

                    // Call the journal's Load method, which replaces current entries with those from the file
                    myJournal.Load(loadFile);

                    // Confirm to the user
                    Console.WriteLine("Journal loaded successfully!");
                    break;

                case "5":
                    // Option 5: Exit the program

                    // Set running to false to stop the while loop
                    running = false;

                    // Notify the user
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            } // End of switch
        } // End of while loop
    } // End of Main method
} // End of Program class