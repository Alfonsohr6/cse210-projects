using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000.0 * 0.62, 2); // Convertir a millas
    }

    public override double GetSpeed()
    {
        double distanceInMiles = _laps * 50 / 1000.0 * 0.62;
        return (distanceInMiles / GetMinutes()) * 60; // mph
    }

    public override double GetPace()
    {
        double distanceInMiles = _laps * 50 / 1000.0 * 0.62;
        return GetMinutes() / distanceInMiles; // min/mile
    }
}