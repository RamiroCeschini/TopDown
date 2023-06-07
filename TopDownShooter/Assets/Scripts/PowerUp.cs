using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Gun _gunScript;

    private void Start()
    {
        _gunScript = GameObject.FindWithTag("Gun").GetComponent<Gun>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _gunScript.PowerUpActive();
            Destroy(gameObject);
        }
    }
}
