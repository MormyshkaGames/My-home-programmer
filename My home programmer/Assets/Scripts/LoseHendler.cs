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
        // ���������� ������ �����������
        DeathPanel.SetActive(true);
        _DaysGone.text = "Days survived: " + TotalTime.Day.ToString();
    }

    public void OnContinueAfterLose()
    {
        int slotIndex = PlayerPrefs.GetInt("SaveSlot", 1);

        // ������� ���� ����
        string path = Application.persistentDataPath + "/saves/save" + slotIndex + ".json";
        if (System.IO.File.Exists(path))
        {
            System.IO.File.Delete(path);
            Debug.Log("������� ����� ����� ���������");
        }

        // ����� �������� ����������� ������, ���� �����
        GameStateResetter.ResetAll();

        // ������� � ����
        SceneManager.LoadScene("Meniu"); // �������, ��� ����� ���������� ���������
    }
}
