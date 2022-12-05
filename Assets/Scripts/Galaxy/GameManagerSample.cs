using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSample : MonoBehaviour
{
    public static GameManagerSample Instance;

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
        DontDestroyOnLoad(gameObject);
    }

}
