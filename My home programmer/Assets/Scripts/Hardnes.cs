using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hardnes : MonoBehaviour
{
    public static int hardnes;
    public static float Hardnesfactor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Easy()
    {
        hardnes = 1;
        Hardnesfactor = 1;
        int slot = PlayerPrefs.GetInt("SaveSlot", 1);
        SaveSystem.SaveGameData(slot);
    }
    public void Medium()
    {
        hardnes = 2;
        Hardnesfactor = 1;
        int slot = PlayerPrefs.GetInt("SaveSlot", 1);
        SaveSystem.SaveGameData(slot);
    }
    public void Hard()
    {
        hardnes = 3;
        Hardnesfactor = 1;
        int slot = PlayerPrefs.GetInt("SaveSlot", 1);
        SaveSystem.SaveGameData(slot);
    }
    public void Extreme()
    {
        hardnes = 4;
        Hardnesfactor = 2;
        int slot = PlayerPrefs.GetInt("SaveSlot", 1);
        SaveSystem.SaveGameData(slot);
    }

    public static int GetHardnes() => hardnes;
    public static void SetHardnes(int Hardnes) => hardnes = Hardnes;
}
