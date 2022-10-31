using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    public float ScrollSpeed;
    public float ScrollWidth = 19.144f;
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
           

            if (transform.position.x < -19.144)
            {
                transform.position = new Vector3(19.144f, 0.401f, 0);
                Debug.Log(transform.position);
            }
            else
            {
                Vector2 pos = transform.position;
                pos.x -= ScrollSpeed * Time.deltaTime;
                   transform.position = pos;
            }

           
        }
    }

    protected void Offscreen(ref Vector2 pos)
    {
        pos.x += 2 * ScrollWidth;
    }
}
