public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            base.RecordEvent(); // Llama al método base
            _isComplete = true;
            Console.WriteLine("Goal completed!");
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {Name}: {Description}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Description},{PointsValue},{IsComplete()}";
    }
}