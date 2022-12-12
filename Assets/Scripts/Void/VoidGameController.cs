using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoidGameController : MonoBehaviour
{
    public GameObject Enemy;
    //public GameObject EnemyLeft;
    //public GameObject EnemyRight;
    public int WhichEnemy;
    Vector2 Position;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, 2f);
    }

    private void Update()
    {
        //WhichEnemy = Random.Range(0, 1);
        //if (WhichEnemy == 0)
        //{
        //    Enemy = EnemyLeft;
        //}
        //if (WhichEnemy == 1)
        //{
        //    Enemy = EnemyRight;
        //}
        if (Input.GetKey(KeyCode.Escape))

        {

            Application.Quit();

        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
    void SpawnEnemy()
    {
        Position = new Vector2(Random.Range(-3f, 3f), -6.8f);
        Instantiate(Enemy, Position, Quaternion.identity);

    }
}
