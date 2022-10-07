using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public GameObject Pos;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    { 

        transform.position = new Vector3 (Mathf.Clamp(Pos.transform.position.x, -2f, 10f), transform.position.y, transform.position.z);
    }
}
