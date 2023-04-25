using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HampReset : MonoBehaviour
{
    [SerializeField] GameObject Hampster;
    private SpriteRenderer ogSpriteR;
    [SerializeField] Sprite ogSprite;

    [SerializeField] SpriteRenderer FishSR;
    [SerializeField] Sprite FFish;
  

    [SerializeField] SpriteRenderer LlamaSR;
    [SerializeField] Sprite LLlama;
   
    [SerializeField] SpriteRenderer CatSR;
    [SerializeField] Sprite ECat;
    

    [SerializeField] SpriteRenderer BirbSR;
    [SerializeField] Sprite BBirb;
    

 
   
   
    
    private void Start()
    {
        ogSpriteR = gameObject.GetComponent<SpriteRenderer>();
    }
    void OnMouseOver()
    {
        ogSpriteR.sprite = ogSprite;
        BirbSR.sprite = BBirb;
        FishSR.sprite = FFish;
        CatSR.sprite = ECat;
        LlamaSR.sprite = LLlama;
    }
}
