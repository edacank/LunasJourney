using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameIsOver : MonoBehaviour
{
    public GameObject gameIsOver;
   

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")==null){
            gameIsOver.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
