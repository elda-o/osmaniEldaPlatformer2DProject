using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public ScoreController ScoreController;
    public TMP_Text Score;
    public TMP_Text HighScore;
    public float Scores;
    public float HighScores;

     void Start()
    {
        Application.targetFrameRate = 60;
        ScoreController = GetComponent<ScoreController>();
        Scores = ScoreController.Scoring;
        HighScores = ScoreController.HighScore;
        UpdateScore();
        TimerScript.Instance.CurrentTime = 1;
        Time.timeScale = 1;

    }
    public void StartGame()
    {   
        ScoreController.Scoring = 0;
        TimerScript.Instance.CurrentTime = 1;

        SceneManager.LoadScene(1);

    }
    public void MainMenu()
    {
        Debug.Log("bitch");

        ScoreController.Scoring = 0;
        TimerScript.Instance.CurrentTime = 1;

        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {
            Application.Quit();
        Debug.Log("Work?");
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
