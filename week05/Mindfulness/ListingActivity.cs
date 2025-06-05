
using System;
using System.Collections.Generic;
using System.Threading;

// Actividad para listar cosas positivas o personas importantes
public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        // Mostrar mensaje inicial
        ShowStartMessage("Listing", "This activity will help you reflect on the good things in your life by listing items related to a specific prompt.");

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine($"List as many responses as you can to this prompt:");
        Console.WriteLine($"--- {selectedPrompt} ---");
        Console.WriteLine("You have a few seconds to think...");

        ShowCountDown(5); // Conteo antes de empezar a escribir

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        // Recibir respuestas del usuario
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item (or press Enter to finish): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                break;

            items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        ShowEndMessage("Listing");
    }
}