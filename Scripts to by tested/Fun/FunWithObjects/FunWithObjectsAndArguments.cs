using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunWithObjectsAndArguments : SpeedTesting {

    public int counter;

    public override void TestMethode()
    {
        MyClass myObject = new MyClass(counter);
        MakeFun(myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.a, myObject.t, myObject.counter);
    }

    public void MakeFun(double a, double a1, double a2, double a3, double a4, double a5, double a6, double a7, double a8, double a9, double a10, double a11, double a12, double a13, double a14, double a15, double a16, double a17, double a18, double a19, double a20, string t, int counter)
    {
        if (counter-- > 0)
            MakeFun(a, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20,t, counter);
    }

}
