using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed;
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        _speed = speed;
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonUp(0) && speed >= _speed)
        {
            speed = _speed;
        } 

        transform.Translate(new Vector3(0, speed * Time.deltaTime,0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Block")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "SlowDown")
        {
            if (speed < 0)
            {
                speed += 1 ;
            }
            else if(speed >= 0)
            {
                speed = 0;
            }
        }

        if (other.tag == "car")
        {
            Destroy (gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        speed -= 5 ;
        if (speed <= _speed)
        {
            speed = _speed;
        }
    }
}
