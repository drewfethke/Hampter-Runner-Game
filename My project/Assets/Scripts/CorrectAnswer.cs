using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    

    private void Start() {
        
    }
    private void OnMouseDown() {
        Destroy(transform.parent.gameObject);
    }
}
