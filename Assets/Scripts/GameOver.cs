using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameController gameController;
    public TMP_Text Score;
    public TMP_Text HighScore;
    public float Scores;
    public float HighScores;

     void Start()
    {
        Application.targetFrameRate = 60;
        gameController = GetComponent<GameController>();
        Scores = GameController.Scoring;
        HighScores = GameController.HighScore;
        UpdateScore();

    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
            Application.Quit();
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void UpdateScore()
    {
        Score.text = ""+ Scores;
        HighScore.text = "" + HighScores;
    }

}
