using System.Collections;
using UnityEngine;

public class WhileLoopScript : MonoBehaviour
{
    int cupsInTheSink = 4;


    // Start is called before the first frame update
    void Start()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
        
    }


}
