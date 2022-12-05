using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalBehaviour1 : MonoBehaviour
{
    public GameObject Portal;
    //public LevelManager LM;

    private void Start()
    {
        //LM = FindObjectOfType<LevelManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.transform.tag == "Player")
        {
            //LM.LoadLevel2();
            SceneManager.LoadScene(2);
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Obstacle" || collision.transform.tag == "Monster" )
        {
            Destroy(collision.gameObject);
        }

    }

}
