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
    public TMP_Text Score;
    public float Scoring = 0;
    public GameObject Monster;
    public PlayerBehaviour PlayerB;
    public int NeoE;
    public bool GameStarted;
    public GameObject Obstacle;
    public GameObject Platform;

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

    }
    public void SpawnObstacle()
    {
        Vector2 OPosition = new Vector2(Random.Range(18, 19) + Player.transform.position.x, -2.56f);
        GameObject obst = Instantiate(Obstacle, OPosition, Quaternion.identity);

    }
    void Start()
    {
        PlayerB = FindObjectOfType<PlayerBehaviour>();
        PlayerBehaviour.PlayerStarted += GameStart;
     
    }

    void GameStart()
    {
        GameStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            

            if (PlayerB.HasStartedGame == true)
            {
                
                InvokeRepeating("SpawnNeoEssence", 3f, 2f);
                InvokeRepeating("SpawnMonster", 8f, 8f);
                InvokeRepeating("SpawnObstacle", 5f, 7f);
                InvokeRepeating("UpdateScore", 2f, 5f);
            }
        }
    }
    public void UpdateNE()
    {
        NeoE++;
        Debug.Log(NeoE);
        
        if (NeoE == 3)
        {
            PlayerB.CanFly = true;
            Invoke("NoFly", 4);
        }
    }

    void NoFly()
    {
        PlayerB.CanFly = false;
        PlayerB.rb.velocity = Vector2.zero;
        NeoE = 0;
    }

    public void LoadLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void UpdateScore()
    {
       if (PlayerB.HasStartedGame == true)
        {
            Scoring += 100;
            Score.text = "" + Scoring;
        }

       
    }
}
