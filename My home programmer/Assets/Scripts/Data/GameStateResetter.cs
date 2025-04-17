using UnityEngine;

public static class GameStateResetter
{
    public static void ResetAll()
    {
        TotalTime.Hour = 0;
        TotalTime.Day = 0;

        Health.HealthPoints = 100;
        Eating.EatPoints = 100;
        Sleeping.SleepPoints = 100;

        Balance.Money = 0;

        Hardnes.hardnes = 1;
        Hardnes.Hardnesfactor = 1f;
    }
}

