using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Añadimos una actividad de cada tipo
        activities.Add(new RunningActivity(new DateTime(2024, 10, 1), 30, 3.0));
        activities.Add(new CyclingActivity(new DateTime(2024, 10, 2), 45, 15.0));
        activities.Add(new SwimmingActivity(new DateTime(2024, 10, 3), 30, 40));

        // Mostrar el resumen de todas las actividades
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}