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

        if (speed >= 80 && speed <= 99)
        {
            speed = speed + (5 * Time.deltaTime);
        }
        else if (speed == 100)
        {
            speed = 100;
        }
    }    

   
}
