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
        // ������� ������������ ScrollRect
        parentScroll = GetComponentInParent<ScrollRect>();
        // �������� CanvasGroup ���, ����� ������ ����������� �����, �� ������� ��������� ������������
        var cg = GetComponent<CanvasGroup>();
        cg.blocksRaycasts = true;   // ��������, ��� ������ ����� ����������� �����
        cg.interactable = true; // ������ ������������
        cg.alpha = 1f;   // ������� ������ �������
    }

    // ����� ����� �������� ��������������, �������� ��� ������������� ScrollRect
    public void OnInitializePotentialDrag(PointerEventData e)
        => parentScroll?.OnInitializePotentialDrag(e);

    // ����� �������������� ����������
    public void OnBeginDrag(PointerEventData e)
        => parentScroll?.OnBeginDrag(e);

    // ����� �������������� ������������
    public void OnDrag(PointerEventData e)
        => parentScroll?.OnDrag(e);

    // ����� �������������� �������������
    public void OnEndDrag(PointerEventData e)
        => parentScroll?.OnEndDrag(e);

    // ��� ��������� � ������� �������� ���� ��� �������
    public void OnScroll(PointerEventData e)
        => parentScroll?.OnScroll(e);
}



