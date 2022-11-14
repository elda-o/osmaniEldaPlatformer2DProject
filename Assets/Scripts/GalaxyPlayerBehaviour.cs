using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GalaxyPlayerBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 FlyForce = new Vector2(0, 100);

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(FlyForce);
            rb.gravityScale = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Killbox")
        {
            SceneManager.LoadScene(4);
        }

        if(collision.transform.tag == "Enemy")
        {
            SceneManager.LoadScene(4);
        }
    }

}
