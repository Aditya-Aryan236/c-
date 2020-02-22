using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 680;
       // Debug.Log("enter score");
        int score = 50;
        float a = ((float)score / max) * 100;
        Debug.Log("it's " + a);
        
    }

   
}
