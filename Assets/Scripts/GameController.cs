using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    public void GameOver(){
        gameOverScreen.Setup();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("MenuScene");

        }
    }
}

