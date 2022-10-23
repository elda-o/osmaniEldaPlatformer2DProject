using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    public float ScrollSpeed;
    public float ScrollWidth = 17.854f;
    public GameController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.GameStarted)
        {
            Vector2 pos = transform.position;
            pos.x -= ScrollSpeed * Time.deltaTime;


            if (transform.position.x < -ScrollWidth)
            {
                Offscreen(ref pos);
            }

            transform.position = pos;
        }
    }

    protected void Offscreen(ref Vector2 pos)
    {
        pos.x += 2 * ScrollWidth;
    }
}
