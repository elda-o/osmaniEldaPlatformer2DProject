using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public static TimerScript Instance;
    public Stopwatch Timer;
    public bool HasStartedGame;
    public float CurrentTime;
    public List<int> PausableScenes;
    public GameObject PauseMenu;
    public GameObject HTP;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        CurrentTime = 1;
   
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.P) && HasStartedGame == true)
        {
            Pause();
        }

        if (Timer != null)
        {
            if (Timer.Elapsed.Seconds > 5)
            {
                RestartTimer();
            }
        }

    }

    public void StartTimer()
    {
        Timer = new Stopwatch();
        Timer.Start();
        HasStartedGame = true;
    }

    void RestartTimer()
    {
        Timer.Restart();
        CurrentTime += 0.1f;
        Time.timeScale = CurrentTime;
    }

    public void ResumeGame()
    {
        Time.timeScale = CurrentTime;
        Timer.Start();
        PauseMenu.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        ScoreController.Scoring = 0;
        Timer.Restart();
        CurrentTime = 1;
        PauseMenu.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        ScoreController.Scoring = 0;
        Timer.Restart();
        CurrentTime = 1;
        PauseMenu.SetActive(false);

    }

    public void Pause()
    {
        UnityEngine.Debug.Log("Called you");
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        if (PausableScenes.Contains(CurrentScene))
        {


            Time.timeScale = 0;
            Timer.Stop();
            PauseMenu.SetActive(true);

        }
        UnityEngine.Debug.Log("Done");
    }
}

