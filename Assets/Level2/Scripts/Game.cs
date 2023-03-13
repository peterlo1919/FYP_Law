using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public int cats;
    public int totalCat;

    public Text scoreText;
    public Text TimeText;

    int score;
    public float Endtime = 180;

    public GameObject EndScreen;
    public GameObject WinScreen;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Dcat")
        {
            Debug.Log("you get it");
            cats = cats + 1;
            Destroy(other.gameObject);
            score++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        UpdateTime();

    }

    void UpdateTime()
    {
        Endtime -= Time.deltaTime;
        TimeText.text="Time: " + Endtime;
        if(Endtime < 0)
        {
            Endgame();
        }
    }

    void Endgame()
    {
        Time.timeScale = 0f;
        EndScreen.SetActive(true);
    }

    void UpdateScore()
    {
        scoreText.text ="Cat " + score + "/" +totalCat;
        if(score == totalCat)
        {
            Time.timeScale = 0f;
            WinScreen.SetActive(true);
        }
    }
}
