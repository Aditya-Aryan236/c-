using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public int x;
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody2D>().AddForce(new Vector2(x,0),ForceMode2D.Impulse);

        
    }

    
}
