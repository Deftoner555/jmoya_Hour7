using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthdayScript : MonoBehaviour
{
    
    void Start()
    {
        int x = 1;
        while (x <= 12)
        {
            Debug.Log(x);
            x++;

            if (x == 12)
            {
                Debug.Log("It's my birthday month!");
            }

            if (x == 12)
            {
                int d = 1;
                while (d <= 31)
                {
                    Debug.Log(d);
                    d++;

                    if(d == 6)
                    {
                        Debug.Log("It's my birthday!");
                    }

                }

            }

        }
        
    }

}
