using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detect : MonoBehaviour
{
    public Canvas canvas;
    public Image fill;
    public GameObject cat;
    public GameObject pickupcat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e") &&  canvas.isActiveAndEnabled == true)
        {
            fill.fillAmount += 1f * Time.deltaTime;
        }
        else if(fill.fillAmount < 1)
        {
            fill.fillAmount -= 1f * Time.deltaTime;
        }

        if (fill.fillAmount == 1)
        {
            canvas.gameObject.SetActive(false);
            cat.SetActive(false);
            pickupcat.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
         if(other.tag == "cat")
        {
            canvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "cat")
        {
            canvas.gameObject.SetActive(false);
        }
    }
}
