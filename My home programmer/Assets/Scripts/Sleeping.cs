using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleeping : MonoBehaviour
{
    public static int DopTimeSleep;

    public void Sleep()
    {
        TotalTime.Hour += 8;

        if (TotalTime.Hour >= 24)
        {
            TotalTime.Hour -= 24; // ��������� ��������� �� ��������� ����
            TotalTime.Day += 1;   // ��������� ����� ����
        }

    }
}

