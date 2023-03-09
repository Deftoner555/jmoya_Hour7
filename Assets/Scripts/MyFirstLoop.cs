using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstLoop : MonoBehaviour
{
    // all of these loops are doing the same task
    void Start()
    {
        //put together a loop that outputs 9 - 0
        int count = 9;
        do
        {
            count--;
            Debug.Log("This is my count " + count);
        }
        while (count > 0);

        count = 9;
        while (count > 0)
        {
            count--;
            Debug.Log("This is my count " + count);
        }

        for(int i = 10; i > 0; i--)
        {
            Debug.Log("This is my count " + count);
        }

    }
 
}
