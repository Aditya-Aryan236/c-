using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDestroy : MonoBehaviour
{
    [SerializeField]
    GameObject teddy1;
    [SerializeField]
    GameObject explosion;

    bool previousinput = false;
    bool previousexplosion = false;
   
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
                Instantiate<GameObject>(teddy1, worldpoint, Quaternion.identity);
            }

        }
        else
        {
            previousinput = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
            // only explode teddy bear on first frame of input
            if (!previousexplosion)
            {
                // set input flag
                previousexplosion = true;

                // try to find a teddy bear
                GameObject teddyBear = GameObject.FindWithTag("teddy");
                if (teddyBear != null)
                {
                    Instantiate<GameObject>(explosion, teddyBear.transform.position, Quaternion.identity);
                    Destroy(teddyBear);
                }
            }
        }
        else
        {
            // no explode teddy bear input
            previousexplosion = false;
        }




    }
}
