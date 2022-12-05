using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalBehaviour : MonoBehaviour
{
    public GameObject Portal;
    public int LevelToLoad;
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
            // SceneManager.LoadScene(1);
            FindObjectOfType<SceneLoader>().TransitionAnimation(LevelToLoad);
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Obstacle" || collision.transform.tag == "Monster" || collision.transform.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }

        if(collision.transform.tag == "Player")
        {
           
            if (collision.GetComponent<PlayerBehaviour>())
            {
                collision.GetComponent<PlayerBehaviour>().IsCloseToPortal = true;
                collision.GetComponent<PlayerBehaviour>().TargetPos = gameObject.transform;
            }
            if (collision.GetComponent<VoidPlayerBehaviour>())
            {
                collision.GetComponent<VoidPlayerBehaviour>().IsCloseToPortal = true;
                collision.GetComponent<VoidPlayerBehaviour>().TargetPos = gameObject.transform;
            }
            if (collision.GetComponent<GalaxyPlayerBehaviour>())
            {
                collision.GetComponent<GalaxyPlayerBehaviour>().IsCloseToPortal = true;
                collision.GetComponent<GalaxyPlayerBehaviour>().TargetPos = gameObject.transform;
            }
        }

    }

}
