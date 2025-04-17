using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoseHandler : MonoBehaviour
{
    public GameObject DeathPanel;

    [SerializeField] private TextMeshProUGUI _DaysGone;

    void Start()
    {
        
    }

    public void ShowLoseScreen()
    {
        // Показываем кнопку продолжения
        DeathPanel.SetActive(true);
        _DaysGone.text = "Days survived: " + TotalTime.Day.ToString();
    }

    public void OnContinueAfterLose()
    {
        int slotIndex = PlayerPrefs.GetInt("SaveSlot", 1);

        // Удаляем сейв файл
        string path = Application.persistentDataPath + "/saves/save" + slotIndex + ".json";
        if (System.IO.File.Exists(path))
        {
            System.IO.File.Delete(path);
            Debug.Log("Аккаунт удалён после проигрыша");
        }

        // Можно очистить статические данные, если нужно
        GameStateResetter.ResetAll();

        // Переход в меню
        SceneManager.LoadScene("Meniu"); // Убедись, что сцена называется правильно
    }
}
