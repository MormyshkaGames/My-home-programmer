using UnityEngine;
using UnityEngine.EventSystems;

public class StatsOfFood : MonoBehaviour
{
    [SerializeField] private GameObject[] statPanels;   // Панели со статистикой
    [SerializeField] private GameObject[] foodPanels;   // Панели еды

    private int currentShown = -1;

    void Start()
    {
        // Навешиваем события на foodPanels
        for (int i = 0; i < foodPanels.Length; i++)
        {
            int index = i;

            EventTrigger trigger = foodPanels[i].GetComponent<EventTrigger>();
            if (trigger == null) trigger = foodPanels[i].AddComponent<EventTrigger>();

            // Наведение мыши
            var entryEnter = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerEnter
            };
            entryEnter.callback.AddListener((data) => ShowStatPanel(index));
            trigger.triggers.Add(entryEnter);

            // Уход мыши
            var entryExit = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerExit
            };
            entryExit.callback.AddListener((data) => HideStatPanel(index));
            trigger.triggers.Add(entryExit);
        }

        HideAllStatPanels();
    }

    void ShowStatPanel(int index)
    {
        if (currentShown != -1 && currentShown != index)
            statPanels[currentShown].SetActive(false);

        statPanels[index].SetActive(true);
        currentShown = index;
    }

    void HideStatPanel(int index)
    {
        if (index == currentShown)
        {
            statPanels[index].SetActive(false);
            currentShown = -1;
        }
    }

    void HideAllStatPanels()
    {
        foreach (var panel in statPanels)
        {
            panel.SetActive(false);
        }
        currentShown = -1;
    }
}

