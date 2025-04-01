using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Balance : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _Balance;
    public static int Money;

    void Start()
    {
        _Balance.text = Money.ToString() + "$";
    }

    void Update()
    {
        _Balance.text = Money.ToString() + "$";
    }
}
