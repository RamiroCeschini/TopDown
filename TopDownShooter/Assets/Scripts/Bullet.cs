using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float bulletSpeed;
    public ParticleSystem brokenBullet;
    public ParticleSystem bloodPartc;
    public UIController controller;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.right * bulletSpeed);
        Invoke("DestroyBullet", 3f);
        controller = GameObject.FindWithTag("UIController").GetComponent<UIController>();
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "Enemy")
        {
            controller.KillEnemy();
            Destroy(collision.gameObject);
            DestroyBullet();
            Instantiate(bloodPartc, gameObject.transform.position, gameObject.transform.rotation);
        }
        else
        {
            Instantiate(brokenBullet, gameObject.transform.position, gameObject.transform.rotation);
            DestroyBullet();

        }

    }

}
