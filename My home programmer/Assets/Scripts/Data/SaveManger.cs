using System.IO;
using UnityEngine;

public static class SaveManager
{
    private static string saveDirectory = Application.persistentDataPath + "/saves/";

    // Получение пути сохранения по индексу
    private static string GetSavePath(int saveIndex)
    {
        return saveDirectory + "save" + saveIndex + ".json";
    }

    // Сохранение данных игры в файл по индексу
    public static void SaveGame(SaveData data, int saveIndex)
    {
        if (!Directory.Exists(saveDirectory))
        {
            Directory.CreateDirectory(saveDirectory);
        }

        string path = GetSavePath(saveIndex);
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(path, json);
    }

    // Загрузка данных игры из файла по индексу
    public static SaveData LoadGame(int saveIndex)
    {
        string path = GetSavePath(saveIndex);
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<SaveData>(json);
        }
        return null;
    }

    // Проверка, существует ли сохранение
    public static bool SaveExists(int saveIndex)
    {
        string path = GetSavePath(saveIndex);
        return File.Exists(path);
    }
}

