using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThings : MonoBehaviour
{
    public List<GameObject> Things= new List<GameObject>();
    public float SpawnTime = 4;

    public IEnumerator SpawnObject()
    {

        yield return new WaitForSeconds(SpawnTime);
        StartCoroutine(SpawnObject());
    }
}
