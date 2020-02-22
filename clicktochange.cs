using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicktochange : MonoBehaviour
{
    [SerializeField]
    GameObject teddy1;
    [SerializeField]
    GameObject teddy2;
    [SerializeField]
    GameObject teddy3;

    bool previousinput=false;

    GameObject current;

    void Start()
    {
        current = Instantiate<GameObject>(teddy1, Vector3.zero, Quaternion.identity);  
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (previousinput == false)
            {
                previousinput = true;
                Vector3 position = Input.mousePosition;
                position.z = -Camera.main.transform.position.z;
                Vector3 worldpoint = Camera.main.ScreenToWorldPoint(position);
                Destroy(current);
                int lord = Random.Range(0, 3);
                if (lord == 0)
                {
                    current = Instantiate(teddy1, worldpoint, Quaternion.identity);
                }
                else if (lord == 1)
                {
                    current = Instantiate(teddy2, worldpoint, Quaternion.identity);
                }
                else
                {
                    current = Instantiate(teddy3, worldpoint, Quaternion.identity);
                }
            }
        }
        else
        {
            previousinput = false;
        }
        
    }
}
