using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firepoint : MonoBehaviour
{
    public Transform FirePoint;

    public GameObject BulletPrefab;
    public float FireForce = 20f;

    public GameObject AbilityOnePrefab;
    public float AbilityOneForce = 20f;

    public GameObject AbilityTwoPrefab;
    public float AbilityTwoForce = 20f;

    public void Fire()
    {
        GameObject Bullet = Instantiate(BulletPrefab, FirePoint.position, Quaternion.identity);
       Bullet.GetComponent<Rigidbody2D>().AddForce(FirePoint.right * FireForce, ForceMode2D.Impulse);
    }
    public void FireAbilityOne()
    {
        GameObject AbilityOne = Instantiate(AbilityOnePrefab, FirePoint.position, Quaternion.identity);
        AbilityOne.GetComponent<Rigidbody2D>().AddForce(FirePoint.right * AbilityOneForce, ForceMode2D.Impulse);
    }

    public void FireAbilityTwo()
    {
        GameObject AbilityTwo = Instantiate(AbilityTwoPrefab, FirePoint.position, Quaternion.identity);
        AbilityTwo.GetComponent<Rigidbody2D>().AddForce(FirePoint.right * AbilityTwoForce, ForceMode2D.Impulse);
    }
}

