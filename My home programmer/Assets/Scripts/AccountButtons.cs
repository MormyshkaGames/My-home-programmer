using System.Collections;
using UnityEngine;
using TMPro;
using System.IO;

public class AccountButtons : MonoBehaviour
{
    public GameObject ButtonNewGame1, ButtonNewGame2, ButtonNewGame3;
    public GameObject ButtonAccount1, ButtonAccount2, ButtonAccount3;

    public TextMeshProUGUI dayText1, dayText2, dayText3;
    public TextMeshProUGUI HardText1, HardText2, HardText3;

    void Start()
    {
        RefreshAllSlots();
    }

    void RefreshAllSlots()
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

            dayText.text = "Day: " + data.Day;

            switch (data.hardnes)
            {
                case 1: HardText.text = "Hardness: Easy"; break;
                case 2: HardText.text = "Hardness: Medium"; break;
                case 3: HardText.text = "Hardness: Hard"; break;
                case 4: HardText.text = "Hardness: Extreme"; break;
                default: HardText.text = "Hardness: Unknown"; break;
            }
        }
        else
        {
            newGameBtn.SetActive(true);
            accountBtn.SetActive(false);
            dayText.text = "";
            HardText.text = "";
        }
    }

    public void CreateAccount(int slotIndex)
    {
        // Устанавливаем активный слот
        PlayerPrefs.SetInt("SaveSlot", slotIndex);
        PlayerPrefs.Save();

        // Сбрасываем все игровые данные
        GameStateResetter.ResetAll();

        // Сохраняем чистый аккаунт
        SaveSystem.SaveGameData(slotIndex);

        Debug.Log("Создан аккаунт в слоте: " + slotIndex);

        // Обновляем интерфейс
        Start();
    }

    public void DeleteAccount(int slotIndex)
    {
        SaveManager.DeleteSave(slotIndex);
        PlayerPrefs.DeleteKey("SaveSlot"); // если нужно сбросить активный слот

        Debug.Log("Удалён аккаунт из слота: " + slotIndex);
        RefreshAllSlots(); // обновить UI
    }
}