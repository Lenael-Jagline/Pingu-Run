using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public static HUDController instance;
    public Text timeCounter;
    private float startTime;
    private float elapsedTime;
    TimeSpan  timePlaying;
    public bool gamePlaying=false;

    private void Awake(){
        instance=this;
    }
    private void Start(){
        gamePlaying=false;
    }

    public void BeginGame(){
        gamePlaying = true;
        startTime = Time.time;
        TimeController.instance.BeginTimer();
    }
    public string EndGame(){
        gamePlaying = false;
        return TimeController.instance.EndTimer();
    }
}
