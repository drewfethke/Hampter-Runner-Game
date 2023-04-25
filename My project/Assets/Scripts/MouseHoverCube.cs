using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverCube : MonoBehaviour
{
    //call in sprites for triangle square and circle
    //
    // Start is called before the first frame update
    //circle is Llama Sprite
    //Square is Fish Sprite
    //Triangle is Birb Sprite
    //Capsule is Cat Sprite
    [SerializeField] SpriteRenderer BirbSR;
    [SerializeField] Sprite BBirb;
    [SerializeField] Sprite FBirb;
    [SerializeField] SpriteRenderer LlamaSR;
    [SerializeField] Sprite LLlama;
    [SerializeField] Sprite FLlama;
    [SerializeField] GameObject Fish;
    [SerializeField] SpriteRenderer CatSR;
    [SerializeField] Sprite ECat;
    [SerializeField] Sprite FCat;
    [SerializeField] SpriteRenderer HampterSR;
    [SerializeField] Sprite HHampter;
    [SerializeField] Sprite FHampter;
    [SerializeField] Sprite ogSprite;
    private SpriteRenderer ogSpriteR;
    private void Start()
    {
        ogSpriteR = gameObject.GetComponent<SpriteRenderer>();
    }


    void OnMouseOver()
    {
        ogSpriteR.sprite = ogSprite;
        LlamaSR.sprite = FLlama;
        BirbSR.sprite = FBirb;
        CatSR.sprite = FCat;
        HampterSR.sprite = FHampter;
    }
    
   
    
    
}
