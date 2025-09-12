using System;

class Program
{
    static void Main(string[] args)
    {
        // call the functions
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);
    }

    // Función 1: welcome
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Función 2: ask user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Función 3: ask user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Función 4: math
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Función 5: outcome
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}