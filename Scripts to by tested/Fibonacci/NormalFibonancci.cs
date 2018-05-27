using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalFibonancci : SpeedTesting {

    public int value;

    public override void TestMethode()
    {
        Fibonancci(value);
    }

    public static long Fibonancci(int n)
    {
        long a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            b += a;
            a = b - a;
        }

        return b;
    }

}
