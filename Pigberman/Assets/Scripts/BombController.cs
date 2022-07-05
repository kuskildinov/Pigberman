
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public float timeToExplousion;

    public SpriteRenderer sr;
    public Sprite boomStay;
    public Sprite boomSoon;
    public Sprite boomSprite;

   
    private float timer;
    void Start()
    {        
        sr.sprite = boomStay;
        timer = timeToExplousion;
    }   
    void Update()
    {
        timer -= Time.deltaTime;
        BoomSoon();

        Debug.Log(timer);
    }

    void BoomSoon()
    {
        
        if (timer <= 0.2)
        {
            sr.sprite = boomSprite;
        }

        if (timer <= 0)
        {
            Destroy(gameObject);
        }

    }
}
