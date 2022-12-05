using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidPortalSpawn : MonoBehaviour
{
    public GameObject Portal;
    public GameObject Portal0;
    public GameObject Portal1;
    public int WhichPortal;
    Vector2 Position;

    private void Start()
    {
        Invoke("SpawnPortal", Random.Range(15f, 30f));
    }

    private void Update()
    {
        WhichPortal = Random.Range(0, 2);
        if (WhichPortal == 0)
        {
            Portal = Portal0;
        }
        if (WhichPortal == 1)
        {
            Portal = Portal1;
        }
    }
    void SpawnPortal()
    {
        Position = new Vector2(0.21f, -4.48f);
       GameObject PortalRotate = Instantiate(Portal, Position, Quaternion.identity);
        PortalRotate.transform.rotation = Quaternion.Euler(0, 0, 90);

    }
    public void CallPause()
    {
        TimerScript.Instance.Pause();
        Debug.Log("Press");
    }
}
