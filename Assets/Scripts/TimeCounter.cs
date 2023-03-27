using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeCounter : MonoBehaviour
{
    public Text timeText;
    public float time ;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateTime();
        if (time <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void UpdateTime()
    {
        time -= 1*Time.deltaTime;
        timeText.text = "Time : " + time.ToString("0");
        
    }
}
