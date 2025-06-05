
using System;
using System.Threading;

// Clase base para todas las actividades
public class Activity
{
    protected int Duration; // Variable protegida para ser usada por subclases

    // Muestra mensaje inicial de la actividad
    public void ShowStartMessage(string name, string description)
    {
        Console.WriteLine($"Starting {name} activity");
        Console.WriteLine(description);
        Console.Write("How long would you like for this session? (seconds): ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(5); // Animación de preparación
    }

    // Muestra mensaje final de la actividad
    public void ShowEndMessage(string name)
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {name} activity.");
        ShowSpinner(5);
    }

    // Animación tipo spinner
    public void ShowSpinner(int seconds)
    {
        string[] animation = { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animation[i % animation.Length]);
            Thread.Sleep(500);
            Console.Write("\b \b"); // Borra el último caracter
            i++;
        }
        Console.WriteLine();
    }

    // Conteo regresivo
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b"); // Limpia número después de mostrarlo
        }
        Console.WriteLine();
    }
}