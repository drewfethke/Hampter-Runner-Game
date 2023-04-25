using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBoxDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collison) {
        if(collison.gameObject.name == "Dead"){
       ScoreScript.scoreValue -= 1;
        Destroy(transform.parent.gameObject);
        
        }
    }
}
