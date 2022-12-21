using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime,0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Block")
        {
            Destroy(gameObject);
        }
    }
}
