using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthdayScript : MonoBehaviour
{
    int x = 1;

    void Start()
    {
        while(x <= 12)
        {
            Debug.Log(x);
            x++;
        }
    }
}
