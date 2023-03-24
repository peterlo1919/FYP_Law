using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePause = false;
    
    public GameObject pauseUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){

        if (GamePause)
        {
            Resume();
        } 
        else
        {
            Pause();
        }
        }
    }
  
    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }

    public void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
