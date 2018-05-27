using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursiveFactorial : SpeedTesting {

    public int value;

    public override void TestMethode()
    {
        Factorial(value);
    }

    public static int Factorial(int k)
    {
        if (k == 0)
            return 1;
        else
            return k * Factorial(k - 1);
    }

}
