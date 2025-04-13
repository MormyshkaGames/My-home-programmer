using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class Eating : MonoBehaviour
{
    [SerializeField] private Image EatBar;
    [SerializeField] private TextMeshProUGUI _ManyEatPoints;
    public static int EatPoints;

    public void Update()
    {
        if (EatPoints > 100)
        {
            EatPoints = 100;
        }
        EatBar.fillAmount = EatPoints / 100f;
        _ManyEatPoints.text = EatPoints.ToString();
    }
    public static int GetEatPoints() => EatPoints;
    public static void SetEatPoints(int eatPoints) => EatPoints = eatPoints;
}
