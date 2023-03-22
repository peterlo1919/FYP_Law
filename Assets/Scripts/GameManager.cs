using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool level1_Clear = false;
    public bool level2_Clear = false;
    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        level1_Clear = false;
        level2_Clear = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SaveCat()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadInGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(3);
    }
}
