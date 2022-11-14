using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSpawn1 : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            Debug.Log("TouchMonster");
            Destroy(collision.gameObject);
        }
        //if (collision.tag == "Obstacle")
        //{
        //    Debug.Log("TouchObstacle");
        //    Destroy(collision.gameObject);
        //}
        if (collision.tag == "Platform")
        {
            Debug.Log("TouchPlatform");
            Destroy(collision.gameObject);
        }
        if (collision.tag == "NeoEssence")
        {
            Debug.Log("TouchNE");
            Destroy(collision.gameObject);
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
