using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class Health : MonoBehaviour
{
    [SerializeField] private Image HealthBar;
    [SerializeField] private TextMeshProUGUI _ManyHealthPoints;
    public static float HealthPoints = 100;
    public LoseHandler loseHandler;

    public void Update()
    {
        if (HealthPoints <= 0)
        {
            loseHandler.ShowLoseScreen();
        }
        if (HealthPoints > 100)
        {
            HealthPoints = 100;
        }
        HealthBar.fillAmount = HealthPoints / 100f;
        _ManyHealthPoints.text = HealthPoints.ToString();
    }

    public void Heal()
    {
        HealthPoints += 70;

    }

    public static float GetHealthPoints() => HealthPoints;
    public static void SetHealthPoints(float healthPoints) => HealthPoints = healthPoints;
}