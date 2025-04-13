using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    [System.Serializable]
    public struct FoodData
    {
        public int eatPoints;
        public int energy;
        public int health;
        public int cost;
    }

    [SerializeField] private Button[] buttons;
    [SerializeField] private FoodData[] foodData;

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i;
            buttons[i].onClick.AddListener(() =>
            {
                TryBuyFood(index);
            });
        }
    }

    void TryBuyFood(int index)
    {
        FoodData data = foodData[index];

        if (Balance.Money >= data.cost)
        {
            Balance.Money -= data.cost;
            ApplyFoodEffects(data);

            int slot = PlayerPrefs.GetInt("SaveSlot", 1);
            SaveSystem.SaveGameData(slot);
        }
        else
        {
            Debug.Log("Недостаточно денег!");
        }
    }

    void ApplyFoodEffects(FoodData data)
    {
        Eating.EatPoints += data.eatPoints;
        Sleeping.SleepPoints += data.energy;
        Health.HealthPoints += data.health;
    }
}
