using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverCapsule : MonoBehaviour
{
    //circle is Llama Sprite
    //Square is Fish Sprite
    //Triangle is Birb Sprite
    //Capsule is Cat Sprite
    [SerializeField] SpriteRenderer FishSR;
    [SerializeField] Sprite FFish;
    [SerializeField] Sprite EFish;
    [SerializeField] SpriteRenderer LlamaSR;
    [SerializeField] Sprite LLlama;
    [SerializeField] Sprite ELlama;
    [SerializeField] GameObject Cat;
    [SerializeField] SpriteRenderer BirbSR;
    [SerializeField] Sprite BBirb;
    [SerializeField] Sprite EBirb;
    [SerializeField] SpriteRenderer HampterSR;
    [SerializeField] Sprite HHampter;
    [SerializeField] Sprite EHampter;
    private SpriteRenderer ogSpriteR;
    [SerializeField] Sprite ogSprite;
    private void Start()
    {
        ogSpriteR = gameObject.GetComponent<SpriteRenderer>();
    }
    void OnMouseOver()
    {
        ogSpriteR.sprite = ogSprite;
        LlamaSR.sprite = ELlama;
        FishSR.sprite = EFish;
        BirbSR.sprite = EBirb;
        HampterSR.sprite = EHampter;
    }

     
     
     
}
