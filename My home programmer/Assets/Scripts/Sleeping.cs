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
    public static int DopTimeSleep;
    public static int SleepPoints;

    public void Start()
    {
        SleepPoints = 100;
    }

    public void Update()
    {   
        if(SleepPoints > 100)
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

        if (TotalTime.Hour >= 24)
        {
            TotalTime.Hour -= 24; // Корректно переходим на следующий день
            TotalTime.Day += 1;   // Добавляем новый день
        }

    }
}

