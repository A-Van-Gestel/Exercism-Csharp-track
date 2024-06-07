using System;

static class QuestLogic
{
    // True if the knight is sleeping (not awake).
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    // True if at least one is awake.
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake || archerIsAwake || prisonerIsAwake)
        {
            return true;
        }
        return false;
    }

    // True if the archer is sleeping (not awake) and the prisoner is awake.
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!archerIsAwake && prisonerIsAwake)
        {
            return true;
        }
        return false;
    }

    // True if she has her pet dog with her and the archer is asleep.
    // True if she doesn't have her pet dog with her, the prisoner is awake and both the knight & archer are sleeping (not awake).
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if ((petDogIsPresent && !archerIsAwake) ||
            (!petDogIsPresent && prisonerIsAwake && !archerIsAwake && !knightIsAwake))
        {
            return true;
        }
        return false;
    }
}
