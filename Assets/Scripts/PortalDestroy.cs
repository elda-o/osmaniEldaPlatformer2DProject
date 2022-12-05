using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Enemy" || collision.transform.tag == "Monster")
        {
            Destroy(collision.gameObject);
        }
    }
}
