using System;

static class AssemblyLine
{
    private const int BaseRate = 221;

    public static double SuccessRate(int speed)
    {
        if (speed is >= 1 and <= 4) return 1;
        if (speed is >= 5 and <= 8) return 0.90;
        if (speed == 9) return 0.80;
        if (speed == 10) return 0.77;
        return 0;
    }

    public static double ProductionRatePerHour(int speed) => BaseRate * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)MathF.Floor((float)ProductionRatePerHour(speed) / 60);
}
