using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject creditPanel, settingPanel, storyPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCredit()
    {
        creditPanel.SetActive(true);
    }

    public void ShowSetting()
    {
        settingPanel.SetActive(true);
    }

    public void StartPlay()
    {
        SceneManager.LoadScene("Low Poly Road Pack Demo");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ShowStory()
    {
        storyPanel.SetActive(true);
    }
}
