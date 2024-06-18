using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] digitGroups = phoneNumber.Split('-');
        bool isNewYork = digitGroups[0].Equals("212");
        bool isFake = digitGroups[1].Equals("555");
        string localNumber = digitGroups[2];

        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
