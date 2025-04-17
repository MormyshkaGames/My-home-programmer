using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Balance : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _Balance;
    public static int Money;
    public static int KMoney;

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

        if (Money > 1000)
        {
            KMoney = Money / 1000;
            _Balance.text = KMoney.ToString("0.0K");
        }
        else
        {
            _Balance.text = Money.ToString();
        }
        
    }

    public static int GetMoney() => Money;
    public static void SetMoney(int money) => Money = money;
}

