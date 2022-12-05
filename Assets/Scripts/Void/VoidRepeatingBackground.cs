using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidRepeatingBackground : MonoBehaviour
{
    public float ScrollSpeed;
    public float ScrollWidth = 19.144f;
    public VoidGameController controller;

    // Update is called once per frame
    void Update()
    {
       

            if (transform.position.y > 10.8)
            {
                transform.position = new Vector3(0f, -10.76f, 0);
                Debug.Log(transform.position);
            }
            else
            {
                Vector2 pos = transform.position;
                pos.y += ScrollSpeed * Time.deltaTime;
                transform.position = pos;
            }


        
    }

    protected void Offscreen(ref Vector2 pos)
    {
        pos.y += 2 * ScrollWidth;
    }
}
