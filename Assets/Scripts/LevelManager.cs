using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

public class LevelManager : MonoBehaviour
{

    public GameObject Portal1;
    public GameObject Portal2;
    public int ChoosePortal;
    Vector2 Position;

    private void Start()
    {
        Invoke("SpawnPortal", UnityEngine.Random.Range(45, 80));
        Position = new Vector2(8.5f, 0);
    }

    void SpawnPortal()
    {
        ChoosePortal = UnityEngine.Random.Range(0, 2);

        if (ChoosePortal == 0)
        {
            Instantiate(Portal1, Position, Quaternion.identity);
        }
        else if (ChoosePortal == 1)
        {
            Instantiate(Portal2, Position, Quaternion.identity);
        }
    }
    //public float Time;
    //public GameObject Background;
    //public GameObject Background2;
    //public int CurrentLevel;
    //public List<float> LevelTimes;
    //public Stopwatch StopwatchInstance;
    //public SpriteRenderer SpriteRenderer;
    //public Sprite NewSprite;
    //public SpriteRenderer SpriteRenderer2;
    //public Sprite NewSprite2;
    //public int NextLevel;
    //public GameObject PortalLv0;
    //public GameObject PortalLv1;
    //public GameObject PortalLv2;
    //public GameObject CurrentPortal;
    //public List<GameObject> Portals;
    //public GameController GameController;

    // private void Update()
    // {
    //     if (StopwatchInstance != null)
    //     {
    //         Time = StopwatchInstance.Elapsed.Seconds;
    //     }

    //     if (Time>=LevelTimes[CurrentLevel] && CurrentPortal == null)
    //     {
    //         var PortalToSpawn= UnityEngine.Random.Range(0, Portals.Count);

    //          CurrentPortal = Instantiate(Portals[PortalToSpawn]);
    //         GameController.CancelInvoke("SpawnObstacle");
    //     }

    // }

    // private void Start()
    // {
    //     StopwatchInstance = new Stopwatch();
    //     PlayerBehaviour.PlayerStarted += StartTimer;
    //     CurrentLevel = 0;
    //     GameController = FindObjectOfType<GameController>();
    // }

    // void StartTimer()
    // {
    //     StopwatchInstance.Start();
    //     NextLevel = UnityEngine.Random.Range(0, 2);
    // }


    // public void LoadLevel2()
    // {
    //     SpriteRenderer.sprite = NewSprite;
    //     SpriteRenderer2.sprite = NewSprite;
    // }

    //public  void LoadLevel3()
    // {
    //     SpriteRenderer.sprite = NewSprite2;
    //     SpriteRenderer2.sprite = NewSprite2;
    // }

    public void CallPause()
    {
        TimerScript.Instance.Pause();
    }
}
