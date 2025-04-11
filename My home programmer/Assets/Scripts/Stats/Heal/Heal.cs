using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class Heal : MonoBehaviour
{
    [SerializeField] private Button[] buttons; // Массив кнопок
    public int[] values = { 50, 42, 30, 10, 100 }; // Значения кнопок

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int value = values[i]; // Берём значение из массива
            buttons[i].onClick.AddListener(() => ChangeValue(value));
        }
    }

    void ChangeValue(int newValue)
    {
        Health.HealthPoints += newValue;
    }
}
