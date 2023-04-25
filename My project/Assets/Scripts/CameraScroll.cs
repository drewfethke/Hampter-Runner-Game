using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    // Start is called before the first frame update
   
    public Transform camera;
    private float scale;

    void Awake()
    {
        

       
        scale = 0.3f;
    }

    void OnGUI()
    {
        Vector3 pos = camera.position;
        pos.y += Input.mouseScrollDelta.y * scale;
        camera.position = pos;
    }
}
