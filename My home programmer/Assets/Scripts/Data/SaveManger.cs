using System.IO;
using UnityEngine;

public static class SaveManager
{
    private static string saveDirectory = Application.persistentDataPath + "/saves/";

    // ��������� ���� ���������� �� �������
    private static string GetSavePath(int saveIndex)
    {
        return saveDirectory + "save" + saveIndex + ".json";
    }

    // ���������� ������ ���� � ���� �� �������
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

    // �������� ������ ���� �� ����� �� �������
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

    // ��������, ���������� �� ����������
    public static bool SaveExists(int saveIndex)
    {
        string path = GetSavePath(saveIndex);
        return File.Exists(path);
    }
}

