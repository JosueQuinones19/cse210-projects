using System;
using System.Collections.Generic;
using ScriptureMemorizer;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de versículos completos
            var scriptures = new List<(Reference, string)>
            {
                (new Reference("John", 3, 16), 
                 "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
                (new Reference("Proverbs", 3, 5, 6), 
                 "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
                (new Reference("Psalm", 23, 1), 
                 "The Lord is my shepherd, I shall not want. He makes me lie down in green pastures. He leads me beside quiet waters."),
                (new Reference("Philippians", 4, 13), 
                 "I can do all things through Christ who strengthens me."),
                (new Reference("Romans", 8, 28), 
                 "And we know that in all things God works for the good of those who love him, who have been called according to his purpose.")
            };

            // Seleccionar un versículo aleatorio
            Random rnd = new Random();
            var (refVerse, textVerse) = scriptures[rnd.Next(scriptures.Count)];
            Scripture scripture = new Scripture(refVerse, textVerse);

            // Bucle principal
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                scripture.HideRandomWords(); // Oculta palabras aleatorias

                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nAll words are hidden. Program will exit.");
                    break;
                }
            }
        }
    }
}
