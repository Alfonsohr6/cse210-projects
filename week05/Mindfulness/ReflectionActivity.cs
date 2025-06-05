
using System;
using System.Collections.Generic;
using System.Threading;

// Ayuda a reflexionar sobre momentos importantes en tu vida
public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        // Mostrar mensaje inicial
        ShowStartMessage("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.");

        Random random = new Random();

        // Seleccionar un prompt aleatorio
        Console.WriteLine("Consider this prompt:");
        Console.WriteLine($"--- {prompts[random.Next(prompts.Count)]} ---\n");

        Console.WriteLine("Now ponder on these questions...\n");
        ShowCountDown(5); // Preparación

        List<string> usedQuestions = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        // Hacer preguntas mientras haya tiempo
        while (DateTime.Now < endTime && questions.Count > 0)
        {
            string question = GetRandomQuestion(questions, ref usedQuestions);
            Console.WriteLine(question);
            ShowSpinner(6);
        }

        // Mostrar mensaje final
        ShowEndMessage("Reflection");
    }

    // Método privado para obtener pregunta aleatoria sin repetir
    private string GetRandomQuestion(List<string> all, ref List<string> used)
    {
        if (used.Count >= all.Count)
            used.Clear(); // Reiniciar lista si se agotaron todas

        Random r = new Random();
        string q;

        do
        {
            q = all[r.Next(all.Count)];
        } while (used.Contains(q));

        used.Add(q);
        return q;
    }
}