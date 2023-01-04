using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{ 
    public float rotateSpeed;
    MainCharacterMovement characterMovement;
    // Start is called before the first frame update
    void Start()
    {
        characterMovement = GetComponentInParent<MainCharacterMovement>();
        rotateSpeed = characterMovement.rotateSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-Input.GetAxis("Mouse Y") * rotateSpeed, 0f, 0f);
    }
}
