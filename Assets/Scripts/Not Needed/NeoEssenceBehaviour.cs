using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeoEssenceBehaviour : MonoBehaviour
{
    public GameObject NeoEssence;
    public ScoreController Controller;
    //public GameController ControllerNE;
    void Start()
    {
        Controller = GameObject.FindObjectOfType<ScoreController>();
        //ControllerNE = GameObject.FindObjectOfType<GameController>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == "Player")
        {

            //ControllerNE.UpdateNE();
            Controller.UpdateScore();
            Destroy(gameObject);
           
        } 
        
    }

    void Update()
    {
        
    }
}
