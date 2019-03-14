using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesScript : MonoBehaviour
{
    public static int startingLives = 5;
    public static int lives;
    Text livesTxt;
    // Start is called before the first frame update
    void Start()
    {
        lives = startingLives;
        livesTxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        livesTxt.text = "Lives: " + lives + " / " + startingLives;
        if (lives <= 0)
        {
            livesTxt.text = "YOU LOST";

            ScoreScript.scores.Add(ScoreScript.currentScore);
            ScoreScript.scores.Sort();
            ScoreScript.scores.Reverse();

            print(ScoreScript.scores.Count);

            for (int i = 0; i < 10; i++)
            {
                print($"Scores{i}: {ScoreScript.scores[i]}");
                print($"Player HighScores{i}: {PlayerPrefs.GetInt($"High Score{i}")}");
                PlayerPrefs.SetInt($"High Score{i}", ScoreScript.scores[i]);
            }

            EndGameScrene();
        }

    }

    public void EndGameScrene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
