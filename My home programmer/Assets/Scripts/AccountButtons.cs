using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AccountButtons : MonoBehaviour
{
    public GameObject ButtonNewGame1, ButtonNewGame2, ButtonNewGame3;
    public GameObject ButtonAccount1, ButtonAccount2, ButtonAccount3;

    public TextMeshProUGUI dayText1, dayText2, dayText3;
    public TextMeshProUGUI HardText1, HardText2, HardText3;

    void Start()
    {
        SetupSlot(1, ButtonNewGame1, ButtonAccount1, dayText1, HardText1);
        SetupSlot(2, ButtonNewGame2, ButtonAccount2, dayText2, HardText2);
        SetupSlot(3, ButtonNewGame3, ButtonAccount3, dayText3, HardText3);
    }

    void SetupSlot(int slot, GameObject newGameBtn, GameObject accountBtn, TextMeshProUGUI dayText, TextMeshProUGUI HardText)
    {
        if (SaveManager.SaveExists(slot))
        {
            SaveData data = SaveManager.LoadGame(slot);
            newGameBtn.SetActive(false);
            accountBtn.SetActive(true);

            dayText.text = "Day: " + data.Day.ToString();
            if(data.hardnes == 1)
            {
                HardText.text = "Hardnes: Easy";
            }
            if(data.hardnes == 2)
            {
                HardText.text = "Hardnes: Medium";
            }
            if (data.hardnes == 3)
            {
                HardText.text = "Hardnes: Hard";
            }
            if (data.hardnes == 4)
            {
                HardText.text = "Hardnes: Extreme";
            }
        }
        else
        {
            newGameBtn.SetActive(true);
            accountBtn.SetActive(false);
            dayText.text = ""; // очищаем текст если нет сейва
            HardText.text = "";
        }
    }

    public void CreateAccount(int slotIndex)
    {
        PlayerPrefs.SetInt("SaveSlot", slotIndex);
        PlayerPrefs.Save();
        Debug.Log("Создан аккаунт в слоте: " + slotIndex);
    }

    public void DeleteAccount(int slotIndex)
    {
        string path = Application.persistentDataPath + "/saves/save" + slotIndex + ".json";
        if (System.IO.File.Exists(path))
        {
            System.IO.File.Delete(path);
            Debug.Log("Удалён слот: " + slotIndex);
        }

        // Обновить интерфейс после удаления
        Start();
    }
}


