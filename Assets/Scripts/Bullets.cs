using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Monster")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Invoke("DestroyBullet", 7);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
