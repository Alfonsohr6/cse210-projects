// Scripture.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public ScriptureReference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();

        foreach (string word in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            Words.Add(new Word(word));
        }
    }

    // Muestra la escritura actual
    public void Display()
    {
        Console.WriteLine(Reference);
        foreach (Word word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }

    // Oculta cierta cantidad de palabras que no están ocultas
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> availableWords = Words.Where(w => !w.IsHidden).ToList();

        numberToHide = Math.Min(numberToHide, availableWords.Count);

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(availableWords.Count);
            availableWords[index].Hide();
            availableWords.RemoveAt(index); // Evita repetir
        }
    }

    // Verifica si todas las palabras están ocultas
    public bool IsCompletelyHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}