// Sorry if there are comments in Spanish, but it's so I don't get lost in the code 
// and can understand what I was supposed to do in each part.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de versículo
        var reference = new ScriptureReference("John", 3, 16);
        var scripture = new Scripture(reference, 
            "For God so loved the world that he gave his one and only Son, " +
            "that whoever believes in him shall not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("You've memorized the entire scripture! Well done!");
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Thanks for using Scripture Memorizer. Goodbye!");
                break;
            }

            scripture.HideRandomWords(3); // Oculta 3 nuevas palabras
        }
    }
}