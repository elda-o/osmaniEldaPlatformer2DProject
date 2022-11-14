using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TMP_Text Score;
    public static float Scoring = 0;
    public static float HighScore = 0;
    //public PlayerBehaviour PlayerB;
   
    void Start()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{


        //    if (PlayerB.HasStartedGame == true)
        //    {

            
                InvokeRepeating("UpdateScore", 0.1f, 0.1f);
                
        //    }
        //}
    }

        public void UpdateScore()
    {
        //if (PlayerB.HasStartedGame == true)
        //{
            Scoring += 1;
            Score.text = "" + Scoring;
   
        //}

        HighScoreUpdate();
    }

    public static void HighScoreUpdate()
    {
        if (Scoring > HighScore)
        {
            HighScore = Scoring;
        }
    }
}
