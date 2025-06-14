public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        base.RecordEvent(); // Gana puntos cada vez
    }

    public override bool IsComplete()
    {
        return false; // Nunca se completa
    }

    public override string GetDetailsString()
    {
        return $"[ ] {Name}: {Description} (Eternal)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Description},{PointsValue}";
    }
}