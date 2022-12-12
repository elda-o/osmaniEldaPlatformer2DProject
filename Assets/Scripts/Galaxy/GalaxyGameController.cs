using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GalaxyGameController : MonoBehaviour
{
    public GameObject Enemy;
    public float YValue;
  
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, 0.8f);
    }
    void SpawnEnemy ()
    {
        YValue = Random.Range(-4.5f, 4.5f);
        Instantiate(Enemy, new Vector3(10, YValue, 0), Quaternion.identity);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))

        {

            Application.Quit();

        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }
    }


}
