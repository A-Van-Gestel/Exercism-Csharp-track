class Lasagna
{
    private const int TimeInOvenInMinutes = 40;
    private const int TimePerLayerInMinutes = 2;

    // DONE: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return TimeInOvenInMinutes;
    }

    // DONE: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven)
    {
        return ExpectedMinutesInOven() - minutesInOven;
    }

    // DONE: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        return TimePerLayerInMinutes * layers;
    }

    // DONE: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        return PreparationTimeInMinutes(layers) + minutesInOven;
    }

}
