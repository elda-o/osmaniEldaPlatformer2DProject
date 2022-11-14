using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItems : MonoBehaviour
{
    public int Delete = 10;

    private void Start()
    {
        Invoke("Deletion", Delete);
    }

    void Deletion()
    {
        Destroy(this.gameObject);
    }
}
