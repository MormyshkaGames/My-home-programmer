using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanelAnim : MonoBehaviour
{
    public Animator anim;

    public void DisableSelf()
    {
        anim = GetComponent<Animator>();
        anim.ResetTrigger("Open");
        gameObject.SetActive(false);
    }
}
