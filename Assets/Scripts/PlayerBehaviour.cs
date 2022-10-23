using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    public bool CanFly = false;
    public  bool HasStartedGame;
    public static Action PlayerStarted;
    public Firepoint FirePoint;
    public Rigidbody2D rb;
    public float JumpForce =1;
    public float FlyForce =1;
    public float MaxY =3;
    // Rigidbody2D.AddForce (Vector2 Force);
    public bool Grounded;
    public float Speed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float xMove = Input.GetAxis("Horizontal");
        //Vector2 newPos = gameObject.transform.position;
        //newPos.x += xMove * Speed * Time.deltaTime;
        //gameObject.transform.position = newPos;

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow )) && Grounded)
        {
            rb.AddForce(Vector2.up * JumpForce * 1.2f);
           

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (HasStartedGame == false)
            {
                PlayerStarted?.Invoke();
                HasStartedGame = true;
            }
        }

         if (transform.position.y >= MaxY)
            {
                transform.position = new Vector2(transform.position.x, MaxY);
            }

        if (Input.GetKey(KeyCode.Space) && CanFly == true)
        {
            rb.AddForce(Vector2.up * FlyForce);

          
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;
        }

        if (Input.GetMouseButtonDown(0))
        {
            FirePoint.Fire();

        }

        if (Input.GetKeyDown(KeyCode.Q)){

            FirePoint.FireAbilityOne();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            FirePoint.FireAbilityTwo();
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

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Grounded = true;
        }
    }


}
