using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class UIController : MonoBehaviour
{
    public Text countText;
    private int enemyCount;
    private int totalEnemies;
    public bool enemiesEliminated = false;

    private void Start()
    {
        totalEnemies = GameObject.FindGameObjectsWithTag("Enemy").Count();
        enemyCount = -1;
        KillEnemy();
    }

    public void KillEnemy()
    {
        enemyCount++;
        countText.text = "Enemigos " + enemyCount + "/" + totalEnemies;
        CheckCount();
    }

    private void CheckCount()
    {
        if (enemyCount == totalEnemies)
        {
            enemiesEliminated = true;  
        }
    }
}
