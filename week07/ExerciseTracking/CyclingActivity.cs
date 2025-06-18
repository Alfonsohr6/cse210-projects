using System;

public class CyclingActivity : Activity
{
    private double _distanceInKm;

    public CyclingActivity(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distanceInKm = distance;
    }

    public override double GetDistance()
    {
        return _distanceInKm / 0.62; // Convertir km a millas para uniformidad
    }

    public override double GetSpeed()
    {
        return (_distanceInKm / GetMinutes()) * 60; // kph → convertimos después a mph si queremos
    }

    public override double GetPace()
    {
        return GetMinutes() / _distanceInKm; // min/km
    }
}