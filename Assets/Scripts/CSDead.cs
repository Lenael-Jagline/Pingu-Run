using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSDead : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("end")==true){
        GameObject.Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider collision){
        if (collision.gameObject.CompareTag("end")==true){
            GameObject.Destroy(this.gameObject);
        }
    }
}
