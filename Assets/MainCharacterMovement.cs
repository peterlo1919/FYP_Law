using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterMovement : MonoBehaviour
{
    public Vector3 moveDirection = Vector3.zero;
    public float rotateSpeed ;
    public float moveSpeed;
    public GameObject slowdownHitbox;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed, 0);
        moveVertical *= Time.deltaTime * moveSpeed;
        moveDirection *= Time.deltaTime * moveSpeed;
        transform.Translate(moveDirection,0,moveVertical);

        if (Input.GetMouseButton(0))
        {
            slowdownHitbox.SetActive(true);
        }
        else
        {
            slowdownHitbox.SetActive(false);
        }
    }
}
