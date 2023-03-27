using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CarSpeed : MonoBehaviour
{
    public float speed;
    float horizontalInput;
    public Rigidbody rb;
    public GameObject win_Screen;
    // Start is called before the first frame
    void Start()
    {
       
    }

    void FixedUpdate()
    {
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        Vector3 forwardMove = transform.forward * speed * Time.deltaTime;
        rb.MovePosition(rb.position + horizontalMove + forwardMove);
        speed += 1 * Time.deltaTime;
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
        {
            speed -= 3;
        }
        if (other.tag == "Enemy_Car")
        {
            win_Screen.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
