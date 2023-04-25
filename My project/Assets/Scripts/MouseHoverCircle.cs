using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverCircle : MonoBehaviour
{
    //circle is Llama Sprite
    //Square is Fish Sprite
    //Triangle is Birb Sprite
    //Capsule is Cat Sprite
    [SerializeField] SpriteRenderer FishSR;
    [SerializeField] Sprite FFish;
    [SerializeField] Sprite LFish;
    [SerializeField] SpriteRenderer BirbSR;
    [SerializeField] Sprite BBirb;
    [SerializeField] Sprite LBirb;
    [SerializeField] GameObject Llama;
    [SerializeField] SpriteRenderer CatSR;
    [SerializeField] Sprite ECat;
    [SerializeField] Sprite LCat;
    [SerializeField] SpriteRenderer HampterSR;
    [SerializeField] Sprite HHampter;
    [SerializeField] Sprite LHampter;
    [SerializeField] Sprite ogSprite;
    private SpriteRenderer ogSpriteR;
    private void Start()
    {
        ogSpriteR = gameObject.GetComponent<SpriteRenderer>();
    }
    void OnMouseOver()
    {
        ogSpriteR.sprite = ogSprite;
        BirbSR.sprite = LBirb;
        FishSR.sprite = LFish;
        CatSR.sprite = LCat;
        HampterSR.sprite = LHampter;
    }

   
}
