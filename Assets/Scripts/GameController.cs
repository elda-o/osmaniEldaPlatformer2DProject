using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public float ItemSpeed;
    public GameObject NeoEssence;
    public GameObject Player;
    //public TMP_Text Score;
    //public static float Scoring = 0;
    public GameObject Monster;
    public PlayerBehaviour PlayerB;
    public int NeoE = 0;
    public bool GameStarted;
    public GameObject Obstacle;
    public GameObject Platform;
    public List<GameObject> NeoIcons = new List<GameObject>();
    public int CurrentIcon = 0;
    public int RandomRyanSwanson = 0;
    //public static float HighScore = 0;
    public ManaBar MB;

    
    public void DisableNeoIcons()
    {
        for (int i = 0; i<NeoIcons.Count; i++)
        {
          //  NeoIcons[i].SetActive(false);
        }
    }

    public void SpawnNeoEssence()
    {
        Vector3 NEPosition = new Vector3(Random.Range(18, 19)+Player.transform.position.x, Random.Range(-2, 0), 0);
        GameObject temp = Instantiate(NeoEssence, NEPosition, Quaternion.identity);
        
        
    }

    public void SpawnMonster()
    {
        Vector2 MPosition = new Vector2(Random.Range(18, 19) + Player.transform.position.x, -1.94f);
        GameObject monst = Instantiate(Monster, MPosition, Quaternion.identity);
        Instantiate(Platform, new Vector2(MPosition.x, MPosition.y + 1), Quaternion.identity);
        Debug.Log("Monster");
    }
    public void SpawnObstacle()
    {
        RandomRyanSwanson = Random.Range(0, 2);
        if(RandomRyanSwanson == 1)
        {
            SpawnMonster();
        }
        else if (RandomRyanSwanson == 0)
        {
             Vector2 OPosition = new Vector2(Random.Range(18, 19) + Player.transform.position.x, -2.56f);
             GameObject obst = Instantiate(Obstacle, OPosition, Quaternion.identity);
            Debug.Log("Obstacle");
        }

    }
    void Start()
    {
        DisableNeoIcons();
        PlayerB = FindObjectOfType<PlayerBehaviour>();
        PlayerBehaviour.PlayerStarted += GameStart;
        Application.targetFrameRate = 60;

        InvokeRepeating("SpawnNeoEssence", 3f, 2f);
        InvokeRepeating("SpawnObstacle", 5f, 5f);
    }

    void GameStart()
    {
        GameStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{


        //    if (PlayerB.HasStartedGame == true)
        //    {

                //InvokeRepeating("SpawnNeoEssence", 3f, 2f);
                //InvokeRepeating("SpawnObstacle", 5f, 5f);
              
        //    }
        //}

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void UpdateNE()
    {
        //if (NeoE < 6)
        //{
        //    NeoIcons[NeoE].SetActive(true);
        //}
       
        NeoE++;
        MB.Mana.value++;
        Debug.Log(NeoE);
        
        if (NeoE >= 1)
        {
            PlayerB.CanFly = true;
          
        }

       
    }

    void NoFly()
    {
        PlayerB.CanFly = false;
        PlayerB.rb.velocity = Vector2.zero;
        NeoE = 0;
        PlayerB.IsFlying = false;
        DisableNeoIcons();
    }

    public void LoadLevel()
    {
        ScoreController.HighScoreUpdate();
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        
    }

    //public void UpdateScore()
    //{
    //   if (PlayerB.HasStartedGame == true)
    //    {
    //        Scoring += 1;
    //        Score.text = "" + Scoring;
    //    }

    //    HighScoreUpdate();
    //}

    //public static void HighScoreUpdate()
    //{
    //    if (Scoring > HighScore)
    //    {
    //        HighScore = Scoring;
    //    }
    //}

}
