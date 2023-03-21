using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class OfficeDetec : MonoBehaviour
{
    public Canvas canvas;
    public GameObject mission;
    public Image fill;
    public GameObject borad;
    public GameObject pickupcat;
    public GameObject info;
    public GameManager gameManager;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level2_Mission;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameManager.level1_Clear == true)
        {
            Level1.SetActive(false);
            Level2.SetActive(true);
        }
        Level1_UI();
        Level2_UI();
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "board")
        {
            canvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "board")
        {
            canvas.gameObject.SetActive(false);
        }
    }

    public void Info()
    {
        mission.gameObject.SetActive(false);
        info.gameObject.SetActive(true);
        
    }
    
    public void BackInfo()
    {
        mission.gameObject.SetActive(true);
        info.gameObject.SetActive(false);

    }

    void Level1_UI()
    {
        if (Input.GetKey("e") && canvas.isActiveAndEnabled == true)
        {
            fill.fillAmount += 1f * Time.deltaTime;
        }
        else if (fill.fillAmount < 1)
        {
            fill.fillAmount -= 1f * Time.deltaTime;
        }

        if (fill.fillAmount == 1)
        {
            canvas.gameObject.SetActive(false);
            mission.gameObject.SetActive(true);
            mission.gameObject.transform.DOScale(1f, 0.1f).SetEase(Ease.OutBounce);
        }
    } 
    void Level2_UI()
    {
        if (Input.GetKey("e") && canvas.isActiveAndEnabled == true)
        {
            fill.fillAmount += 1f * Time.deltaTime;
        }
        else if (fill.fillAmount < 1)
        {
            fill.fillAmount -= 1f * Time.deltaTime;
        }

        if (fill.fillAmount == 1)
        {
            canvas.gameObject.SetActive(false);
            Level2_Mission.gameObject.SetActive(true);
            Level2_Mission.gameObject.transform.DOScale(1f, 0.1f).SetEase(Ease.OutBounce);
        }
    }
}
