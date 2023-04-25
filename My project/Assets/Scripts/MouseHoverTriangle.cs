using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverTriangle : MonoBehaviour
{
    //circle is Llama Sprite
    //Square is Fish Sprite
    //Triangle is Birb Sprite
    //Capsule is Cat Sprite
    [SerializeField] SpriteRenderer FishSR;
    [SerializeField] Sprite FFish;
    [SerializeField] Sprite BFish;
    [SerializeField] SpriteRenderer LlamaSR;
    [SerializeField] Sprite LLlama;
    [SerializeField] Sprite BLlama;
    [SerializeField] GameObject Birb;
    [SerializeField] SpriteRenderer CatSR;
    [SerializeField] Sprite ECat;
    [SerializeField] Sprite BCat;
    [SerializeField] SpriteRenderer HampterSR;
    [SerializeField] Sprite HHampter;
    [SerializeField] Sprite BHampter;
   private SpriteRenderer ogSpriteR;
    [SerializeField] Sprite ogSprite;
    private void Start()
    {
        ogSpriteR = gameObject.GetComponent<SpriteRenderer>();
    }
    void OnMouseOver()
    {
        ogSpriteR.sprite = ogSprite;
        LlamaSR.sprite = BLlama;
        FishSR.sprite = BFish;
        CatSR.sprite = BCat;
        HampterSR.sprite = BHampter;
    }

   
    
   
}
