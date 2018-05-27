using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunWithStructs : SpeedTesting {

    public MyStruct myStruct;

    public override void TestMethode()
    {
        //MyStruct myStructNew = 
        MakeFun(myStruct);
        //print("orginal struct a:" + myStruct.a + " t:" + myStruct.t + " listCount:" + myStruct.list.Count);
        //print("new struct a:" + myStructNew.a + " t:" + myStructNew.t + " listCount:" + myStruct.list.Count);
    }

    public MyStruct MakeFun(MyStruct myStruct)
    {
        myStruct.a = Random.Range(0, 100);
        if (myStruct.list.Count > 0)
        {
            myStruct.t = myStruct.list[Random.Range(0, myStruct.list.Count)];
            myStruct.list.RemoveAt(0);
        }
        if (myStruct.list.Count > 0)
            return MakeFun(myStruct);
        return myStruct;
    }

}
