using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunWithOut : SpeedTesting {

    int a;

    public override void TestMethode()
    {
        Get2Zeros(out a);
    }

    public int Get2Zeros(out int a)
    {
        a = 0;
        return 0;
    }
}
