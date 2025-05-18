
using System;
using System.Collections.Generic;

public class Resume
{
    // Atributos
    public string _name;
    public List<Job> _jobs = new List<Job>(); // Lista de trabajos

    // Método para mostrar el currículum completo
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            Console.WriteLine($"- {job.Display()}");
        }
    }
}