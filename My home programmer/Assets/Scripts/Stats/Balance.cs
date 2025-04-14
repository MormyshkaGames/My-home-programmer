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

        if (Money < 0)
        {
            Money = 0;
        }

        _Balance.text = Money.ToString() + "$";
    }

    public static int GetMoney() => Money;
    public static void SetMoney(int money) => Money = money;
}

