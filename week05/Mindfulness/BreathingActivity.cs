
using System;
using System.Threading;

// Actividad enfocada en respiración controlada
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        // Mostrar mensaje inicial
        ShowStartMessage("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.");

        int cycles = Duration / 8; // Cada ciclo toma 8 segundos (4 in + 4 out)

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4); // 4 segundos para inhalar

            Console.WriteLine("Breathe out...");
            ShowCountDown(4); // 4 segundos para exhalar
        }

        // Mostrar mensaje final
        ShowEndMessage("Breathing");
    }
}