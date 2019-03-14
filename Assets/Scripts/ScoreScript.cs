using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int defaultHighScore = 100;
    public static int highscore0, highscore1, highscore2, highscore3, highscore4, highscore5, highscore6, highscore7, highscore8, highscore9;
    public static int currentScore;
    public static List<int> scores = new List<int>(10);
    Text scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GetComponent<Text>();
        currentScore = 0;
        for (int i = 0; i < 10; i++)
        {
            scores[i] = defaultHighScore;
            if (!PlayerPrefs.HasKey($"High Score{i}"))
            {
                // Check to see if a high score is already saved
                PlayerPrefs.SetInt($"High Score{i}", defaultHighScore); // If it’s not, then save one
            }
        }

        highscore0 = PlayerPrefs.GetInt("High Score0"); // Save the high score as a reference

    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + currentScore + " / Highscore: " + highscore0;
    }
}
