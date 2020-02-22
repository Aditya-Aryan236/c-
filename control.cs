using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    const float moveunits = 5;

    // Update is called once per frame
    void Update()
    {
        
        float horizontal_input = Input.GetAxis("Horizontal");
        if (horizontal_input != 0)
        {
            Vector3 position = transform.position;
            position.x += horizontal_input * moveunits * Time.deltaTime;
            transform.position = position;
        }
        float vertical_input = Input.GetAxis("Vertical");
        if (vertical_input != 0)
        {
            Vector3 position = transform.position;
            position.y += vertical_input * moveunits * Time.deltaTime;
            transform.position = position;
        }
        
    }
}
