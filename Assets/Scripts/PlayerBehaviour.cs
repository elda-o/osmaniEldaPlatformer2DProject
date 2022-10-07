using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce =1;
    // Rigidbody2D.AddForce (Vector2 Force);
    bool Grounded;
    public float Speed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        Vector2 newPos = gameObject.transform.position;
        newPos.x += xMove * Speed * Time.deltaTime;
        gameObject.transform.position = newPos;

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow )) && Grounded)
        {
            rb.AddForce(Vector2.up * jumpForce);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Grounded = true;
        }

        if (collision.gameObject.tag == "Respawn")
        {
            SceneManager.LoadScene(0);
        }

        Debug.Log("I'm colliding yay!");
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Grounded = false;
        }
    }


}
