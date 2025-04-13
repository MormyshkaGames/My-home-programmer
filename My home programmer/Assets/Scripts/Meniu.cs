using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meniu : MonoBehaviour
{
    public void menuuu(int slotIndex)
    {
        // Сохраняем выбранный слот в PlayerPrefs
        PlayerPrefs.SetInt("SaveSlot", slotIndex);
        PlayerPrefs.Save(); // сохраняем

        Debug.Log("Выбран слот: " + slotIndex); // Проверка в консоли

        // Загружаем сцену игры
        SceneManager.LoadScene("Start");

    }

    public void Exitgame()
    {
        Application.Quit();
    }

    public void YouTube()
    {
        Application.OpenURL("https://youtube.com/@MormyshkaS?si=CvTTAjQfXJUciy-I");
    }

    public void Diskord()
    {
    }
}