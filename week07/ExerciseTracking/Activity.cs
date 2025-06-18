using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date.ToShortDateString();
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    // Métodos abstractos – deben ser implementados por cada clase derivada
    public abstract double GetDistance();   // En km o millas
    public abstract double GetSpeed();      // En km/h o mph
    public abstract double GetPace();      // En minutos/km o minutos/milla

    // Método común para todos – usa los métodos abstractos
    public virtual string GetSummary()
    {
        return $"{GetDate()} - {this.GetType().Name}: {GetDistance():F2} miles, {GetSpeed():F2} mph, {GetPace():F2} min per mile";
    }
}