using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resize : MonoBehaviour
{
    int signmultiplier = 1;
    float elapsedTime = 0;
    float totalsecs = 2;
    int scalefactor = 1;
   
    // Update is called once per frame
    void Update()
    {
        Vector3 newsacle = transform.localScale;
        newsacle.x += signmultiplier*scalefactor* Time.deltaTime;
        newsacle.y += signmultiplier*scalefactor*Time.deltaTime;
        transform.localScale = newsacle;

        elapsedTime += Time.deltaTime;
        if(elapsedTime>=totalsecs)
        {
            signmultiplier *= -1;
            elapsedTime = 0;
        }


    }
}
