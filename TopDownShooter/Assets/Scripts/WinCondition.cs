using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public UIController _UIController;
    public GameObject _aviso;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (_UIController.enemiesEliminated == false)
            {
                _aviso.SetActive(true);
                Invoke("AvisoActive", 2f);
            }

            else
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }

    void AvisoActive()
    {
        _aviso.SetActive(false);
    }

}
