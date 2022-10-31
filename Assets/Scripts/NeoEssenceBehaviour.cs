using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeoEssenceBehaviour : MonoBehaviour
{
    public GameObject NeoEssence;
    public GameController Controller;
    void Start()
    {
        Controller = GameObject.FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == "Player")
        {

            Controller.UpdateNE();
            Controller.UpdateScore();
Destroy(gameObject);
           
        } 
        
    }

    void Update()
    {
        
    }
}
