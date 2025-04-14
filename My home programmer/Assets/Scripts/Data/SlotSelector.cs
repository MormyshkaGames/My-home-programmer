using UnityEngine;

public class SlotSelector : MonoBehaviour
{
    public static int SelectedSlot;

    public void SetSlot(int slotIndex)
    {
        PlayerPrefs.SetInt("SaveSlot", slotIndex);
        PlayerPrefs.Save();
        Debug.Log("������ ����: " + slotIndex);
    }
}
