using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class Sleeping : MonoBehaviour
{
    [SerializeField] private Image SleepBar;
    [SerializeField] private TextMeshProUGUI _ManySleepPoints;
    public static float SleepPoints = 100;
    public LoseHandler loseHandler;

    public void Update()
    {
        if (SleepPoints <= 0)
        {
            loseHandler.ShowLoseScreen();
        }
        if (SleepPoints > 100)
        {
            SleepPoints = 100;
        }
        SleepBar.fillAmount = SleepPoints / 100f;
        _ManySleepPoints.text = SleepPoints.ToString();
    }

    public void Sleep()
    {
        SleepPoints += 70;
        TotalTime.Hour += 8;
        Eating.EatPoints -= 10 * Hardnes.Hardnesfactor;
        Health.HealthPoints -= 10 * Hardnes.Hardnesfactor;

        if (TotalTime.Hour >= 24)
        {
            TotalTime.Hour -= 24; // Корректно переходим на следующий день
            TotalTime.Day += 1;   // Добавляем новый день
        }
        int slot = PlayerPrefs.GetInt("SaveSlot", 1);
        SaveSystem.SaveGameData(slot);
    }

    public static float GetSleepPoints() => SleepPoints;
    public static void SetSleepPoints(float sleepPoints) => SleepPoints = sleepPoints;
}

