using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CStir : MonoBehaviour
{
    public static string difficulte="easy";
    int level;
    int temps=0;
    
    public GameObject fabTir;

    // Update is called once per frame
    void Update()
    {
        if (difficulte=="easy"){
            level=12;
        }
        else if (difficulte=="moderate"){
            level=8;
        }
        else if (difficulte=="hard"){
            level=5;
        }
        else if (difficulte=="hardcore"){
            level=2;
        }


        if(temps==10){
        //mvt aléatoire
            float dx = Random.Range(-8.5f,8.5f);
            this.GetComponent<Transform>().position=new Vector3(dx,0.5f,49.4f);
            temps=0;
        }
        else{
            if (Random.Range(0,level) <= 0){
            //ajout d'un fabTir
                GameObject t=GameObject.Instantiate(fabTir);

                t.GetComponent<Transform>().position = new Vector3(
                    this.GetComponent<Transform>().position.x,
                    this.GetComponent<Transform>().position.y,
                    this.GetComponent<Transform>().position.z
                );
                t.GetComponent<Rigidbody>().AddForce(0,0,-200);
            
            }
            temps++;
        }

    }
}
