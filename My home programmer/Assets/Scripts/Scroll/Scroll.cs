using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class Scroll : MonoBehaviour,
    IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
    private ScrollRect parentScroll;

    void Awake()
    {
        // Находим родительский ScrollRect
        parentScroll = GetComponentInParent<ScrollRect>();
        // Настроим CanvasGroup так, чтобы кнопки блокировали клики, но события прокрутки передавались
        var cg = GetComponent<CanvasGroup>();
        cg.blocksRaycasts = true;   // Убедимся, что кнопка может блокировать клики
        cg.interactable = true; // Кнопка интерактивна
        cg.alpha = 1f;   // Сделаем кнопку видимой
    }

    // Когда может начаться перетаскивание, передаем это родительскому ScrollRect
    public void OnInitializePotentialDrag(PointerEventData e)
        => parentScroll?.OnInitializePotentialDrag(e);

    // Когда перетаскивание начинается
    public void OnBeginDrag(PointerEventData e)
        => parentScroll?.OnBeginDrag(e);

    // Когда перетаскивание продолжается
    public void OnDrag(PointerEventData e)
        => parentScroll?.OnDrag(e);

    // Когда перетаскивание заканчивается
    public void OnEndDrag(PointerEventData e)
        => parentScroll?.OnEndDrag(e);

    // Для прокрутки с помощью колесика мыши или тачпада
    public void OnScroll(PointerEventData e)
        => parentScroll?.OnScroll(e);
}



