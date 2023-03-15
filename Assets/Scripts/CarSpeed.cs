using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CarSpeed : MonoBehaviour
{
    public float speed;
    float horizontalInput;
    public Rigidbody rb;
    // Start is called before the first frame
    void Start()
    {
       
    }

    void FixedUpdate()
    {
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        Vector3 forwardMove = transform.forward * speed * Time.deltaTime;
        rb.MovePosition(rb.position + horizontalMove + forwardMove);
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }


}
