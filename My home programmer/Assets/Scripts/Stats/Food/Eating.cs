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
    public static float EatPoints = 100;
    public LoseHandler loseHandler;

    public void Update()
    {
        if (EatPoints <= 0)
        {
            loseHandler.ShowLoseScreen();
        }
        if (EatPoints > 100)
        {
            EatPoints = 100;
        }
        EatBar.fillAmount = EatPoints / 100f;
        _ManyEatPoints.text = EatPoints.ToString();
    }
    public static float GetEatPoints() => EatPoints;
    public static void SetEatPoints(float eatPoints) => EatPoints = eatPoints;
}
