using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent enemyAgent;
    private Transform target;
    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        InvokeRepeating("Follow", 0f, 0.2f);
    }

    void Follow()
    {
        if (Vector3.Distance(target.transform.position, enemyAgent.gameObject.transform.position) < 10f)
        {

            enemyAgent.destination = target.position; 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

}
