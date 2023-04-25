using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutline : MonoBehaviour
{
    private GameObject Outline;
    private void Start()
    {
        Outline =this.gameObject;
    }
    void OnMouseOver()
    {
        Destroy(Outline);
    }
}
