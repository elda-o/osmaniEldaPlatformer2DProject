using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyMovingItems : MonoBehaviour
{
    public bool Check;
    public int ItemSpeed = 7;
    //private GameController control;
    void Start()
    {
        // control = FindObjectOfType<GameController>();
    }
    void Update()
    {
        //if (control.GameStarted == true)
        //{
            Vector2 pos = transform.position;
            pos.x -= ItemSpeed * Time.deltaTime;

            transform.position = pos;
       // }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
