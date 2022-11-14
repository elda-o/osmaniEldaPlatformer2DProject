using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoidSpawnManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Killbox")
        {
            Destroy(gameObject);
        }

        if (collision.transform.tag == "Player")
        {
            SceneManager.LoadScene(4);
        }

    }


}
