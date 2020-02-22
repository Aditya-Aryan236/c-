using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomforce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const float minForce = 3f;
        const float maxforce = 6f;
        float magnitude = Random.Range(minForce, maxforce);
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        GetComponent<Rigidbody2D>().AddForce(magnitude * direction, ForceMode2D.Impulse);
    }

    
}
