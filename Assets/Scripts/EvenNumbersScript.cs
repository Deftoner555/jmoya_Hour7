using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenNumbersScript : MonoBehaviour
{
    int x = 22;

   

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start at 22");
        while (x <= 100) 
        {
            Debug.Log(x);
            x = x + 2;
        }

    }
}