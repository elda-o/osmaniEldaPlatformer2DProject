using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VoidPlayerBehaviour : MonoBehaviour
{
    public float Speed =4;

    private void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        Vector2 newPos = gameObject.transform.position;
        newPos.x += xMove * Speed * Time.deltaTime;
        gameObject.transform.position = newPos;
    }


    //public float JumpForce = 1;
    //Rigidbody2D rb;
    //public bool Grounded;

    //private void Update()
    //{
    //    if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && Grounded)
    //    {
    //        rb.AddForce(Vector2.up * JumpForce * 1.2f);


    //    }
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        Grounded = true;
    //    }

    //    if (collision.gameObject.tag == "Respawn")
    //    {
    //        //GameController.HighScoreUpdate();
    //        SceneManager.LoadScene(4);
    //    }


    //}


}
