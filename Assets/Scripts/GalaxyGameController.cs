using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyGameController : MonoBehaviour
{
    public GameObject Enemy;
    public float YValue;
  
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, 0.5f);
    }
    void SpawnEnemy ()
    {
        YValue = Random.Range(-4.5f, 4.5f);
        Instantiate(Enemy, new Vector3(10, YValue, 0), Quaternion.identity);
    }

}
