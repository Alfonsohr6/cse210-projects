using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Esta clase maneja todas las entradas del diario
public class Journal
{
    private List<Entry> entries = new List<Entry>();

    // Carga los prompts desde un archivo de texto
    public List<string> LoadPrompts(string filename = "prompts.txt")
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Prompt file not found.");
            return new List<string>();
        }

        return File.ReadAllLines(filename).Where(line => !string.IsNullOrWhiteSpace(line)).ToList();
    }

    // Añade una nueva entrada con un prompt aleatorio
    public void AddEntry()
    {
        var prompts = LoadPrompts();
        var rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        entries.Add(new Entry(prompt, response));
        Console.WriteLine("✅ Entry saved.\n");
    }

    // Muestra todas las entradas guardadas
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nThe journal is empty.");
            return;
        }

        Console.WriteLine("\n=== Your Entries ===\n");
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine(new string('-', 40));
        }
    }

    // Guarda todas las entradas en un archivo
    public void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.ToCsvString());
                }
            }
            Console.WriteLine($"✅ Journal saved to '{filename}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error saving: {ex.Message}");
        }
    }

    // Carga las entradas desde un archivo
    public void LoadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        try
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var entry = Entry.FromCsvLine(line);
                    if (entry != null)
                    {
                        entries.Add(entry);
                    }
                }
            }
            Console.WriteLine($"✅ Journal loaded from '{filename}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error loading: {ex.Message}");
        }
    }
}