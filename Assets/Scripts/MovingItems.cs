using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingItems : MonoBehaviour
{
    public bool Check;
    private GameController control;
    void Start()
    {
        control = FindObjectOfType<GameController>();
    }
    void Update()
    {
        if (control.GameStarted == true)
        {
            Vector2 pos = transform.position;
            pos.x -= control.ItemSpeed * Time.deltaTime;

            transform.position = pos;
        }
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

}
