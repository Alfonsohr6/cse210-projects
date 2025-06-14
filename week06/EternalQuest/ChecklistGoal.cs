public class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _bonusPoints;
    private int _amountCompleted;

    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonusPoints)
        : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _bonusPoints = bonusPoints;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _requiredCount)
        {
            _amountCompleted++;
            int totalPoints = PointsValue + (_amountCompleted == _requiredCount ? _bonusPoints : 0);
            Console.WriteLine($"You gained {totalPoints} points.");

            if (_amountCompleted == _requiredCount)
            {
                Console.WriteLine("¡Meta completada! Has recibido un bono especial.");
            }
        }
        else
        {
            Console.WriteLine("Esta meta ya está completa. ¡No puedes ganar más puntos!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _requiredCount;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {Name}: {Description} (Completed {_amountCompleted}/{_requiredCount})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{PointsValue},{_requiredCount},{_bonusPoints},{_amountCompleted}";
    }
}