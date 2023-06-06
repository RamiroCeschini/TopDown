using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float bulletSpeed;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.right * bulletSpeed);
        Invoke("DestroyBullet", 3f);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }

        DestroyBullet();
    }

}
