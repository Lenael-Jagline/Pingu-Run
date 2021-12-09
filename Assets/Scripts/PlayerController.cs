using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using UnityEngine.Audio;
public class PlayerController : MonoBehaviour
{
    public GameController gameController;
    public Scores _scores;

    public AudioSource music;
    public AudioSource death;
    public AudioSource win;


    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("ennemy")==true){
            gameController.GameOver();
            GameObject.Destroy(this.gameObject);
            if (!death.isPlaying){
                music.Stop();
                death.Play(); 
            }
        }
    }
    void OnTriggerEnter(Collider collision){
        if (collision.gameObject.CompareTag("start")==true){
            HUDController.instance.BeginGame();
            if (!music.isPlaying){
                music.Play();
            }
        }
        else if (collision.gameObject.CompareTag("finish")==true){
            _scores.NewScore();
            music.Stop();
            if (!win.isPlaying){
                win.Play();
            }

            
        }
        else if (collision.gameObject.CompareTag("easy")==true){
            CStir.difficulte="easy";
            Scores.difficulte="easy";
        }
        else if (collision.gameObject.CompareTag("moderate")==true){
            CStir.difficulte="moderate";
            Scores.difficulte="moderate";
        }
        else if (collision.gameObject.CompareTag("hard")==true){
            CStir.difficulte="hard";
            Scores.difficulte="hard";
        }
        else if (collision.gameObject.CompareTag("hardcore")==true){
            CStir.difficulte="hardcore";
            Scores.difficulte="hardcore";
        }
        else if (collision.gameObject.CompareTag("Respawn")==true){
            SceneManager.LoadScene("GameScene");
        }
        else if (collision.gameObject.CompareTag("menu")==true){
            SceneManager.LoadScene("MenuScene");
        }
    }
    
}
