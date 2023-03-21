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
    public GameObject success;
    public GameManager gameManager;
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

        
    }

    private void OnTriggerEnter(Collider other)
    {
         if(other.tag == "cat")
        {
            canvas.gameObject.SetActive(true);
        }

        if (other.tag == "Complete")
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

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "cat")
        {
            if (fill.fillAmount == 1)
            {
                cat.SetActive(false);
                pickupcat.SetActive(true);
                fill.fillAmount = 0;
                canvas.gameObject.SetActive(false);
            }
        }

        if (other.tag == "Complete" && fill.fillAmount == 1)
        {
            pickupcat.SetActive(false);
            canvas.gameObject.SetActive(false);
            success.gameObject.SetActive(true);
            gameManager.level1_Clear = true;
            Time.timeScale = 0;
        }
    }
}
