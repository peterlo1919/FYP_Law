using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CarSpeed : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame
    void Start()
    {
       
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

        if (speed <= 2)
        {
            speed = speed + (1 * Time.deltaTime);
        }
        else if (speed == 2)
        {
            speed = 2;
        }
    }    

   
}
