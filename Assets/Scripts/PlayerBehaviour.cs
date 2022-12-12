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
    //public bool IsFlying;
    //public ManaBar MB;
    //public float FlyInterval;
    //public float CurrentFlyInterval;
    public Animator Run;
    public bool IsCloseToPortal;
    public Transform TargetPos;
    public AudioClip JumpSound;
    //public AudioSource Death;

    // bool StopFly;
    void Start()
    {
        Run = GetComponent<Animator>();
        //CurrentFlyInterval = FlyInterval;
    }



    // Update is called once per frame
    void Update()
    {
        if (IsCloseToPortal)
        {
            transform.position = Vector3.MoveTowards(transform.position, TargetPos.position, Speed * Time.deltaTime);
            return;
        }
        //float xMove = Input.GetAxis("Horizontal");
        //Vector2 newPos = gameObject.transform.position;
        //newPos.x += xMove * Speed * Time.deltaTime;
        //gameObject.transform.position = newPos;

        if ((Input.GetKeyDown(KeyCode.W)  && Grounded))
        {
            rb.AddForce(Vector2.up * JumpForce * 1.25f);
            Run.Play("Jump");
            AudioSource.PlayClipAtPoint(JumpSound, new Vector3(transform.position.x, transform.position.y, -4));
        }

        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    if (HasStartedGame == false)
        //    {
                PlayerStarted?.Invoke();
                HasStartedGame = true;
        //    }
        //}

        //if (transform.position.y >= MaxY && IsFlying == true)
        //    {
        //        transform.position = new Vector2(transform.position.x, MaxY);

        //    }

        //if (Input.GetKey(KeyCode.Space) && CanFly == true)
        //{
 
        //    if (MB.Mana.value >=1)
        //    {
        //      rb.velocity += new Vector2(0, FlyForce);
        //      IsFlying = true;
        //        StopFly = true;
        //    }
        //    else if(StopFly)
        //    {
        //        StopFlying();
        //    }

        //}

        //if (Input.GetKeyUp(KeyCode.Space) && IsFlying == true)
        //{
        //    StopFlying();
        //}

        //if (IsFlying == true)
        //{
        //  if(CurrentFlyInterval > 0)
        //    {
        //        CurrentFlyInterval -= Time.deltaTime;
        //    }
        //  else
        //    {
        //        MB.Mana.value -= 1;
        //        CurrentFlyInterval = FlyInterval;
        //    }
        //}

        //if (Input.GetMouseButtonDown(0))
        //{
        //     if (MB.Mana.value >= 3)
        //    {
        //        FirePoint.Fire();
        //        MB.Mana.value -= 3;
        //    }

        //}

        //if (Input.GetKeyDown(KeyCode.Q)){

           
        //    if (MB.Mana.value >=3)
        //    {
        //        FirePoint.FireAbilityOne();
        //        MB.Mana.value -= 3;
        //    }
        //}

        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    if (MB.Mana.value >= 3)
        //    {
        //        FirePoint.FireAbilityTwo();
        //        MB.Mana.value -= 3;
        //    }
        //}
        //if (Input.GetKeyUp(KeyCode.Space) && IsFlying == true)
        //{
        //    rb.velocity = Vector2.zero;
        //    IsFlying = false;
        //}

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Grounded = true;
            Run.Play("PlayerRun");
        }

        if (collision.gameObject.tag == "Platform")
        {
            Grounded = true;
            Run.Play("PlayerRun");
        }

        if (collision.gameObject.tag == "Respawn")
        {
            //GameController.HighScoreUpdate();
            SceneManager.LoadScene(4);
        }

        Debug.Log("I'm colliding yay!");
        //AudioSource.PlayClipAtPoint(DeathSound);
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Platform")
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

    //void StopFlying()
    //{
    //    rb.velocity = Vector2.zero;
    //    IsFlying = false;
    //    CurrentFlyInterval = FlyInterval;
    //   // StopFly = false;
    //}

}
