using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public GameObject Pos;
    public RepeatingBackground [] RepeatingBackground;
    private Vector2 cameraStartPosition;

   // Background.GetComponent<RepeatingBackground>().ScrollSpeed;

    // Start is called before the first frame update
    void Start()
    {
        cameraStartPosition = transform.position;   
    }

    // Update is called once per frame
    void Update()
    { 

        transform.position = new Vector3 (Mathf.Clamp(Pos.transform.position.x, -2f, 10f), transform.position.y, transform.position.z);
        Vector2 cameraPositionChange = (Vector2) transform.position - cameraStartPosition;
        Debug.Log("cameraPositionChange.magnitude");
        if (cameraPositionChange.magnitude > 10)
        {
            for (int i =0; i<RepeatingBackground.Length; i++)
            {
                RepeatingBackground[i].ScrollSpeed = 3;
            }
          
        }

    }
}
