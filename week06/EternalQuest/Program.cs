using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        List<Goal> goals = new List<Goal>();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest - Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals and Score");
            Console.WriteLine("4. Save Progress");
            Console.WriteLine("5. Load Progress");
            Console.WriteLine("6. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goals);
                    break;
                case "2":
                    RecordEvent(goals, ref score);
                    break;
                case "3":
                    DisplayGoalsAndScore(goals, score);
                    break;
                case "4":
                    SaveProgress(goals, score);
                    break;
                case "5":
                    LoadProgress(out goals, out score);
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Thanks for using Eternal Quest. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("\nCreate New Goal");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        string type = Console.ReadLine();

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points Value: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                Console.WriteLine("Simple Goal created.");
                break;

            case "2":
                goals.Add(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal Goal created.");
                break;

            case "3":
                Console.Write("Required Count: ");
                int count = int.Parse(Console.ReadLine());

                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());

                goals.Add(new ChecklistGoal(name, description, points, count, bonus));
                Console.WriteLine("Checklist Goal created.");
                break;

            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEvent(List<Goal> goals, ref int score)
    {
        Console.WriteLine("\nChoose a goal to record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the number of the goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    static void DisplayGoalsAndScore(List<Goal> goals, int score)
    {
        Console.WriteLine($"\nCurrent Score: {score}");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    static void SaveProgress(List<Goal> goals, int score)
    {
        using (StreamWriter writer = new StreamWriter("progress.txt"))
        {
            writer.WriteLine(score);

            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Progress saved.");
    }

    static void LoadProgress(out List<Goal> goals, out int score)
    {
        goals = new List<Goal>();
        score = 0;

        if (!File.Exists("progress.txt"))
        {
            Console.WriteLine("No saved progress found.");
            return;
        }

        var lines = File.ReadAllLines("progress.txt");
        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(',');

            switch (parts[0])
            {
                case "SimpleGoal":
                    goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "EternalGoal":
                    goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    goals.Add(new ChecklistGoal(
                        parts[1], 
                        parts[2], 
                        int.Parse(parts[3]), 
                        int.Parse(parts[4]), 
                        int.Parse(parts[5])));
                    break;
            }
        }

        Console.WriteLine("Progress loaded.");
    }
}