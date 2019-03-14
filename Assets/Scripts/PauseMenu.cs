﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    void Start()
    {
        gameIsPaused = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            if (gameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
            
        }
        
    }

    
    public void ResumeGame()
    {
        Time.timeScale = 1;
        gameIsPaused = false;
        SceneManager.UnloadSceneAsync(4);
    }
    
    public void PauseGame()
    {
        Time.timeScale = 0;
        gameIsPaused = true;
        SceneManager.LoadScene(4, LoadSceneMode.Additive);
    }
}
