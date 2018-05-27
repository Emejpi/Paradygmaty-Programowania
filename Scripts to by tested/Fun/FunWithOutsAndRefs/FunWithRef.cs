using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunWithRef : SpeedTesting {

    int a;

    public override void TestMethode()
    {
        Get2Zeros(ref a);
    }

    public int Get2Zeros(ref int a)
    {
        a = 0;
        return 0;
    }
}
