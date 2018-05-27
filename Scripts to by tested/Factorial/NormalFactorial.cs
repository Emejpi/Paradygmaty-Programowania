using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalFactorial : SpeedTesting {

    public int value;

    public override void TestMethode()
    {
        Factorial(value);
    }

    public static int Factorial(int k)
    {
        int iloczyn = 1;
        for (int i = 1; i < k; i++)
            iloczyn *= i;
        return iloczyn;
    }

}
