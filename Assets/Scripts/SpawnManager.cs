using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int pitChance;
    bool spawnedPit;
    public GameObject Platform;
    public GameObject FallGround;
    public static SpawnManager Instance;
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

    }

    public GameObject SelectNewObjectToSpawn()
    {
        GameObject whatWeSpawn = Platform;

        if (spawnedPit == false) { 
        
            int randomChance = Random.Range(0, 100);
        
        if (randomChance < pitChance)
        {
                whatWeSpawn = FallGround;
        }
        
        }

        if (whatWeSpawn == FallGround)
        {
            spawnedPit = true;
        }
        else
        {
            spawnedPit = false;
        }

        return whatWeSpawn;
    }

}
