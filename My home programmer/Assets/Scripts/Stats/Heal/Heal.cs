using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Heal : MonoBehaviour
{
    [System.Serializable]
    public struct HealData
    {
        public int eatPoints;
        public int energy;
        public int health;
        public int cost;
    }

    [SerializeField] private Button[] buttons;
    [SerializeField] private HealData[] healData;

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i;
            buttons[i].onClick.AddListener(() =>
            {
                TryBuyHeal(index);
            });
        }
    }

    void TryBuyHeal(int index)
    {
        HealData data = healData[index];

        if (Balance.Money >= data.cost)
        {
            Balance.Money -= data.cost;
            ApplyHealEffects(data);

            int slot = PlayerPrefs.GetInt("SaveSlot", 1);
            SaveSystem.SaveGameData(slot);
        }
        else
        {
            Debug.Log("Недостаточно денег!");
        }
    }

    void ApplyHealEffects(HealData data)
    {
        Eating.EatPoints += data.eatPoints;
        Sleeping.SleepPoints += data.energy;
        Health.HealthPoints += data.health;
    }
}
