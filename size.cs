using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size : MonoBehaviour
{
    public float j;
    
    
    void Start()
    {
        Vector3 new_size = transform.localScale;
        new_size.x*=j;
        transform.localScale = new_size;
        







    }

    
}
