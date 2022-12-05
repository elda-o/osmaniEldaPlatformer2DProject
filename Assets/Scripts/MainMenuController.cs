using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void Start()
    {
        Application.targetFrameRate = 60;
    }
    public void StartGame()
    {
        TimerScript.Instance.StartTimer();
        SceneManager.LoadScene(1);
        TimerScript.Instance.CurrentTime = 1;
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
}
