using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Animations : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Animator anim;

    public void OnPointerEnter(PointerEventData eventData)
    {
        anim.SetBool("OnButtonBed", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        anim.SetBool("OnButtonBed", false);
    }
}
