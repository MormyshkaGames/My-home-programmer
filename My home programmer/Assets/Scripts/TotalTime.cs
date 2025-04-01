using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalTime : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _Time;
    [SerializeField] private TextMeshProUGUI _DaysGone;

    private float _timeHour = 15f;
    public static int Hour;
    public static int Day;

    void Start()
    {
        Hour = 0;
        Day = 0;
    }

    void Update()
    {
        if (Hour == 0)
        {
            _Time.text = "12 Am";
        }
        else if (Hour < 12)
        {
            _Time.text = Hour.ToString() + " Am";
        }
        else if (Hour == 12)
        {
            _Time.text = "12 Pm";
        }
        else
        {
            _Time.text = (Hour - 12).ToString() + " Pm";
        }

        _DaysGone.text = "Day: " + Day.ToString();

        _timeHour -= Time.deltaTime;
        if (_timeHour <= 0)
        {
            Hour += 1;
            if (Hour >= 24)
            {
                Hour = 0;
                Day += 1;
            }
            _timeHour = 15f;
        }
    }
}


