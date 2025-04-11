using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class Heal : MonoBehaviour
{
    [SerializeField] private Button[] buttons; // ������ ������
    public int[] values = { 50, 42, 30, 10, 100 }; // �������� ������

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int value = values[i]; // ���� �������� �� �������
            buttons[i].onClick.AddListener(() => ChangeValue(value));
        }
    }

    void ChangeValue(int newValue)
    {
        Health.HealthPoints += newValue;
    }
}
