using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSpawn : MonoBehaviour
{
    GameObject Platform;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            Destroy(collision.gameObject);
            Destroy(Platform);
        }
        if (collision.tag == "Obstacle")
        {
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
