using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyLevelManager : MonoBehaviour
{
    public GameObject Portal1;
    public GameObject Portal2;
    public int ChoosePortal;
    Vector2 Position;

    private void Start()
    {
        Invoke("SpawnPortal", Random.Range(10, 12));
        Position = new Vector2(8.5f, 0);
    }

    void SpawnPortal()
    {
        ChoosePortal = Random.Range(0, 1);

        if (ChoosePortal == 0)
        {
            Instantiate(Portal1, Position, Quaternion.identity);
        } 
        else if (ChoosePortal == 1)
        {
            Instantiate(Portal2, Position, Quaternion.identity);
        }
    }
}
