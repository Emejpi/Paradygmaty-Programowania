using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTestingTest : SpeedTesting {

    public override void TestMethode()
    {
        IDoStuff();
    }

    void IDoStuff()
    {
        //print("good");
        for (int i = 0; i < 10000; i++)
        {
            //for (int j = 0; j < 10000; j++)
            //{
            //    for (int h = 0; h < 10000; h++)
            //    {
            //        //for (int g = 0; g < 10000; g++)
            //        //{
            //        //    for (int p = 0; p < 10000; p++)
            //        //    {
            //        //        int q = i ^ 2;
            //        //    }
            //        //    int a = i ^ 2;
            //        //}
            //        int s = i ^ 2;
            //    }
            //    int d = i ^ 2;
            //}
            int y = i ^ 2;
        }
    }
}
