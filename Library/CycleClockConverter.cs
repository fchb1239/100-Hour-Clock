using System;

public static class CycleClockConverter
{
    public static double Percentage(this DateTime value)
    {
        double percentage = (DateTime.Now.TimeOfDay.Ticks / 864000000000f) * 100;
        return percentage;
    }

    public static double Cycle(this DateTime value)
    {
        var percentage = Percentage(value);
        return Math.Truncate(percentage);
    }

    public static double Moment(this DateTime value)
    {
        var percentage = Percentage(value);
        return Math.Truncate((percentage % 1) * 100);
    }

    public static double Beat(this DateTime value)
    {
        var percentage = Percentage(value);
        return Math.Truncate((((percentage % 1) * 100) % 1) * 100);
    }

    public static DateTime CycleToDateTime(double value)
    {
        long ticks = (long)(value / 100) * 864000000000;
        return new DateTime(ticks);
    }
}
