using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCarSlowDown : MonoBehaviour
{
    public CarMovement carMovement;
    // Start is called before the first frame update
    void Start()
    {
        carMovement = carMovement.GetComponent<CarMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag =="car_tail")
        {
            carMovement.GetComponent<CarMovement>().speed = 0;   
        }
    }
}
