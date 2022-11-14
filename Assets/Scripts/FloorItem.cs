using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorItem : MonoBehaviour
{
    public GameObject SpawnPoint;
    public float WhereToSpawn;
    public bool HasSpawned;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x <= WhereToSpawn)
        {
            if (HasSpawned == false)
            {
                SpawnNewThing();
                HasSpawned = true;
            }
        }
    }

    void SpawnNewThing()
    {
        
        GameObject NextItem = SpawnManager.Instance.SelectNewObjectToSpawn();
        Debug.Log(NextItem.name);
        Instantiate(NextItem, SpawnPoint.transform.position, Quaternion.identity);
    }

}
