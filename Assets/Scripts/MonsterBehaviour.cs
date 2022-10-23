using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehaviour : MonoBehaviour
{
    public GameObject Monster;
    public GameController Controller;

    void Start()
    {
        Controller = GameObject.FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == "Player")
        {
            Controller.LoadLevel();
        }

        else
        {
            Destroy(gameObject);
        }

if (collision.transform.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
       else if (collision.transform.tag == "Ability")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}