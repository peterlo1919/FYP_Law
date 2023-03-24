using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeCounter : MonoBehaviour
{
    public Text timeText;
    public float time ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateTime();
    }

    void UpdateTime()
    {
        time -= 1*Time.deltaTime;
        timeText.text = "Time : " + time.ToString("0");
        
    }
}
