using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSpawn : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
        //    Debug.Log("Destroyeeed");
            Destroy(collision.gameObject);
        }
        //if (collision.tag == "Obstacle")
        //{
        //    Destroy(collision.gameObject);
        //}
        //if (collision.tag == "Platform")
        //{
        //    Destroy(collision.gameObject);
        //}
        //if (collision.tag == "NeoEssence")
        //{
        //    Debug.Log("Destroyeeed");
        //    Destroy(collision.gameObject);
        //}
        //if (collision.tag == "FallGround")
        //{
        //    Debug.Log("Destroyeeed");
        //    Destroy(collision.gameObject);
        //}
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
