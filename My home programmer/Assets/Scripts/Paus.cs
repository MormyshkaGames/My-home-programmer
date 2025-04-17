using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paus : MonoBehaviour
{
    public bool PauseGame;
    public GameObject PanelPaus;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PanelPaus.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        PanelPaus.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void LoadMeniu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Meniu");
    }
}
