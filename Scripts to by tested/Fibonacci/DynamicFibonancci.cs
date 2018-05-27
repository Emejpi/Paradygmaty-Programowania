using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicFibonancci : SpeedTesting {

    public int value;

    public override void TestMethode()
    {
        Fibonancci(value);
    }

    public static int Fibonancci(int n)
    {
        if (n < 2)
            return n;
        else
            return Fibonancci(n - 1) + Fibonancci(n - 2);
    }

}
