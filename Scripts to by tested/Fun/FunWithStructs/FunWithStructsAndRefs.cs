using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunWithStructsAndRefs : SpeedTesting {

    public MyStruct myStruct;

    public override void TestMethode()
    {
        //MyStruct myStructNew = 
        MakeFun(ref myStruct);
        //print("refs// orginal struct a:" + myStruct.a + " t:" + myStruct.t + " listCount:" + myStruct.list.Count);
        //print("refs// new struct a:" + myStructNew.a + " t:" + myStructNew.t + " listCount:" + myStruct.list.Count);
    }

    public MyStruct MakeFun(ref MyStruct myStruct)
    {
        myStruct.a = Random.Range(0, 100);
        if (myStruct.list.Count > 0)
        {
            myStruct.t = myStruct.list[Random.Range(0, myStruct.list.Count)];
            myStruct.list.RemoveAt(0);
        }
        if (myStruct.list.Count > 0)
            return MakeFun(ref myStruct);
        return myStruct;
    }

}
