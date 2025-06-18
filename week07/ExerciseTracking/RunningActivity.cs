using System;

public class RunningActivity : Activity
{
    private double _distanceInMiles;

    public RunningActivity(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distanceInMiles = distance;
    }

    public override double GetDistance()
    {
        return _distanceInMiles; // Ya está en millas
    }

    public override double GetSpeed()
    {
        return (_distanceInMiles / GetMinutes()) * 60; // mph
    }

    public override double GetPace()
    {
        return GetMinutes() / _distanceInMiles; // min/mile
    }
}