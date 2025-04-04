using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class Health : MonoBehaviour
{
    [SerializeField] private Image HealthBar;
    [SerializeField] private TextMeshProUGUI _ManyHealthPoints;
    public static int HealthPoints;

    public void Start()
    {
        HealthPoints = 100;
    }

    public void Update()
    {
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
}