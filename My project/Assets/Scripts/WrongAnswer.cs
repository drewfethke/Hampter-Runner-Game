using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WrongAnswer : MonoBehaviour
{
  

    

    private void OnMouseDown() {
        Destroy(transform.parent.gameObject);
        ScoreScript.scoreValue -= 1;

    }
    
    
    //make an overall score that is updated 
}
