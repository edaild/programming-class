using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        int number = 10;
        Debug.Log(number);
        Debug.Log(number++);
        Debug.Log(number--);
        Debug.Log(number);

        Debug.Log(number);
        Debug.Log(++number);
        Debug.Log(--number);
        Debug.Log(number);

    }

}
