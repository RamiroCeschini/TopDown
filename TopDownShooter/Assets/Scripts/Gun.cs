using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletToSpawn;
    public bool powerUp = false;

    private void Start()
    {
        spawnPoint = GameObject.FindWithTag("BulletSpawnPoint").GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (powerUp == true)
        {
            Instantiate(bulletToSpawn, spawnPoint.position, spawnPoint.rotation);
            Instantiate(bulletToSpawn, spawnPoint.position, Quaternion.Euler(new Vector3(0f, 0f, 10f)));
            Instantiate(bulletToSpawn, spawnPoint.position, Quaternion.Euler(new Vector3(0f, 0f, -10f)));
        }
        else
        {
            Instantiate(bulletToSpawn, spawnPoint.position, spawnPoint.rotation);
        }

    }

    public void PowerUpActive()
    {
        powerUp = true;
    }
}
