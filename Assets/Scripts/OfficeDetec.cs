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
    public GameManager gameManager;
    public GameObject Level1;
    public GameObject Level1_info;
    public GameObject Level2;
    public GameObject Level2_Mission;
    public GameObject Level2_info; 
    public GameObject Level3;
    public GameObject Level3_Mission;
    public GameObject Level3_info;

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
            Level3.SetActive(false);
        }
        if (gameManager.level2_Clear == true)
        {
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(true);
        }
        Level1_UI();
        Level2_UI();
        Level3_UI();
       
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
        Level1_info.gameObject.SetActive(true);
        
    }
    
    public void BackInfo()
    {
        mission.gameObject.SetActive(true);
        Level1_info.gameObject.SetActive(false);

    } 
    
    public void Info2()
    {
        mission.gameObject.SetActive(false);
        Level2_info.gameObject.SetActive(true);
        
    }
    
    public void BackInfo2()
    {
        mission.gameObject.SetActive(true);
        Level2_info.gameObject.SetActive(false);

    } 
    
    public void Info3()
    {
        mission.gameObject.SetActive(false);
        Level3_info.gameObject.SetActive(true);
        
    }
    
    public void BackInfo3()
    {
        mission.gameObject.SetActive(true);
        Level3_info.gameObject.SetActive(false);

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
    
    void Level3_UI()
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
            Level3_Mission.gameObject.SetActive(true);
            Level3_Mission.gameObject.transform.DOScale(1f, 0.1f).SetEase(Ease.OutBounce);
        }
    }
}
