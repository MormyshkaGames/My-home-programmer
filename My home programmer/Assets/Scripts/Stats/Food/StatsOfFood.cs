using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class StatsOfFood : MonoBehaviour
{
    [SerializeField] private GameObject[] statPanels;   // ������ �� �����������
    [SerializeField] private GameObject[] foodPanels;   // ������ ���

    private int currentShown = -1;

    void Start()
    {
        for (int i = 0; i < foodPanels.Length; i++)
        {
            int index = i;

            EventTrigger trigger = foodPanels[i].GetComponent<EventTrigger>();
            if (trigger == null) trigger = foodPanels[i].AddComponent<EventTrigger>();

            // ��������� �� �������
            var entryEnter = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerEnter
            };
            entryEnter.callback.AddListener((data) => OnPointerEnter(index));
            trigger.triggers.Add(entryEnter);

            // ���� � ��������
            var entryExit = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerExit
            };
            entryExit.callback.AddListener((data) => OnPointerExit(index));
            trigger.triggers.Add(entryExit);
        }

        HideAllStatPanels();
    }

    void OnPointerEnter(int index)
    {
        // ����� ��� ��� ������������ ����� ������, ������������ ��� ���������
        HideAllStatPanels();

        // ���������� ������
        ShowStatPanel(index);
    }

    void OnPointerExit(int index)
    {
        // ������� ������ ������ ���� ��� ������� �������� ������
        if (index == currentShown)
        {
            HideStatPanel(index);
        }
    }

    void ShowStatPanel(int index)
    {
        // ���������� ��������� ������
        statPanels[index].SetActive(true);

        // ���������, ���� �� �������� � ������� �� ��
        Animator anim = statPanels[index].GetComponentInChildren<Animator>();
        if (anim != null && anim.isActiveAndEnabled) // ���������, ��� �������� ���������� � �������
        {
            anim.SetBool("isHovered", true);
        }

        currentShown = index;
    }

    void HideStatPanel(int index)
    {
        if (index == currentShown)
        {
            Animator anim = statPanels[index].GetComponentInChildren<Animator>();
            if (anim != null && anim.isActiveAndEnabled)
            {
                anim.SetBool("isHovered", false);
            }

            StartCoroutine(DeactivateAfterDelay(statPanels[index], 0.3f)); // ����� ����� ��������
            currentShown = -1;
        }
    }

    void HideAllStatPanels()
    {
        // ��������� ��� ������
        foreach (var panel in statPanels)
        {
            panel.SetActive(false);

            // ������� ��������
            Animator anim = panel.GetComponentInChildren<Animator>();
            if (anim != null && anim.isActiveAndEnabled)
            {
                anim.SetBool("isHovered", false);
            }
        }

        currentShown = -1;
    }

    IEnumerator DeactivateAfterDelay(GameObject panel, float delay)
    {
        yield return new WaitForSeconds(delay);
        panel.SetActive(false);
    }
}
