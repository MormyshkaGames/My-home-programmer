using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static void SaveGameData(int saveIndex)
    {
        SaveData data = new SaveData
        {
            money = Balance.GetMoney(),
            Hour = TotalTime.GetHour(),
            Day = TotalTime.GetDay(),
            EatPoints = Eating.GetEatPoints(),
            HealthPoints = Health.GetHealthPoints(),
            SleepPoints = Sleeping.GetSleepPoints()
        };

        SaveManager.SaveGame(data, saveIndex);
    }

    public static void LoadGameData(int saveIndex)
    {
        SaveData data = SaveManager.LoadGame(saveIndex);
        if (data != null)
        {
            Balance.SetMoney(data.money);
            TotalTime.SetHour(data.Hour);
            TotalTime.SetDay(data.Day);
            Eating.SetEatPoints(data.EatPoints);
            Health.SetHealthPoints(data.HealthPoints);
            Sleeping.SetSleepPoints(data.SleepPoints);
        }
        else
        {
            Debug.LogWarning("Файл не найден. Создаю новые данные для слота " + saveIndex);

            SaveData newData = new SaveData
            {
                money = 0,
                Hour = 0,
                Day = 0,
                EatPoints = 100,
                HealthPoints = 100,
                SleepPoints = 100
            };
            SaveManager.SaveGame(newData, saveIndex);
            Balance.SetMoney(newData.money);
            TotalTime.SetHour(newData.Hour);
            TotalTime.SetDay(newData.Day);
            Eating.SetEatPoints(newData.EatPoints);
            Health.SetHealthPoints(newData.HealthPoints);
            Sleeping.SetSleepPoints(newData.SleepPoints);
        }
    }
}



