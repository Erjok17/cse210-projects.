using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string Date => _date;
    public int Minutes => _minutes;

    public abstract double GetDistance(); // Abstract
    public abstract double GetSpeed();    // Abstract
    public abstract double GetPace();     // Abstract

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}