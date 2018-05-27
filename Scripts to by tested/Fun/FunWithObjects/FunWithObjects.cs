using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunWithObjects : SpeedTesting {

    public int counter;

    public override void TestMethode()
    {
        MakeFun(new MyClass(counter));
    }

    public void MakeFun(MyClass myObject)
    {
        if (myObject.counter-- > 0)
            MakeFun(myObject);
    }

}
