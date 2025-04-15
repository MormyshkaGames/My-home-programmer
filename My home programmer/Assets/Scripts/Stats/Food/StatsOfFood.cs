using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class StatsOfFood : MonoBehaviour
{
    [SerializeField] private GameObject[] statPanels;   // Панели со статистикой
    [SerializeField] private GameObject[] foodPanels;   // Панели еды

    private int currentShown = -1;

    void Start()
    {
        for (int i = 0; i < foodPanels.Length; i++)
        {
            int index = i;

            EventTrigger trigger = foodPanels[i].GetComponent<EventTrigger>();
            if (trigger == null) trigger = foodPanels[i].AddComponent<EventTrigger>();

            // Наведение на продукт
            var entryEnter = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerEnter
            };
            entryEnter.callback.AddListener((data) => OnPointerEnter(index));
            trigger.triggers.Add(entryEnter);

            // Уход с продукта
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
        // Перед тем как активировать новую панель, деактивируем все остальные
        HideAllStatPanels();

        // Активируем панель
        ShowStatPanel(index);
    }

    void OnPointerExit(int index)
    {
        // Убираем панель только если это текущая активная панель
        if (index == currentShown)
        {
            HideStatPanel(index);
        }
    }

    void ShowStatPanel(int index)
    {
        // Активируем выбранную панель
        statPanels[index].SetActive(true);

        // Проверяем, есть ли аниматор и активен ли он
        Animator anim = statPanels[index].GetComponentInChildren<Animator>();
        if (anim != null && anim.isActiveAndEnabled) // Проверяем, что аниматор существует и активен
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

            StartCoroutine(DeactivateAfterDelay(statPanels[index], 0.3f)); // Пауза перед скрытием
            currentShown = -1;
        }
    }

    void HideAllStatPanels()
    {
        // Отключаем все панели
        foreach (var panel in statPanels)
        {
            panel.SetActive(false);

            // Убираем анимацию
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
