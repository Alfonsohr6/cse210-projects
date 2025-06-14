using System;

public abstract class Goal
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int PointsValue { get; private set; }

    protected Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        PointsValue = points;
    }

    // Método virtual para registrar evento – se sobrescribe en las derivadas
    public virtual void RecordEvent()
    {
        Console.WriteLine($"You gained {PointsValue} points.");
    }

    // Devuelve si la meta está completa
    public abstract bool IsComplete();

    // Muestra detalles de la meta (ej: "Completed 2/5 times")
    public abstract string GetDetailsString();

    // Guarda como texto plano – usado para guardar en archivo
    public abstract string GetStringRepresentation();
}